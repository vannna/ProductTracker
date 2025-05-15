namespace ProductTrackerApp.Forms
{
    partial class UserDashboard
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
            dataGridViewSuggestions = new DataGridView();
            buttonSubmitSuggestion = new Button();
            headerControlUC = new ProductTrackerApp.Controls.HeaderControlUC();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuggestions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSuggestions
            // 
            dataGridViewSuggestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuggestions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewSuggestions.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewSuggestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuggestions.Dock = DockStyle.Bottom;
            dataGridViewSuggestions.Location = new Point(0, 73);
            dataGridViewSuggestions.Name = "dataGridViewSuggestions";
            dataGridViewSuggestions.RowHeadersWidth = 51;
            dataGridViewSuggestions.Size = new Size(1160, 498);
            dataGridViewSuggestions.TabIndex = 0;
            // 
            // buttonSubmitSuggestion
            // 
            buttonSubmitSuggestion.Location = new Point(0, 542);
            buttonSubmitSuggestion.Name = "buttonSubmitSuggestion";
            buttonSubmitSuggestion.Size = new Size(1160, 29);
            buttonSubmitSuggestion.TabIndex = 1;
            buttonSubmitSuggestion.Text = "Submit New Suggestion";
            buttonSubmitSuggestion.UseVisualStyleBackColor = true;
            buttonSubmitSuggestion.Click += buttonSubmitSuggestion_Click;
            // 
            // headerControlUC
            // 
            headerControlUC.Dock = DockStyle.Top;
            headerControlUC.Location = new Point(0, 0);
            headerControlUC.Name = "headerControlUC";
            headerControlUC.Size = new Size(1160, 58);
            headerControlUC.TabIndex = 2;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 571);
            Controls.Add(headerControlUC);
            Controls.Add(buttonSubmitSuggestion);
            Controls.Add(dataGridViewSuggestions);
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Tracker";
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuggestions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSuggestions;
        private Button buttonSubmitSuggestion;
        private Controls.HeaderControlUC headerControlUC;
    }
}