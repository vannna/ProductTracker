using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductTrackerApp.Controls;
using ProductTrackerApp.Models;
using ProductTrackerApp.Services;

namespace ProductTrackerApp.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly ISuggestionService _suggestionService;
        private readonly IUserService _userService;

        // Constructor with DI
        public AdminDashboard(ISuggestionService suggestionService, IUserService userService)
        {
            InitializeComponent();
            _suggestionService = suggestionService;
            _userService = userService;
            headerControlUC.LogoutClicked += HandleLogout;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Suggestions Tab
            dataGridViewSuggestions.DataSource = _suggestionService.GetAllSuggestions();

            comboBoxStatus.Items.AddRange(Enum.GetNames(typeof(Status)));
            comboBoxStatus.SelectedItem = Status.UNDER_REVIEW.ToString();

            // Users Tab
            dataGridViewUsers.DataSource = _userService.GetAllUsers();
            dataGridViewUsers.Columns["Password"].Visible = false;

            // Products Tab
            dataGridViewProducts.DataSource = DataStore.Products;

            // Report Tab
            comboBoxReportUser.DataSource = _userService.GetAllUsers().Select(u => u.Username).ToList();
            comboBoxReportProduct.DataSource = DataStore.Products.Select(p => p.Name).ToList();
            comboBoxReportStatus.Items.AddRange(Enum.GetNames(typeof(Status)));
        }

        // Update suggestion status
        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            var selectedSuggestion = (Suggestion)dataGridViewSuggestions.CurrentRow?.DataBoundItem;
            if (selectedSuggestion == null)
            {
                MessageBox.Show("Select a suggestion first!", "Error");
                return;
            }
            if (Enum.TryParse<Status>(comboBoxStatus.SelectedItem?.ToString(), out var newStatus))
            {
                _suggestionService.UpdateStatus(selectedSuggestion, newStatus);
                // Rebind DataGridView to refresh
                dataGridViewSuggestions.DataSource = null;
                dataGridViewSuggestions.DataSource = _suggestionService.GetAllSuggestions();
            }
        }

        // Apply report filters
        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            var filteredSuggestions = _suggestionService.GetAllSuggestions().AsQueryable();

            // User filter
            if (comboBoxReportUser.SelectedItem != null)
            {
                filteredSuggestions = filteredSuggestions
                    .Where(s => s.SubmittedBy.Username == comboBoxReportUser.SelectedItem.ToString());
            }

            // Product filter
            if (comboBoxReportProduct.SelectedItem != null)
            {
                filteredSuggestions = filteredSuggestions
                    .Where(s => s.Product.Name == comboBoxReportProduct.SelectedItem.ToString());
            }

            // Status filter
            if (comboBoxReportStatus.SelectedItem != null)
            {
                if (Enum.TryParse<Status>(comboBoxReportStatus.SelectedItem.ToString(), out var status))
                {
                    filteredSuggestions = filteredSuggestions.Where(s => s.Status == status);
                }
            }

            // Date range filters
            if (dateTimePickerReportFrom != null && dateTimePickerReportFrom.Value != DateTime.MinValue)
            {
                filteredSuggestions = filteredSuggestions
                    .Where(s => s.SubmissionDate >= dateTimePickerReportFrom.Value);
            }

            if (dateTimePickerReportTo != null && dateTimePickerReportTo.Value != DateTime.MinValue)
            {
                filteredSuggestions = filteredSuggestions
                    .Where(s => s.SubmissionDate <= dateTimePickerReportTo.Value);
            }

            dataGridViewReport.DataSource = filteredSuggestions.ToList();
        }
        private void buttonAddNewSuggestion_Click(object sender, EventArgs e)
        {
            var suggestionForm = Program.ServiceProvider.GetRequiredService<SuggestionForm>();
            suggestionForm.ShowDialog();
            RefreshSuggestions();
        }

        private void RefreshSuggestions()
        {
            dataGridViewSuggestions.DataSource = null;
            dataGridViewSuggestions.DataSource = _suggestionService.GetAllSuggestions();
        }

        private void HandleLogout(object sender, EventArgs e)
        {
            DataStore.CurrentUser = null;
            this.Hide(); // Hide instead of closing
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Form newDashboard = DataStore.CurrentUser.Role == Role.Administrator
                    ? Program.ServiceProvider.GetRequiredService<AdminDashboard>()
                    : Program.ServiceProvider.GetRequiredService<UserDashboard>();
                newDashboard.Show();
            }
            else
            {
                Application.Exit();
            }
        }

    }
}