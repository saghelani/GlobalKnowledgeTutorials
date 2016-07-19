using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockReport
{
    public interface IReport
    {
        bool ReportOnTradingDay(TradingDay tradingDay);
    }
}
