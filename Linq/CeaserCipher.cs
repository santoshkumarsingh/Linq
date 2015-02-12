using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class CeaserCipher
    {
        public static string Encrypt(string plainText, int key)
        {
            return new string(plainText.ToCharArray().Select(x => Char.IsWhiteSpace(x) ? x : (char)(x + key)).ToArray());

        }
        public static string Decrypt(string plainText, int key)
        {
            return new string(plainText.ToCharArray().Select(x => Char.IsWhiteSpace(x) ? x : (char)(x - key)).ToArray());

        }
    }
}
