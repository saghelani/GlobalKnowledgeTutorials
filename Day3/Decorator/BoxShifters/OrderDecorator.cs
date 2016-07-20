using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxShifters
{
    public abstract class OrderDecorator : Order
    {
        protected Order order;

        public OrderDecorator(Order order)
        {
            this.order = order;
        }

        public override IEnumerable<OrderItem> Items
        {
            get
            {
                if (order != null)
                {
                    return order.Items;
                }

                return Enumerable.Empty<OrderItem>();
            }
        }

        public override decimal TotalCost
        {
            get
            {
                if (order != null)
                {
                    return order.TotalCost;
                }

                return 0;
            }
        }

        public override void PrintOrderItems()
        {
            if (order != null)
            {
                order.PrintOrderItems();
            }
        }

        public override void AddItem(string productCode, int quantity, decimal cost, decimal weight)
        {
            if (order != null)
            {
                order.AddItem(productCode, quantity, cost, weight);
            }
        }
    }
}
