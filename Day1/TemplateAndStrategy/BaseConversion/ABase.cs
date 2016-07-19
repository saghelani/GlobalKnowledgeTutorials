using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConversion
{
    public abstract class ABase
    {
        public abstract bool IsValidChar(char val);
        public abstract int Parse(string vavalueAsStringl);
        public abstract string ToString(int val);        
    }
}
