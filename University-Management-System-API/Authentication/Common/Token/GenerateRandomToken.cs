using System;
using System.Text;

namespace University_Management_System_API.Authentication.Common
{
    public static class GenerateRandomToken
    {
        /// <summary>
        /// Generates a random plain text and calls the function GenerateSalt and GenerateHash
        /// </summary>
        /// <returns>Random plain text</returns>
        public static string GenerateToken()
        {
            string authToken = Guid.NewGuid().ToString();
            var plainTextBytes = Encoding.UTF8.GetBytes(authToken);

            string token = Convert.ToBase64String(plainTextBytes);

            byte[] salt = Salt.GenerateSalt();

            return HashPlainText.GenerateHash(token, salt);
        }
    }
}
