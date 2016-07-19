using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockReport
{
    public class HighSwingsReport : IReport
    {
        public bool ReportOnTradingDay(TradingDay tradingDay)
        {
            double swing = tradingDay.Open - tradingDay.Close;

            double percentageSwing = Math.Abs(swing / tradingDay.Open);

            return percentageSwing > 0.1;
        }
    }
}
