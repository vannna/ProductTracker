namespace ProductTrackerApp.Forms
{
    partial class SuggestionForm
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
            labelProduct = new Label();
            labelSuggestionText = new Label();
            comboBoxProduct = new ComboBox();
            textBoxSuggestion = new TextBox();
            buttonSave = new Button();
            labelSuggestionStatus = new Label();
            comboBoxSuggestionStatus = new ComboBox();
            SuspendLayout();
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(37, 27);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(107, 20);
            labelProduct.TabIndex = 0;
            labelProduct.Text = "Select Product:";
            // 
            // labelSuggestionText
            // 
            labelSuggestionText.AutoSize = true;
            labelSuggestionText.Location = new Point(27, 69);
            labelSuggestionText.Name = "labelSuggestionText";
            labelSuggestionText.Size = new Size(117, 20);
            labelSuggestionText.TabIndex = 1;
            labelSuggestionText.Text = "Suggestion Text:";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.FlatStyle = FlatStyle.Flat;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(150, 24);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(248, 28);
            comboBoxProduct.TabIndex = 2;
            // 
            // textBoxSuggestion
            // 
            textBoxSuggestion.Location = new Point(150, 66);
            textBoxSuggestion.Multiline = true;
            textBoxSuggestion.Name = "textBoxSuggestion";
            textBoxSuggestion.Size = new Size(248, 136);
            textBoxSuggestion.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(283, 301);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelSuggestionStatus
            // 
            labelSuggestionStatus.AutoSize = true;
            labelSuggestionStatus.Location = new Point(14, 226);
            labelSuggestionStatus.Name = "labelSuggestionStatus";
            labelSuggestionStatus.Size = new Size(130, 20);
            labelSuggestionStatus.TabIndex = 5;
            labelSuggestionStatus.Text = "Suggestion Status:";
            // 
            // comboBoxSuggestionStatus
            // 
            comboBoxSuggestionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuggestionStatus.FlatStyle = FlatStyle.Flat;
            comboBoxSuggestionStatus.FormattingEnabled = true;
            comboBoxSuggestionStatus.Location = new Point(150, 226);
            comboBoxSuggestionStatus.Name = "comboBoxSuggestionStatus";
            comboBoxSuggestionStatus.Size = new Size(248, 28);
            comboBoxSuggestionStatus.TabIndex = 6;
            // 
            // SuggestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 355);
            Controls.Add(comboBoxSuggestionStatus);
            Controls.Add(labelSuggestionStatus);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSuggestion);
            Controls.Add(comboBoxProduct);
            Controls.Add(labelSuggestionText);
            Controls.Add(labelProduct);
            Name = "SuggestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suggestion Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProduct;
        private Label labelSuggestionText;
        private ComboBox comboBoxProduct;
        private TextBox textBoxSuggestion;
        private Button buttonSave;
        private Label labelSuggestionStatus;
        private ComboBox comboBoxSuggestionStatus;
    }
}