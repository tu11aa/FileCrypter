using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project1
{
    public partial class Form_Decrypt : Form
    {
        byte[] m_aesKey = null;
        private RSAParameters m_PrivKey;
        private string m_filePath = string.Empty;
        private string m_fileName = string.Empty;
        public static readonly string ms_prefix = "decrypted_";
        private static readonly string ms_keypath = "\\Keys\\keyFilePath.xml";

        public Form_Decrypt()
        {
            InitializeComponent();
        }

        private void onInputFileButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                DefaultExt = ".txt"
            };

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_filePath = Path.GetDirectoryName(ofd.FileName);
                m_fileName = Path.GetFileName(ofd.FileName);
                m_fileName = m_fileName.Replace(Form_Encrypt.ms_prefix, "");

                labelSelectedFile.Text = "Selected file: " + ofd.FileName;

                labelSelectPrivKey.Text = "Selected Private Key file: ";

                labelDecyptedFile.Text = "Decrypted file: ";
            }
        }

        private void onButtonDecryptClick(object sender, EventArgs e)
        {
            //preproccess
            if (m_filePath.Length == 0)
            {
                MessageBox.Show("Please select a file.");
                return;
            }
            if (labelSelectPrivKey.Text.Length == 27)
            {
                MessageBox.Show("Please select private key.");
                return;
            }

            string decyptedFile = m_filePath + "\\" + ms_prefix + m_fileName;

            AES.DecryptFile(m_filePath + "\\" + Form_Encrypt.ms_prefix + m_fileName, decyptedFile, m_aesKey);

            labelDecyptedFile.Text = "Decrypted file: " + decyptedFile;
        }

        private void onButtonSelectPrivKeyClick(object sender, EventArgs e)
        {
            if (m_filePath.Length == 0)
            {
                MessageBox.Show("Please select file to decrypt!!!");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog
            {
                DefaultExt = ".xml"
            };

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelSelectPrivKey.Text = "Selected Private Key file: " + ofd.FileName;
            }
            else
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(RSAParameters));
            using (StreamReader reader = new StreamReader(m_filePath + "\\private_key.xml"))
            {
                m_PrivKey = (RSAParameters)serializer.Deserialize(reader);
            }

            afterPrivavteKey();
        }

        private void afterPrivavteKey()
        {
            KeyData keyData;

            XmlSerializer serializer = new XmlSerializer(typeof(KeyData));
            using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + ms_keypath))
            {
                keyData = (KeyData)serializer.Deserialize(reader);
            }

            byte[] myHKprivate = _SHA1.CalculateSHA1toByte(Form_Encrypt.SerializeRSAParameters(m_PrivKey));

            if (!myHKprivate.SequenceEqual(keyData.HKprivate))
            {
                MessageBox.Show("Invalid private key!");
            }
            else
            {
                m_aesKey = _RSA.Decrypt(keyData.Kx, m_PrivKey);
            }
        }
    }
}
