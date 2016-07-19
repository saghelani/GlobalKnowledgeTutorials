using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConversion
{
    public class Dec : ABase
    {
        public override bool IsValidChar(char val)
        {
            return ((val >= '0') && (val <= '9'));
        }

        public override int Parse(string valueAsString)
        {
            return int.Parse(valueAsString);
        }

        public override string ToString(int val)
        {
            return val.ToString();
        }
    }
}
