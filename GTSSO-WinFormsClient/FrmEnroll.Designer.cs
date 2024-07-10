namespace GTSSO_WinFormsClient
{
    partial class FrmEnroll
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
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(591, 504);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Avançar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnNext_Click;
            // 
            // FrmEnroll
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 568);
            Controls.Add(btnLogin);
            Name = "FrmEnroll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            Load += FrmEnroll_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogin;
    }
}