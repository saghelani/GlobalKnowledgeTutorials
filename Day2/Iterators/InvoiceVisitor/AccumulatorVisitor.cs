using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceVisitor
{
    class AccumulatorVisitor : IItemVisitor
    {
        public double Amount;

        public void VisitDiscountLineItem(DiscountLineItem discountLineItem)
        {
            Amount += (discountLineItem.Count * discountLineItem.UnitPrice);
            Amount -= (discountLineItem.Count * discountLineItem.DiscountAmount);
        }

        public void VisitLineItem(LineItem lineItem)
        {
            Amount += (lineItem.UnitPrice * lineItem.Count);
        }

        public void VisitRefundLineItem(RefundLineItem refundLineItem)
        {
            Amount -= refundLineItem.RefundAmount;
        }
    }
}
