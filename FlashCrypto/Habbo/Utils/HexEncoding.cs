using System;
using System.Text;

namespace FlashCrypto.Habbo.Utils
{
    public class HexEncoding
    {
        public HexEncoding()
        {

        }

        public static int GetByteCount(string hexString)
        {
            int numHexChars = 0;
            char c;

            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];

                if (IsHexDigit(c))
                    numHexChars++;
            }

            // if odd number of characters, discard last character
            if (numHexChars % 2 != 0)
            {
                numHexChars--;
            }

            return numHexChars / 2; // 2 characters per byte
        }

        public static byte[] GetBytes(string hexString)
        {
            string newString = "";
            char c;

            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];

                if (IsHexDigit(c))
                    newString += c;
            }

            // if odd number of characters, discard last character
            if (newString.Length % 2 != 0)
            {
                newString = newString.Substring(0, newString.Length - 1);
            }

            int byteLength = newString.Length / 2;

            byte[] bytes = new byte[byteLength];

            string hex;
            int j = 0;

            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { newString[j], newString[j + 1] });

                bytes[i] = HexToByte(hex);
                j = j + 2;
            }

            return bytes;
        }

        public static string ToString(byte[] bytes)
        {
            string hexString = "";

            for (int i = 0; i < bytes.Length; i++)
            {
                hexString += bytes[i].ToString("X2");
            }

            return hexString;
        }

        public static bool InHexFormat(string hexString)
        {
            bool hexFormat = true;

            foreach (char digit in hexString)
            {
                if (!IsHexDigit(digit))
                {
                    hexFormat = false;
                    break;
                }
            }

            return hexFormat;
        }

        public static bool IsHexDigit(Char c)
        {
            int numChar;
            int numA = Convert.ToInt32('A');
            int num1 = Convert.ToInt32('0');

            c = Char.ToUpper(c);
            numChar = Convert.ToInt32(c);

            if (numChar >= numA && numChar < (numA + 6))
                return true;

            if (numChar >= num1 && numChar < (num1 + 10))
                return true;

            return false;
        }

        private static byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");

            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);

            return newByte;
        }
    }
}