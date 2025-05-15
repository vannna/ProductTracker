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
using ProductTrackerApp.Forms;
using ProductTrackerApp.Models;
using ProductTrackerApp.Services;

namespace ProductTrackerApp
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;

        // Constructor with DI
        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required!", "Error");
                return;
            }

            User currentUser = _userService.Login(username, password);
            if (currentUser != null)
            {
                DataStore.CurrentUser = currentUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Error");
            }
        }
    }
}
