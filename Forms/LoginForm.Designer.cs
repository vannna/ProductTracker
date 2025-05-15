namespace ProductTrackerApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUsername = new Label();
            textBoxUserName = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(91, 67);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(85, 20);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "UserName: ";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(179, 62);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(269, 27);
            textBoxUserName.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(94, 113);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(354, 207);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(179, 116);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(269, 27);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 281);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelUsername);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private TextBox textBoxUserName;
        private Label labelPassword;
        private Button buttonLogin;
        private TextBox textBoxPassword;
    }
}