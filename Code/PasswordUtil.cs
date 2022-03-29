using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal static class PasswordUtil
    {
        internal static string ConvertToPWHash(string PlainTextPW)
        {
            using (var provider = MD5.Create())
            {
                string salt = "dnd";
                byte[] bytes = provider.ComputeHash(Encoding.ASCII.GetBytes(salt + PlainTextPW));
                return BitConverter.ToString(bytes).Replace("-", string.Empty);
            }
        }
    }
}
