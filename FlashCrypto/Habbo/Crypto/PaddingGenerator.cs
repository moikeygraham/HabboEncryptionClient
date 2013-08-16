using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace FlashCrypto.Habbo.Crypto
{
    public class PaddingGenerator
    {
        public int pTx = 0;
        private int seed = 0;

        public PaddingGenerator(int ptx, int seed)
        {
            this.pTx = ptx;
            this.seed = seed;
        }

        public int iterateRandom()
        {
            int newPtx = Math.Abs(19979 * this.pTx + 5) % this.seed;
            this.pTx = newPtx;

            return newPtx;
        }
    }
}
