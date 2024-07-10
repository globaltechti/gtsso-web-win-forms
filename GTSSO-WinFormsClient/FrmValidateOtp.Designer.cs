namespace GTSSO_WinFormsClient
{
    partial class FrmValidateOtp
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
            lblPass = new Label();
            txtLogin = new TextBox();
            btnCancel = new Button();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(98, 63);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(71, 25);
            lblPass.TabIndex = 7;
            lblPass.Text = "Código";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(175, 63);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(266, 31);
            txtLogin.TabIndex = 6;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(175, 142);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Voltar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(319, 142);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(112, 34);
            btnValidar.TabIndex = 8;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidateOtp_Click;
            // 
            // FrmValidateOtp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 227);
            Controls.Add(btnCancel);
            Controls.Add(btnValidar);
            Controls.Add(lblPass);
            Controls.Add(txtLogin);
            Name = "FrmValidateOtp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validar OTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPass;
        private TextBox txtLogin;
        private Button btnCancel;
        private Button btnValidar;
    }
}