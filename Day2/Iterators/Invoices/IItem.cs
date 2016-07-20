using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoices
{
    public interface IItem
    {
        string Description { get; set; }
        double UnitPrice { get; set; }
        int Count { get; set; }

        IEnumerable<IItem> GetItems(Predicate<IItem> filter);
    }
}
