using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConversion
{
    public class Oct : ABase
    {
        public override bool IsValidChar(char val)
        {
            return ((val >= '0') && (val <= '7'));
        }

        public override int Parse(string valueAsString)
        {
            int total = 0;
            for (int nOctet = 0; nOctet < valueAsString.Length; nOctet++)
            {
                total = total << 3;

                total += (int.Parse(valueAsString[nOctet].ToString()));
            }

            return total;
        }

        public override string ToString(int val)
        {
            StringBuilder octString = new StringBuilder();

            do
            {
                string digit = "";
                int octetValue = val & 0x07;

                octString.Insert(0, octetValue.ToString());

                val = val >> 3;
            }
            while (val > 0);

            return octString.ToString();
        }
    }
}
