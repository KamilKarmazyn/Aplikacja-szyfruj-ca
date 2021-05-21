using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proseminarium1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string hash = "balbonik";

        private void kłódkaotwr2_Click(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(richTextBox1.Text);
            using (MD5CryptoServiceProvider a = new MD5CryptoServiceProvider())
            {
                byte[] klucz = a.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider b = new TripleDESCryptoServiceProvider() { Key = klucz, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transformacja = b.CreateDecryptor();
                    byte[] efekt = transformacja.TransformFinalBlock(data, 0, data.Length);
                    richTextBox2.Text = UTF8Encoding.UTF8.GetString(efekt);
                }
            }
        }

        private void kłódkazamk1_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(richTextBox3.Text);
            using (MD5CryptoServiceProvider a = new MD5CryptoServiceProvider())
            {
                byte[] klucz = a.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider b = new TripleDESCryptoServiceProvider() { Key = klucz, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transformacja = b.CreateEncryptor();
                    byte[] efekt = transformacja.TransformFinalBlock(data, 0, data.Length);
                    richTextBox1.Text = Convert.ToBase64String(efekt, 0, efekt.Length);
                }
            }
        }
    }
}



