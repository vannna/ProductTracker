using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductTrackerApp.Controls;
using ProductTrackerApp.Models;
using ProductTrackerApp.Services;

namespace ProductTrackerApp.Forms
{
    public partial class UserDashboard : Form
    {
        private readonly ISuggestionService _suggestionService;

        // Constructor with DI  
        public UserDashboard(ISuggestionService suggestionService)
        {
            InitializeComponent();
            _suggestionService = suggestionService;
            headerControlUC.LogoutClicked += HandleLogout;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            // Fetch user's suggestions via service  
            var userSuggestions = _suggestionService.GetSuggestionsByUser(DataStore.CurrentUser);

            // Bind to DataGridView  
            dataGridViewSuggestions.DataSource = userSuggestions;

            // Hide internal columns  
            dataGridViewSuggestions.Columns["SubmittedBy"].Visible = false;
            dataGridViewSuggestions.Columns["Id"].Visible = false;
            dataGridViewSuggestions.Columns["SubmissionDate"].HeaderText = "Date Submitted";
        }

        // Handle "Submit New Suggestion" button  
        private void buttonSubmitSuggestion_Click(object sender, EventArgs e)
        {
            var suggestionForm = Program.ServiceProvider.GetRequiredService<SuggestionForm>();
            suggestionForm.ShowDialog();
            // Rebind DataGridView to refresh
            var userSuggestions = _suggestionService.GetSuggestionsByUser(DataStore.CurrentUser!);
            dataGridViewSuggestions.DataSource = null;
            dataGridViewSuggestions.DataSource = userSuggestions;
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
