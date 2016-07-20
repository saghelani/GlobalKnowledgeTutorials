using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices
{
    public class Invoice
    {
        private Order order;

        public Order Order
        {
            get { return order; }
            private set { order = value; }
        }

        public Invoice()
        {
        }

        public void LoadInvoice()
        {
            order = new Order();
            order.LoadOrders();
        }

        private Predicate<IItem> Filter = (o => o.UnitPrice > 20);

        private Predicate<IItem> Filter2 = delegate (IItem item)
        {
            LineItem line = item as LineItem;
            if (line == null || line.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        };

        public IEnumerable<IItem> GetItems()
        {
            // Different ways to use Predicate filter
            //return order.GetItems(o => o.UnitPrice > 20);
            //return order.GetItems(Filter2);
            return order.GetItems(Filter);
        }
    }
}
