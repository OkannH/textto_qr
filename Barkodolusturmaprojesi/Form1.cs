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

namespace Barkodolusturmaprojesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData=qrGenerator.CreateQrCode(kelime,QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode= new QRCode(qRCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image= qrCodeImage;
        }

    }
}
