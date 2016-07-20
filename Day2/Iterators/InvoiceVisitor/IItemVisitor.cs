using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceVisitor
{
    public interface IItemVisitor
    {
        void VisitLineItem(LineItem lineItem);
        void VisitRefundLineItem(RefundLineItem refundLineItem);
        void VisitDiscountLineItem(DiscountLineItem discountLineItem);
    }
}
