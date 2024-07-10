using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTSSO_WinFormsClient
{
    public partial class FrmEnroll : Form
    {
        public FrmEnroll()
        {
            InitializeComponent();
            
        }

        private void LoadLoginQrCode() { 
        
        }

        private void LoadQrCode()
        {
            string qrCodeFilePath = "QRCodeSample.txt";
            if (!File.Exists(qrCodeFilePath))
                MessageBox.Show($"file {qrCodeFilePath} was not found.");

            var qrCodeAsText = File.ReadAllText(qrCodeFilePath);

            byte[] imageBytes = Convert.FromBase64String(qrCodeAsText);

            // Convert byte array to Image
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);

                // Save the image to a file
                image.Save("output_image.png", ImageFormat.Png);

              
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            new FrmValidateOtp().ShowDialog();
            this.Close();
        }

        private void FrmEnroll_Load(object sender, EventArgs e)
        {

        }

        private void pctBox_Click(object sender, EventArgs e)
        {

        }
    }
}
