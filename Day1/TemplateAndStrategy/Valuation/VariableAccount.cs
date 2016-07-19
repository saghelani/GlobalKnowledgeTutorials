using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valuation
{
    public class VariableAccount : BankAccount
    {
        protected override decimal InterestRate
        {
            get
            {
                if (Balance >= 6000)
                {
                    return 0.08M;
                }
                else if (Balance >= 1000)
                {
                    return 0.06M;
                }
                else
                {
                    return 0.05M;
                }
            }
        }

        protected override decimal TaxRate
        {
            get
            {
                return 0.25M;
            }
        }
    }
}
