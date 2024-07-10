namespace GTSSO_WinFormsClient
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnCancel = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            lblPass = new Label();
            saveFileDialog1 = new SaveFileDialog();
            txtOtp = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(279, 223);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(125, 223);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(125, 65);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(401, 31);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "leonardo.rocha@globaltechti.com.br";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(266, 31);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Yamaha2024£";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 119);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 4;
            label1.Text = "Pass";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(26, 68);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(72, 25);
            lblPass.TabIndex = 5;
            lblPass.Text = "Usuário";
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(125, 163);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(266, 31);
            txtOtp.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 166);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 7;
            label2.Text = "Otp";
            // 
            // button1
            // 
            button1.Location = new Point(414, 163);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Enroll";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEnroll_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 325);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtOtp);
            Controls.Add(lblPass);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GT SSO Login";            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label label1;
        private Label lblPass;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtOtp;
        private Label label2;
        private Button button1;
    }
}
