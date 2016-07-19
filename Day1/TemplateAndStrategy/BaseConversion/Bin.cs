using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConversion
{
    public class Bin : ABase
    {
        public override bool IsValidChar(char val)
        {
            return ((val == '0') || (val == '1'));
        }

        public override int Parse(string valueAsString)
        {
            int total = 0;

            for (int nBit = 0; nBit < valueAsString.Length; nBit++)
            {
                total = total << 1;

                total += (int.Parse(valueAsString[nBit].ToString()));
            }

            return total;
        }

        public override string ToString(int val)
        {
            StringBuilder binaryString = new StringBuilder();

            do
            {
                binaryString.Insert(0, (val & 1).ToString());

                val = val >> 1;

            }
            while (val > 0);

            return binaryString.ToString();
        }
    }
}
