using System;
using System.Collections.Generic;
using System.Text;

namespace Valuation
{
    
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savings = new ClassicAccount();
            BankAccount taxFreeSavings = new TaxFreeAccount();
            BankAccount variableSavings = new VariableAccount();

            PrintAccountForecasts(savings, taxFreeSavings, variableSavings);
        }

        public static void PrintAccountForecasts(params BankAccount[] accounts)
        {
            foreach (BankAccount account in accounts)
            {
                account.Deposit(5000);
            }

            for (int nYear = 1; nYear <= 10; nYear++)
            {

                Console.Write(nYear);
                foreach (BankAccount account in accounts)
                {
                    account.PayYearlyInterest();
                    Console.WriteLine(",{0:C}" , account.Balance );
                }
            }
        }
    }
}
