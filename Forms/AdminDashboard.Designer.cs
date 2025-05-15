namespace ProductTrackerApp.Forms
{
    partial class AdminDashboard
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
            DateTimePicker dateTimePickerReportFrom;
            tabControlAdmin = new TabControl();
            tabPageSuggestions = new TabPage();
            buttonAddNewSuggestion = new Button();
            labelSuggestionsStatus = new Label();
            buttonUpdateStatus = new Button();
            comboBoxStatus = new ComboBox();
            dataGridViewSuggestions = new DataGridView();
            tabPageUsers = new TabPage();
            dataGridViewUsers = new DataGridView();
            tabPageProducts = new TabPage();
            dataGridViewProducts = new DataGridView();
            tabPageReport = new TabPage();
            buttonApplyFilter = new Button();
            dateTimePickerReportTo = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewReport = new DataGridView();
            comboBoxReportStatus = new ComboBox();
            comboBoxReportProduct = new ComboBox();
            comboBoxReportUser = new ComboBox();
            headerControlUC = new ProductTrackerApp.Controls.HeaderControlUC();
            dateTimePickerReportFrom = new DateTimePicker();
            tabControlAdmin.SuspendLayout();
            tabPageSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuggestions).BeginInit();
            tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabPageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerReportFrom
            // 
            dateTimePickerReportFrom.Location = new Point(94, 123);
            dateTimePickerReportFrom.Name = "dateTimePickerReportFrom";
            dateTimePickerReportFrom.Size = new Size(250, 27);
            dateTimePickerReportFrom.TabIndex = 9;
            dateTimePickerReportFrom.Value = new DateTime(2025, 5, 8, 0, 0, 0, 0);
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabPageSuggestions);
            tabControlAdmin.Controls.Add(tabPageUsers);
            tabControlAdmin.Controls.Add(tabPageProducts);
            tabControlAdmin.Controls.Add(tabPageReport);
            tabControlAdmin.Dock = DockStyle.Bottom;
            tabControlAdmin.Location = new Point(0, 74);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(1491, 690);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabPageSuggestions
            // 
            tabPageSuggestions.Controls.Add(buttonAddNewSuggestion);
            tabPageSuggestions.Controls.Add(labelSuggestionsStatus);
            tabPageSuggestions.Controls.Add(buttonUpdateStatus);
            tabPageSuggestions.Controls.Add(comboBoxStatus);
            tabPageSuggestions.Controls.Add(dataGridViewSuggestions);
            tabPageSuggestions.Location = new Point(4, 29);
            tabPageSuggestions.Name = "tabPageSuggestions";
            tabPageSuggestions.Padding = new Padding(3);
            tabPageSuggestions.Size = new Size(1483, 657);
            tabPageSuggestions.TabIndex = 0;
            tabPageSuggestions.Text = "Suggestions";
            tabPageSuggestions.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewSuggestion
            // 
            buttonAddNewSuggestion.Location = new Point(1163, 556);
            buttonAddNewSuggestion.Name = "buttonAddNewSuggestion";
            buttonAddNewSuggestion.Size = new Size(267, 29);
            buttonAddNewSuggestion.TabIndex = 4;
            buttonAddNewSuggestion.Text = "Add New Suggestion";
            buttonAddNewSuggestion.UseVisualStyleBackColor = true;
            buttonAddNewSuggestion.Click += buttonAddNewSuggestion_Click;
            // 
            // labelSuggestionsStatus
            // 
            labelSuggestionsStatus.AutoSize = true;
            labelSuggestionsStatus.Location = new Point(1181, 26);
            labelSuggestionsStatus.Name = "labelSuggestionsStatus";
            labelSuggestionsStatus.Size = new Size(52, 20);
            labelSuggestionsStatus.TabIndex = 3;
            labelSuggestionsStatus.Text = "Status:";
            // 
            // buttonUpdateStatus
            // 
            buttonUpdateStatus.Location = new Point(1181, 70);
            buttonUpdateStatus.Name = "buttonUpdateStatus";
            buttonUpdateStatus.Size = new Size(229, 29);
            buttonUpdateStatus.TabIndex = 2;
            buttonUpdateStatus.Text = "Update Status";
            buttonUpdateStatus.UseVisualStyleBackColor = true;
            buttonUpdateStatus.Click += buttonUpdateStatus_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(1259, 23);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 1;
            // 
            // dataGridViewSuggestions
            // 
            dataGridViewSuggestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuggestions.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewSuggestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuggestions.Dock = DockStyle.Left;
            dataGridViewSuggestions.Location = new Point(3, 3);
            dataGridViewSuggestions.Name = "dataGridViewSuggestions";
            dataGridViewSuggestions.RowHeadersWidth = 51;
            dataGridViewSuggestions.Size = new Size(1094, 651);
            dataGridViewSuggestions.TabIndex = 0;
            // 
            // tabPageUsers
            // 
            tabPageUsers.Controls.Add(dataGridViewUsers);
            tabPageUsers.Location = new Point(4, 29);
            tabPageUsers.Name = "tabPageUsers";
            tabPageUsers.Padding = new Padding(3);
            tabPageUsers.Size = new Size(1483, 657);
            tabPageUsers.TabIndex = 1;
            tabPageUsers.Text = "Users";
            tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(3, 3);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(1477, 651);
            dataGridViewUsers.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            tabPageProducts.Controls.Add(dataGridViewProducts);
            tabPageProducts.Location = new Point(4, 29);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1483, 657);
            tabPageProducts.TabIndex = 2;
            tabPageProducts.Text = "Products";
            tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(3, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(1477, 651);
            dataGridViewProducts.TabIndex = 0;
            // 
            // tabPageReport
            // 
            tabPageReport.Controls.Add(buttonApplyFilter);
            tabPageReport.Controls.Add(dateTimePickerReportTo);
            tabPageReport.Controls.Add(dateTimePickerReportFrom);
            tabPageReport.Controls.Add(label5);
            tabPageReport.Controls.Add(label4);
            tabPageReport.Controls.Add(label3);
            tabPageReport.Controls.Add(label2);
            tabPageReport.Controls.Add(label1);
            tabPageReport.Controls.Add(dataGridViewReport);
            tabPageReport.Controls.Add(comboBoxReportStatus);
            tabPageReport.Controls.Add(comboBoxReportProduct);
            tabPageReport.Controls.Add(comboBoxReportUser);
            tabPageReport.Location = new Point(4, 29);
            tabPageReport.Name = "tabPageReport";
            tabPageReport.Padding = new Padding(3);
            tabPageReport.Size = new Size(1483, 657);
            tabPageReport.TabIndex = 3;
            tabPageReport.Text = "Report";
            tabPageReport.UseVisualStyleBackColor = true;
            // 
            // buttonApplyFilter
            // 
            buttonApplyFilter.Location = new Point(170, 231);
            buttonApplyFilter.Name = "buttonApplyFilter";
            buttonApplyFilter.Size = new Size(174, 29);
            buttonApplyFilter.TabIndex = 11;
            buttonApplyFilter.Text = "Apply Filter";
            buttonApplyFilter.UseVisualStyleBackColor = true;
            buttonApplyFilter.Click += buttonApplyFilter_Click;
            // 
            // dateTimePickerReportTo
            // 
            dateTimePickerReportTo.Location = new Point(94, 158);
            dateTimePickerReportTo.Name = "dateTimePickerReportTo";
            dateTimePickerReportTo.Size = new Size(250, 27);
            dateTimePickerReportTo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 158);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Date to:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 128);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 7;
            label4.Text = "Date from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 43);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Product:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 14);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 4;
            label1.Text = "User:";
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReport.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Dock = DockStyle.Right;
            dataGridViewReport.Location = new Point(375, 3);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(1105, 651);
            dataGridViewReport.TabIndex = 3;
            // 
            // comboBoxReportStatus
            // 
            comboBoxReportStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReportStatus.FlatStyle = FlatStyle.Flat;
            comboBoxReportStatus.FormattingEnabled = true;
            comboBoxReportStatus.Location = new Point(105, 74);
            comboBoxReportStatus.Name = "comboBoxReportStatus";
            comboBoxReportStatus.Size = new Size(239, 28);
            comboBoxReportStatus.TabIndex = 2;
            // 
            // comboBoxReportProduct
            // 
            comboBoxReportProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReportProduct.FlatStyle = FlatStyle.Flat;
            comboBoxReportProduct.FormattingEnabled = true;
            comboBoxReportProduct.Location = new Point(105, 40);
            comboBoxReportProduct.Name = "comboBoxReportProduct";
            comboBoxReportProduct.Size = new Size(239, 28);
            comboBoxReportProduct.TabIndex = 1;
            // 
            // comboBoxReportUser
            // 
            comboBoxReportUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReportUser.FlatStyle = FlatStyle.Flat;
            comboBoxReportUser.FormattingEnabled = true;
            comboBoxReportUser.Location = new Point(105, 6);
            comboBoxReportUser.Name = "comboBoxReportUser";
            comboBoxReportUser.Size = new Size(239, 28);
            comboBoxReportUser.TabIndex = 0;
            // 
            // headerControlUC
            // 
            headerControlUC.Location = new Point(0, 0);
            headerControlUC.Name = "headerControlUC";
            headerControlUC.Size = new Size(1491, 68);
            headerControlUC.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 764);
            Controls.Add(headerControlUC);
            Controls.Add(tabControlAdmin);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Tracker";
            Load += AdminDashboard_Load;
            tabControlAdmin.ResumeLayout(false);
            tabPageSuggestions.ResumeLayout(false);
            tabPageSuggestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuggestions).EndInit();
            tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tabPageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabPageReport.ResumeLayout(false);
            tabPageReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabPageSuggestions;
        private TabPage tabPageUsers;
        private ComboBox comboBoxStatus;
        private DataGridView dataGridViewSuggestions;
        private TabPage tabPageProducts;
        private TabPage tabPageReport;
        private Button buttonUpdateStatus;
        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewProducts;
        private ComboBox comboBoxReportStatus;
        private ComboBox comboBoxReportProduct;
        private ComboBox comboBoxReportUser;
        private DataGridView dataGridViewReport;
        private DateTimePicker dateTimePickerReportFrom;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerReportTo;
        private Label labelSuggestionsStatus;
        private Button buttonApplyFilter;
        private Controls.HeaderControlUC headerControlUC;
        private Button buttonAddNewSuggestion;
    }
}