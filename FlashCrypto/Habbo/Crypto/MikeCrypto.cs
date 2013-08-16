using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace FlashCrypto.Habbo.Crypto
{
    public class MikeCrypto
    {
        private HabboRC4 rc4Header;
        private HabboRC4 rc4Body;

        public PaddingGenerator pTx;
        public PaddingGenerator tRx;

        public MikeCrypto(byte[] tKey, PaddingGenerator pad)
        {
            this.pTx = pad;
            this.tRx = pad;

            this.rc4Body = new HabboRC4(tKey);
            this.rc4Header = new HabboRC4(tKey);
        }

        public string encipher(string data)
        {
            string header = "";
            string body = "";
            string result = null;

            int randSeed = this.pTx.iterateRandom() % 5;
            int dataLen = data.Length - 3;
            int totalSize = randSeed + dataLen;
            int encodedSize = getEncodedSize(totalSize);

            header += 'A';  // This is just a rand char (usually Math.Floor(rand * 255)) - but 'A' will do
            header += (char)(64 | encodedSize >> 12 & 63);
            header += (char)(64 | encodedSize >> 6 & 63);
            header += (char)(64 | 63 & encodedSize);

            header = this.rc4Header.encipher(header);

            while (body.Length < randSeed)
            {
                body += 'A';    // same goes here for rand char (Math.floor(rand * 255))
            }

            body += data.Substring(3);

            body = this.rc4Body.encipher(body);

            result = header + body;
            return result;
        }

        public string decipherHeader(string data)
        {
            if (data.Length > 6) { return null; }

            return this.rc4Header.decipher(data).Substring(1);  // substr(1) because first char is a rand char and not needed (padding)
        }

        public string decipherBody(string data)
        {
            string body = null;
            string result = null;

            body = this.rc4Body.decipher(data);

            result = this.unpad(body, this.pTx.iterateRandom() % 5);

            return result;
        }

        private string unpad(string tMsg, int tPad)
        {
            if (tMsg.Trim() == String.Empty) { return ""; }

            try
            {
                string tmpMsg = tMsg.Substring(tPad, tMsg.Length - tPad);

                return tmpMsg;
            }
            catch (Exception)
            {
                // Padding must'a messed up... Means crypto also fails. Rarely happens.
                MessageBox.Show("Crypto failed. Please re-start and try again.", "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            return null;
        }

        public static int getEncodedSize(int chara)
		{
			int mod = chara % 3;
			
			switch (mod)
			{
				case 0:
					return chara / 3 * 4;
					
				case 1:
					return (chara - 1) / 3 * 4 + 2;
					
				case 2:
					return (chara - 2) / 3 * 4 + 3;
					
				default:
					break;
			}
			
			return 0;
		}
    }
}
