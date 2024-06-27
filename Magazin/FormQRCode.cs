using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Magazin
{
    public partial class FormQRCode : Form
    {
        private QRCodeGenerator qrGenerator;

        public FormQRCode(string code)
        {
            InitializeComponent();

            qrGenerator = new QRCodeGenerator();

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            pictureBoxQR.Image = qrCodeImage;
        }

        private void FormQRCode_Load(object sender, EventArgs e)
        {

        }
    }
}
