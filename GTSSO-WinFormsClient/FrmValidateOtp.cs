namespace GTSSO_WinFormsClient
{
    public partial class FrmValidateOtp : Form
    {
        public FrmValidateOtp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new FrmEnroll().Show();
            this.Close();
        }

        private void btnValidateOtp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {

                MessageBox.Show("Informe o segundo fator.");

                return;
            }

            if (txtLogin.Text.Equals("123456"))
            {

                new FrmMain().Show();
                this.Close();

                return;
            }

            MessageBox.Show("Segundo fator é inválido");
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
