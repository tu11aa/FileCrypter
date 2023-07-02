using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project1
{
    public partial class Form_Encrypt : Form
    {
        public static readonly string ms_prefix = "encrypted_";

        public Form_Encrypt()
        {
            InitializeComponent();
        }

        private void onInputFileButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelSelectedFile.Text = "Selected file: " + ofd.FileName;

                labelEcyptedFile.Text = "Encrypted file: ";
            }
        }

        private void onButtonEncryptClick(object sender, EventArgs e)
        {
            //preproccess
            string cleanFilePath = labelSelectedFile.Text;
            if (cleanFilePath.Length == 15)
            {
                MessageBox.Show("Please select a file.");
                return;
            }

            cleanFilePath = cleanFilePath.Replace("Selected file: ", "");
            string filePath = Path.GetDirectoryName(cleanFilePath);//get file path
            string fileName = Path.GetFileName(labelSelectedFile.Text);//get file name

            string encyptedFile = filePath + "\\" + ms_prefix + fileName;
            byte[] key = AES.GenerateSecretKey();
            AES.EncryptFile(cleanFilePath, encyptedFile, key);

            labelEcyptedFile.Text = "Encrypted file: " + encyptedFile;

            afterEncrypt(key, filePath);
        }

        private void afterEncrypt(byte[] key, string filePath)
        {
            (RSAParameters, RSAParameters) rsaKeys = _RSA.GenerateSecretKey();

            {//for system to save key
                byte[] Kx = _RSA.Encrypt(key, rsaKeys.Item1);
                byte[] HKprivate = _SHA1.CalculateSHA1toByte(SerializeRSAParameters(rsaKeys.Item2));

                KeyData keyData = new KeyData { Kx = Kx, HKprivate = HKprivate };

                string keyFilePath = Directory.GetCurrentDirectory() + "\\Keys";
                XmlSerializer serializer = new XmlSerializer(typeof(KeyData));
                if (!Directory.Exists(keyFilePath))
                {
                    Directory.CreateDirectory(keyFilePath);
                }
                using (StreamWriter writer = new StreamWriter(keyFilePath + "\\keyFilePath.xml"))
                {
                    serializer.Serialize(writer, keyData);
                }
            }

            {//for user
                XmlSerializer serializer = new XmlSerializer(typeof(RSAParameters));
                string keyFilePath = filePath + "\\private_key.xml";
                using (StreamWriter writer = new StreamWriter(keyFilePath))
                {
                    serializer.Serialize(writer, rsaKeys.Item2);
                }
            }
        }

        static public string SerializeRSAParameters(RSAParameters parameters)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(parameters.Exponent.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.Exponent).Replace("-", ""));
            sb.Append(",");
            sb.Append(parameters.Modulus.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.Modulus).Replace("-", ""));
            sb.Append(",");
            sb.Append(parameters.P.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.P).Replace("-", ""));
            sb.Append(",");
            sb.Append(parameters.Q.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.Q).Replace("-", ""));
            sb.Append(",");
            sb.Append(parameters.DP.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.DP).Replace("-", ""));
            sb.Append(",");
            sb.Append(parameters.DQ.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.DQ).Replace("-", ""));
            sb.Append(",");
            sb.Append(parameters.InverseQ.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.InverseQ).Replace("-", ""));
            sb.Append(",");
            sb.Append(parameters.D.Length);
            sb.Append(",");
            sb.Append(BitConverter.ToString(parameters.D).Replace("-", ""));

            return sb.ToString();
        }
    }
}
