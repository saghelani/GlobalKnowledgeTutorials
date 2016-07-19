using System;
using System.Collections.Generic;
using System.Text;

namespace StockReport
{
    class Program
    {
        static void Main(string[] args)
        {
            StockMarket tradingDays = new StockMarket(@"..\..\stockData.csv");

            Console.WriteLine("High Swings");
            PrintReport(tradingDays, ReportOnHighSwings);

            //Requires curly braces as more than one line of code
            //PrintReport(tradingDays, tradingDay =>
            //{
            //    double swing = tradingDay.Open - tradingDay.Close;

            //    double percentageSwing = Math.Abs(swing / tradingDay.Open);

            //    return percentageSwing > 0.1;

            //});

            Console.WriteLine("High Volume");
            //PrintReport(tradingDays, ReportOnHighSwings)
            PrintReport(tradingDays, tradingDay => tradingDay.Volume > 20000000D);
        }

        // Old way using delegate
        //private static void PrintReport(StockMarket tradingDays, ReportDelegate reportOnTradingDay)
        private static void PrintReport(StockMarket tradingDays, Func<TradingDay, bool> reportOnTradingDay)
        {
            foreach (TradingDay day in tradingDays.GetTradingDays())
            {
                if (reportOnTradingDay(day))
                {
                    Console.WriteLine(day.ToString());
                }
            }
        }

        private static bool ReportOnHighSwings(TradingDay tradingDay)
        {
            double swing = tradingDay.Open - tradingDay.Close;

            double percentageSwing = Math.Abs(swing / tradingDay.Open);

            return percentageSwing > 0.1;
        }

        private static bool ReportOnHighVolume(TradingDay tradingDay)
        {
            return tradingDay.Volume > 20000000D;
        }
    }

    //Old way to do this - use func instead as shown above
    //public delegate bool ReportDelegate(TradingDay tradingDay);
}
