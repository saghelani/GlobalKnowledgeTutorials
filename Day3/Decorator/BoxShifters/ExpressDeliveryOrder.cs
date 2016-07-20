using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxShifters
{
    public class ExpressDeliveryOrder : OrderDecorator
    {
        private const decimal expressDeliveryCost = 4M;

        public ExpressDeliveryOrder(Order order) : base(order)
        {
        }

        public override decimal TotalCost
        {
            get
            {
                return base.TotalCost + expressDeliveryCost;
            }
        }

        public override void PrintOrderItems()
        {
            base.PrintOrderItems();
            Console.WriteLine("Express Devlivery Cost {0:C}", expressDeliveryCost);
        }
    }
}
