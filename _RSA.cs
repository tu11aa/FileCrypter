using System.Security.Cryptography;
using System.Text;

public static class _RSA
{
    private static RSA m_RSA;

    static _RSA()
    {
        m_RSA = RSA.Create();
    }

    public static (RSAParameters, RSAParameters) GenerateSecretKey()
    {
        RSAParameters publicKeyBytes = m_RSA.ExportParameters(false);
        RSAParameters privateKeyBytes = m_RSA.ExportParameters(true);

        return (publicKeyBytes, privateKeyBytes);
    }

    public static byte[] Encrypt(byte[] bytes, RSAParameters publicKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportParameters(publicKey);
            byte[] encryptedBytes = rsa.Encrypt(bytes, RSAEncryptionPadding.Pkcs1);
            return encryptedBytes;
        }
    }

    public static byte[] Encrypt(string plainText, RSAParameters publicKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportParameters(publicKey);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes = rsa.Encrypt(plainBytes, RSAEncryptionPadding.Pkcs1);
            return encryptedBytes;
        }
    }

    /*public static string Decrypt(byte[] encryptedData, RSAParameters privateKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportParameters(privateKey);
            byte[] decryptedBytes = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);
            string decryptedString = Encoding.UTF8.GetString(decryptedBytes);
            return decryptedString;
        }
    }*/

    public static byte[] Decrypt(byte[] encryptedData, RSAParameters privateKey)
    {
        using (RSA rsa = RSA.Create())
        {
            rsa.ImportParameters(privateKey);
            byte[] decryptedBytes = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);
            return decryptedBytes;
        }
    }
}