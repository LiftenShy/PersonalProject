

using System;
using System.Security.Cryptography;
using System.Text;

namespace Person_Project.Authorize_Service.Helper
{
    internal class CryptoService
    {
        public static byte[] Crypto(string password)
        {
            try
            {
                if (!string.IsNullOrEmpty(password))
                {
                    using (SHA256 sha256 = new SHA256CryptoServiceProvider())
                    {
                        return sha256.ComputeHash(Encoding.ASCII.GetBytes(password));
                    }
                }
                throw new ArgumentException();
            }
            catch (EncoderFallbackException encoderException)
            {
                throw encoderException;
            }
        }
    }
}
