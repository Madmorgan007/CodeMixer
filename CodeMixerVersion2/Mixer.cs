using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeMixerVersion2
{
    public class Mixer
    {
        private static readonly byte[] _bytes = new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 };
        
        //Some Random letter to offset the begging of the security key as C# does not like numbers first
        private static readonly string[] _letters = new string[] { "A", "V", "G", "R", "Y", "P", "Q", "Z", "E", "U", "I", "W", "I", "M" };

        public static string Encoder(string text)
        {
            string password = DateTime.Now.ToShortTimeString();
            Random rand = new Random();
            int selected = rand.Next(0, 12);
            return _letters[selected] + Encrypt(text, password);
        }

        private static string Encrypt(string clearText, string password)
        {
            string code = null;
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, _bytes);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    code = Convert.ToBase64String(ms.ToArray());
                }
            }
            return code.Clean();
        }

    }
}
