using System.Security.Cryptography;
using System.Text;

public static class CryptoHelper
{
    private const int EncryptionIterations = 10000;
    private const int EncryptionKeyLength = 32;

    public static string generatePWHash(string password, byte[] salt)
    {
        int iterations = 10000;
        using (var bcrypt = new Rfc2898DeriveBytes(password, salt, iterations))
        {
            byte[] hash = bcrypt.GetBytes(60);
            byte[] hashBytes = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, hashBytes, 0, salt.Length);
            Array.Copy(hash, 0, hashBytes, salt.Length, hash.Length);
            string passwordHash = Convert.ToBase64String(hashBytes);
            return passwordHash;
        }
    }

    public static byte[] generateSalt(int saltLength)
    {
        byte[] salt = new byte[saltLength];
        using (var generator = RandomNumberGenerator.Create())
        {
            generator.GetBytes(salt);
        }
        //MMM
        return salt;
    }

    public static byte[] generateDerivedKey(string password, byte[] salt)
    {
        byte[] pw = Encoding.UTF8.GetBytes(password);
        using (var pbkdf2 = new Rfc2898DeriveBytes(pw, salt, EncryptionIterations))
        {
            return pbkdf2.GetBytes(EncryptionKeyLength);
        }
    }

    public static string encryptString(string textToEncrypt, byte[] key)
    {
        using (var aes = Aes.Create())
        {
            aes.Key = key;
            aes.GenerateIV();
            byte[] encryptedBytes;

            using (var encryptor = aes.CreateEncryptor())
            {
                byte[] pwBytes = Encoding.UTF8.GetBytes(textToEncrypt);
                encryptedBytes = encryptor.TransformFinalBlock(pwBytes, 0, pwBytes.Length);
            }
            byte[] iv = aes.IV;
            byte[] combineBytes = new byte[iv.Length + encryptedBytes.Length];
            Array.Copy(iv, combineBytes, iv.Length);
            Array.Copy(encryptedBytes, 0, combineBytes, iv.Length, encryptedBytes.Length);
            return Convert.ToBase64String(combineBytes);
        }
    }
    public static string encryptString(string textToEncrypt, string password, byte[] salt)
    {
        byte[] key = generateDerivedKey(password, salt);
        return encryptString(textToEncrypt, key);
    }
    public static string decryptString(string cipherText, byte[] key)
    {
        byte[] combinedBytes = Convert.FromBase64String(cipherText);

        using (var aes = Aes.Create())
        {
            aes.Key = key;
            byte[] iv = new byte[aes.BlockSize / 8];
            byte[] encryptedBytes = new byte[combinedBytes.Length - iv.Length];
            Array.Copy(combinedBytes, iv, iv.Length);
            Array.Copy(combinedBytes, iv.Length, encryptedBytes, 0, encryptedBytes.Length);
            aes.IV = iv;
            byte[] decrpytedBytes;
            using (var decryptor = aes.CreateDecryptor())
            {
                decrpytedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            }
            return Encoding.UTF8.GetString(decrpytedBytes);

        }
    }
    public static string decryptString(string cipherText, string password, byte[] salt)
    {
        byte[] key = generateDerivedKey(password, salt);
        return decryptString(cipherText, key);
    }

    public static string generatePW(int length)
    {
        string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{}|;:,.<>?";
        //the salt just generates random data, needed for the password
        byte[] randomdata = generateSalt(length);
        char[] password = new char[length];
        //randomly pick indexes of the characters based on the data in the randomdata array
        for (int i = 0; i < length; i++)
        {
            int index = randomdata[i] % validCharacters.Length;
            password[i] = validCharacters[index];
        }
        return new string(password);
    }
}