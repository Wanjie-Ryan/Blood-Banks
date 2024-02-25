namespace Blood_Banks.UI
{
    partial class users
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
            panelTop = new Panel();
            lblusersForm = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.Control;
            panelTop.Controls.Add(lblusersForm);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 4, 5, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1200, 70);
            panelTop.TabIndex = 0;
            // 
            // lblusersForm
            // 
            lblusersForm.AutoSize = true;
            lblusersForm.Cursor = Cursors.Hand;
            lblusersForm.Font = new Font("Harrington", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusersForm.ForeColor = SystemColors.ControlText;
            lblusersForm.Location = new Point(544, 31);
            lblusersForm.Name = "lblusersForm";
            lblusersForm.Size = new Size(97, 35);
            lblusersForm.TabIndex = 0;
            lblusersForm.Text = "Users";
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelTop);
            Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "users";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblusersForm;
    }
}