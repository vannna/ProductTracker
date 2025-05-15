using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductTrackerApp.Models;
using ProductTrackerApp.Services;

namespace ProductTrackerApp.Forms
{
    public partial class SuggestionForm : Form
    {
        private readonly ISuggestionService _suggestionService;

        // Constructor with DI  
        public SuggestionForm(ISuggestionService suggestionService)
        {
            InitializeComponent();
            _suggestionService = suggestionService;

            // Populate products in ComboBox  
            comboBoxProduct.DataSource = DataStore.Products;
            comboBoxProduct.DisplayMember = "Name";
        }

        // Save button logic  
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSuggestion.Text))
            {
                MessageBox.Show("Enter a suggestion!", "Error");
                return;
            }

            Product selectedProduct = (Product)comboBoxProduct.SelectedItem;
            if (selectedProduct == null)
            {
                MessageBox.Show("Select a product!");
                return;
            }

            _suggestionService.AddSuggestion(selectedProduct, textBoxSuggestion.Text);
            this.Close();
        }
    }
}

