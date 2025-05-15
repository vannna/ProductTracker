namespace ProductTrackerApp.Controls
{
    partial class HeaderControlUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 66);
            panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(18, 18);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Log out";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // HeaderControlUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HeaderControlUC";
            Size = new Size(576, 64);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonLogout;
    }
}
