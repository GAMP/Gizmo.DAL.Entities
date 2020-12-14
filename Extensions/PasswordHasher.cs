using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GizmoDALV2
{
    /// <summary>
    /// Generic password hasher.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// Implements default method to be used by SaltGenerator delegate
        /// </summary>
        /// <returns>String value that can be used as salt.</returns>
        public static byte[] GetNewSalt()
        {
            byte[] salt = new byte[100];
            RNGCryptoServiceProvider.Create().GetNonZeroBytes(salt);
            return salt;
        }

        /// <summary>
        /// Gets hashed password.
        /// </summary>
        /// <param name="pwd">Password input string.</param>
        /// <param name="salt">Password salt.</param>
        /// <returns>Hashed password byte array.</returns>
        public static byte[] GetHashedPassword(string pwd, byte[] salt)
        {
            #region VALIDATION
            if (string.IsNullOrWhiteSpace(pwd))
                throw new ArgumentNullException(nameof(pwd), "Password may not be null or empty");

            if (salt == null)
                throw new ArgumentException("Invalid salt specified", nameof(salt));
            #endregion

            List<byte> bytes = new List<byte>(System.Text.Encoding.Default.GetBytes(pwd));
            bytes.AddRange(salt);
            using (SHA512 hasher = SHA512Managed.Create())
            {
                return hasher.ComputeHash(bytes.ToArray());
            }
        }
    }
}
