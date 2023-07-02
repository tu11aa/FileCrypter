using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Linq;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, System.EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Encrypt>().Any())
            {
                Application.OpenForms.OfType<Form_Encrypt>().First().BringToFront();
            }
            else
            {
                Form_Encrypt f = new Form_Encrypt();
                f.Show();
            }
        }

        private void buttonDecrypt_Click(object sender, System.EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Decrypt>().Any())
            {
                Application.OpenForms.OfType<Form_Decrypt>().First().BringToFront();
            }
            else
            {
                Form_Decrypt f = new Form_Decrypt();
                f.Show();
            }
        }
    }
}
