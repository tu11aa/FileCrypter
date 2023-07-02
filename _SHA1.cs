using System;
using System.Security.Cryptography;
using System.Text;
public static class _SHA1
{
    public static byte[] CalculateSHA1toByte(byte[] input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            byte[] hashBytes = sha1.ComputeHash(input);
            return hashBytes;
        }
    }

    public static byte[] CalculateSHA1toByte(string input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);
            return hashBytes;
        }
    }

    public static string CalculateSHA1(byte[] input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            byte[] hashBytes = sha1.ComputeHash(input);
            string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            return hash;
        }
    }

    public static string CalculateSHA1(string input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);
            string hashValue = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            return hashValue;
        }
    }
}
