using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConversion
{
    public class Hex : ABase
    {
        public override bool IsValidChar(char val)
        {
            return (((val >= '0') && (val <= '9')) || ((val >= 'A') && (val <= 'F')) || ((val >= 'a') && (val <= 'f')));
        }

        public override int Parse(string valueAsString)
        {
            valueAsString = valueAsString.ToUpper();

            int total = 0;
            for (int nNibble = 0; nNibble < valueAsString.Length; nNibble++)
            {
                total = total << 4;

                if (char.IsDigit(valueAsString[nNibble]))
                {
                    total += (int.Parse(valueAsString[nNibble].ToString()));
                }
                else
                {
                    total += valueAsString[nNibble] - 'A' + 10;
                }

            }

            return total;
        }

        public override string ToString(int val)
        {
            StringBuilder hexString = new StringBuilder();

            do
            {
                string digit = "";
                int nibbleValue = val & 0x0f;
                if (nibbleValue >= 10)
                {

                    digit = ((char)('A' + (char)nibbleValue - (char)10)).ToString();
                }
                else
                {
                    digit = nibbleValue.ToString();
                }

                hexString.Insert(0, digit);

                val = val >> 4;
            }
            while (val > 0);

            return hexString.ToString();
        }
    }
}
