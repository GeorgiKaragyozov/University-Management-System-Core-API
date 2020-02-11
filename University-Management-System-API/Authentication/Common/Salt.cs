using System.Security.Cryptography;

namespace University_Management_System_API.Authentication.Common
{
    public static class Salt
    {
        /// <summary>
        /// Create random salt with array of byte
        /// </summary>
        /// <returns>Random salt</returns>
        public static byte[] CreateRandomSalt()
        {
            var salt = new byte[32];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return salt;
        }
    }
}
