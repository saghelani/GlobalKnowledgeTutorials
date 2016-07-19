using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valuation
{
    public class TaxFreeAccount : BankAccount
    {
        protected override decimal InterestRate
        {
            get
            {
                return 0.06M;
            }
        }

        protected override decimal TaxRate
        {
            get
            {
                return 0.00M;
            }
        }
    }
}
