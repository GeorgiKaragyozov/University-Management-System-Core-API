using System;
using System.Text;
using System.Security.Cryptography;

namespace University_Management_System_API.Authentication.Common
{
    public static class HashPlainText
    {
        /// <summary>
        /// Hashing plain text plus salt with Sha512
        /// </summary>
        /// <param name="input">plain text</param>
        /// <param name="salt">salt</param>
        /// <returns>hash token</returns>
        public static string GenerateHash(string input, byte[] salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA512Managed sHA512ManagedString = new SHA512Managed();
            byte[] hash = sHA512ManagedString.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }
    }
}
