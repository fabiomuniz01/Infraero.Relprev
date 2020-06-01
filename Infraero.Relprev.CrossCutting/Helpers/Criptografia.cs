using System;
using System.Security.Cryptography;
using System.Text;

namespace Infraero.Relprev.CrossCutting.Helpers
{
    public class Criptografia
    {
        public static string Decriptar(string hexValue)
        {
            string strValue = "";
            while (hexValue.Length > 0)
            {
                strValue += Convert.ToChar(System.Convert.ToUInt32(hexValue.Substring(0, 2), 16)).ToString();
                hexValue = hexValue.Substring(2, hexValue.Length - 2);
            }
            return strValue;
        }

        public static string Encriptar(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }
        public static string EncriptarAes(string value)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(value);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static byte[] EncriptarAesService(string value)
        {
            //System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            //byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
            //byte[] hash = md5.ComputeHash(inputBytes);

            //return hash;

            //Convert value to byte array
            byte[] dataToHash = (new UnicodeEncoding().GetBytes(value));
            //Create hash value from dataToHash using MD5 instance returned by Crypto Config system
            byte[] hashvalue = (new MD5CryptoServiceProvider()).ComputeHash(dataToHash);
            //return byte array
            return hashvalue;
        }

        public static string EncriptarSha1(string value)
        {
            var rethash = "";
            try
            {
                SHA1 hash = SHA1.Create();
                var encoder = new ASCIIEncoding();
                byte[] combined = encoder.GetBytes(value);
                hash.ComputeHash(combined);
                rethash = Convert.ToBase64String(hash.Hash);
            }
            catch (Exception ex)
            {
                var strerr = $"Error no HashCode : {ex.Message}";
                return strerr;
            }

            return rethash;
        }
    }
}
