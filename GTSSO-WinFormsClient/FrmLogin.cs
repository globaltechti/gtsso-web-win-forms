using GTSSOWinFormsClient.Application;
using GTSSO_WinFormsClient.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace GTSSO_WinFormsClient
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.btnCancel.Click += (s, e) =>
            {
                Exit();
            };


            void Exit()
            {
                var result = MessageBox.Show("Exit GT SSO?", "Exit?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var ssoApplication = new SSOApplication();

            var otpExists = Task.Run<bool>(() =>
            {
                return ssoApplication.OtpUserExistsAsync(
                    txtLogin.Text);
            });

            bool otpUserExists = otpExists.Result;

            if (!otpUserExists)
            {

                MessageBox.Show("User sem OTP faça o cadastro antes.", "Erro", MessageBoxButtons.OK);

                return;
            }

            var userTask = Task.Run<User>(() =>
            {
                return ssoApplication.LoginAsync(
                txtLogin.Text, txtPassword.Text
                , txtOtp.Text);
            });

            var user = userTask.Result;

            if (user.Authenticated)
            {
                if (user.RequireMfa)
                {

                    if (user.RequireEnrollement)
                    {
                        this.Hide();
                        new FrmMain().ShowDialog();
                    }
                }
                else
                {
                    new FrmMain().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível autenticar o usuário", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnOtpCheck_Click(object sender, EventArgs e)
        {
            var ssoApplication = new SSOApplication();

            var userTask = Task.Run<User>(() =>
            {
                return ssoApplication.LoginAsync(
                txtLogin.Text, txtPassword.Text
                , txtOtp.Text);
            });
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {

            var ssoApplication = new SSOApplication();

            var otpExists = Task.Run<bool>(() =>
            {
                return ssoApplication.OtpUserExistsAsync(
                    txtLogin.Text);
            });

            bool otpUserExists = otpExists.Result;

            if (otpUserExists)
            {

                MessageBox.Show("Usuário já possui OTP cadastrado", "Erro", MessageBoxButtons.OK);

                return;
            }

            var config = new Config();
            OpenUrl(config.UrlEnrollOtp);
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
