using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace FlashCrypto.Habbo.Crypto
{
    public class HabboRC4
    {
        private int[] table;
        private int[] key;

        private int j;
        private int q;

        private string pTableStr;
        private Dictionary<int, int> pTableList;

        private const string PREMIX_STRING = "NV6VVFPoC7FLDlzDUri3qcOAg9cRoFOmsYR9ffDGy5P8HfF6eekX40SFSVfJ1mDb3lcpYRqdg28sp61eHkPukKbqTu1JsVEKiRavi04YtSzUsLXaYSa5BEGwg5G2OF";
        private const int PREMIX_COUNT = 52;

        public HabboRC4(byte[] tSharedKey)
        {
            // Initialize int[] arrays
            this.key = new int[256];
            this.table = new int[256];

            // These are vars specifically for Base64 UTF-7 encoding/decoding
            this.pTableList = new Dictionary<int, int>();
            this.pTableStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

            // Setup the Base64 UTF-7 table for decipher
            for (int i = 0; i < this.pTableStr.Length; i++)
            {
                char tXor = char.Parse(this.pTableStr.Substring(i, 1));
                this.pTableList.Add((int)tXor, i);
            }

            // Reset vars just incase
            this.j = 0;
            this.q = 0;

            // Setup the encryption tables
            this.init(tSharedKey);

            // Mix up the tables
            this.premixTable(PREMIX_STRING, PREMIX_COUNT);
        }

        private void init(byte[] tKey)
        {
            // Ints used to xor against the key passed (in hexadecimal format)
            int[] tXorVals = new int[] { 
                0x6d, 0x57, 120, 70, 0x52, 0x4a, 110, 0x47, 0x4a, 0x35, 0x54, 0x39, 0x53, 0x69, 0x30, 0x4f, 
                0x4d, 0x56, 0x76, 0x45, 0x42, 0x42, 0x6d, 0x38, 0x6c, 0x61, 0x69, 0x68, 0x58, 0x6b, 0x4e, 0x38, 
                0x47, 0x6d, 0x48, 0x36, 0x66, 0x75, 0x76, 0x37, 0x6c, 100, 90, 0x68, 0x4c, 0x79, 0x47, 0x52, 
                0x52, 0x4b, 0x43, 0x63, 0x47, 0x7a, 0x7a, 0x69, 80, 0x59, 0x42, 0x61, 0x4a, 0x6f, 0x6d
                };

            // Initialize our list.
            List<int> tModKey = new List<int>();

            int k;
            int tVal;
            int l = 1;

            for (k = 1; k <= tKey.Count(); k++)
            {
                // Our XOR result against a XorVal and a int grabbed from key array
                tVal = (tKey[k - 1] ^ tXorVals[l - 1]);

                // Add it to our list
                tModKey.Add(tVal);

                // Iterate 
                l = (l + 1);

                if (l > tXorVals.Count())
                {
                    // We reached the end of the XOR Val array
                    l = 1;
                }
            }

            for (this.q = 0; this.q < 256; this.q++)
            {
                // Here we setup the key table - which is initially designed to iterate q (as well as
                // being used later to calculate j)
                key[q] = tModKey[((this.q % tModKey.Count()))];
                table[q] = q;
            }

            // Reset j just to be safe
            this.j = 0;

            for (this.q = 0; this.q < 256; q++)
            {
                // Calculate j based on both the table and key arrays - and q's current state.
                this.j = (((this.j + table[q]) + key[q]) % 256);

                // Store this for swapping
                k = table[q];

                // Perform the swap with q > j
                table[q] = table[j];
                // and perform the swap from j > q
                table[j] = k;
            }

            // We'll reset the vars again just to be safe
            this.q = 0;
            this.j = 0;
            k = 0;
        }

        private void swap()
        {
            int tmp = this.table[this.q];

            this.table[q] = this.table[j];
            this.table[j] = tmp;
        }

        public void debug()
        {
            for (int i = 0; i < table.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine("table[" + i.ToString() + "] = " + table[i].ToString());
            }
        }

        public void premixTable(string dataIn, int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.encipher(dataIn);
            }
        }

        public string decipher(string data)
        {
            // Why re-invent the wheel when you have old functions that handles Base64 for you? :-)!
            // (sulake, you'll be kicking yourself :-))
            StringBuilder tCipher = new StringBuilder();
            int a = 1;

            while (a < (data.Length))
            {
                List<int> tDataIn = new List<int>();

                int tNum1 = (this.pTableList[(int)data[a - 1]]);
                int tNum2 = (this.pTableList[(int)data[a]]);

                int tNum3 = 0;
                int tNum4 = 0;

                if (tNum2 < 0) { tNum2 = 0; }

                int tByte1a = (tNum1 * 4);
                int tByte1b = ((tNum2 & 48) / 16);
                int tByte1 = (tByte1a | tByte1b);

                tDataIn.Add(tByte1);

                if ((data.Length - 1) > a)
                {
                    tNum3 = (this.pTableList[(int)data[(a + 1)]]);
                    if (tNum3 < 0) { tNum3 = 0; }

                    int tByte2a = ((tNum2 & 15) * 16);
                    int tByte2b = ((tNum3 & 60) / 4);
                    int tByte2 = (tByte2a | tByte2b);

                    tDataIn.Add(tByte2);
                }

                if ((data.Length - 1) > (a + 1))
                {
                    tNum4 = (this.pTableList[(int)data[a + 2]]);
                    if (tNum4 < 0) { tNum4 = 0; }

                    int tByte3a = ((tNum3 & 3) * 64);
                    int tByte3b = (tNum4 & 63);
                    int tByte3 = (tByte3a | tByte3b);

                    tDataIn.Add(tByte3);
                }

                a = (a + 4);

                for (int k = 0; k < tDataIn.Count; k++)
                {
                    q = ((q + 1) % 256);
                    j = ((j + this.table[q]) % 256);

                    int temp = this.table[q];

                    this.table[q] = this.table[j];
                    this.table[j] = temp;

                    if ((q & 63) == 63)
                    {
                        int swap1 = (q + 67) * 297 & 255;
                        int swap2 = j + table[swap1] & 255;
                        int tmp = table[swap1];

                        table[swap1] = table[swap2];
                        table[swap2] = tmp;
                    }

                    int d = this.table[(this.table[this.q] + this.table[this.j]) % 256];

                    tCipher.Append((char)(tDataIn[k] ^ d));
                }
            }

            return tCipher.ToString();
        }

        public string encipher(string data)
        {
            // Why re-invent the wheel when you have old functions that handles Base64 for you? :-)!
            // :-D
            List<int> tBytes = new List<int>();
            int a;

            for (int e = 0; e < data.Length; e++)
            {
                // We can cast a char as an int ;-)
                //a = char.Parse(data[e].ToString());
                a = (int)data[e];

                if (a > 255)
                {
                    tBytes.Add(((a - (a % 256)) / 256));

                    if (a % 256 == 1)
                    {
                        // if remainder of a divided by 256 = true (1)
                        tBytes.Add((a % 256));
                    }
                }
                else
                {
                    tBytes.Add(a);
                }
            }

            List<int> tDataOut = new List<int>();

            for (a = 0; a < tBytes.Count; a++)
            {
                // Calculate q and j 
                this.q = ((q + 1) % 256);
                this.j = ((j + this.table[q]) % 256);

                // Store q pos in the table for swapping later
                int temp = this.table[q];

                // Preform the table swap
                table[q] = table[j];
                table[j] = temp;

                if ((q & 63) == 63)
                {
                    // Scramblehack
                    int swap1 = (q + 67) * 297 & 255;
                    int swap2 = j + table[swap1] & 255;
                    int tmp = table[swap1];

                    table[swap1] = table[swap2];
                    table[swap2] = tmp;
                }

                int d = this.table[(this.table[this.q] + this.table[this.j]) % 256];

                int tResult = tBytes[a] ^ d;
                tDataOut.Add(tResult);
            }

            StringBuilder tCipher = new StringBuilder();

            a = 1;

            while (a < tDataOut.Count + 1)
            {
                int tNum1 = tDataOut[a - 1];
                int tNum2;
                int tNum3;

                if (tDataOut.Count > a) { tNum2 = tDataOut[a]; } else { tNum2 = 0; }
                if (tDataOut.Count > (a + 1)) { tNum3 = tDataOut[a + 1]; } else { tNum3 = 0; }

                int tByte1 = ((tNum1 & 252) / 4);

                int tByte2a = ((tNum1 & 3) * 16);
                int tByte2b = ((tNum2 & 240) / 16);
                int tByte2 = (tByte2a | tByte2b);

                tCipher.Append(this.pTableStr[tByte1]);
                tCipher.Append(this.pTableStr[tByte2]);

                if (tDataOut.Count > a)
                {
                    int tByte3a = ((tNum2 & 15) * 4);
                    int tByte3b = ((tNum3 & 192) / 64);
                    int tByte3 = (tByte3a | tByte3b);

                    tCipher.Append(this.pTableStr[tByte3]);
                }

                if (tDataOut.Count > a + 1)
                {
                    int tByte4 = (tNum3 & 63);

                    tCipher.Append(this.pTableStr[tByte4]);
                }

                a = (a + 3);
            }

            return tCipher.ToString();
        }
    }
}
