using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

public static class AES
{
    public static byte[] GenerateSecretKey()
    {
        using (Aes aes = Aes.Create())
        {
            aes.GenerateKey();
            return aes.Key;
        }
    }

    public static void EncryptFile(string inputFile, string encryptedFile, byte[] key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;

            // Generate a random IV (Initialization Vector)
            aes.IV = GetIV(aes);

            // Encrypt the file content and append to the encrypted file
            using (FileStream inputFileStream = File.Open(inputFile, FileMode.Open))
            using (CryptoStream cryptoStream = new CryptoStream(
                File.Create(encryptedFile),
                aes.CreateEncryptor(),
                CryptoStreamMode.Write))
            {
                inputFileStream.CopyTo(cryptoStream);
            }
        }
    }

    public static void DecryptFile(string encryptedFile, string decryptedFile, byte[] key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;

            // Read the IV from the encrypted file
            aes.IV = GetIV(aes);

            // Decrypt the file content
            using (FileStream decryptedFileStream = File.Create(decryptedFile))
            using (CryptoStream cryptoStream = new CryptoStream(
                File.OpenRead(encryptedFile),
                aes.CreateDecryptor(),
                CryptoStreamMode.Read))
            {
                cryptoStream.CopyTo(decryptedFileStream);
            }
        }
    }

    private static byte[] GetIV(Aes aes, bool forceRegenerateIV = false)
    {
        string ivFilePath = Directory.GetCurrentDirectory() + "\\Keys\\IV.xml";
        string keyFilePath = Directory.GetCurrentDirectory() + "\\Keys";

        if (!File.Exists(ivFilePath) || forceRegenerateIV)
        {
            aes.GenerateIV();

            if (!Directory.Exists(keyFilePath))
            {
                Directory.CreateDirectory(keyFilePath);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(byte[]));
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Keys\\IV.xml"))
            {
                serializer.Serialize(writer, aes.IV);
            }

            return aes.IV;            
        }
        else
        {
            XmlSerializer serializer = new XmlSerializer(typeof(byte[]));
            using (StreamReader reader = new StreamReader(ivFilePath))
            {
                aes.IV = (byte[])serializer.Deserialize(reader);
                return aes.IV;
            }
        }
    }
}