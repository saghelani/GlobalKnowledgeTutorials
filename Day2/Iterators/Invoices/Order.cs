using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Invoices
{
    public class Order : IItem
    {
        List<IItem> items = new List<IItem>();

        const string LINE_ITEM_IDENTIFIER = "L";
        const string ORDER_START_IDENTIFIER = "OS";
        const string ORDER_END_IDENTIFIER = "OE";

        private List<IItem> Items
        {
            get { return items; }
        }

        private string title = "Base Order";

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description { get; set; }

        public double UnitPrice { get; set; }

        public int Count { get; set; }

        public IEnumerable<IItem> GetItems(Predicate<IItem> filter)
        {
            if (filter == null || filter(this))
            {
                yield return this; 
            }
            
            foreach (IItem item in Items)
            {
                foreach (IItem childItem in item.GetItems(filter))
                {
                    if (filter == null || filter(childItem))
                    {
                        yield return childItem; 
                    }
                }
            }
        }

        public void LoadOrders()
        {
            using (StreamReader reader = new StreamReader(@"..\..\invoices.csv"))
            {
                string lineRead;
                while ((lineRead = reader.ReadLine()) != null)
                {
                    ProcessLine(reader, lineRead);
                }
            }
        }

        private void ProcessLine(StreamReader reader, string lineRead)
        {
            string[] lineItemSplit = lineRead.Split(new char[] { ',' });
            if (lineItemSplit[0] == LINE_ITEM_IDENTIFIER)
            {
                ProcessLineItem(lineItemSplit);
            }
            else if (lineItemSplit[0] == ORDER_START_IDENTIFIER)
            {
                ProcessOrder(reader, lineItemSplit[1]);
            }
        }

        private void ProcessOrder(StreamReader reader, string title)
        {
            Order order = new Order();
            order.Title = title;
            string lineRead;
            while ((lineRead = reader.ReadLine()) != null)
            {
                string[] lineItemSplit = lineRead.Split(new char[] { ',' });
                if (lineItemSplit[0] == ORDER_END_IDENTIFIER)
                    break;

                order.ProcessLine(reader, lineRead);
            }
            Items.Add(order);
        }

        private void ProcessLineItem(string[] parsedLine)
        {
            LineItem li = new LineItem();
            li.Count = int.Parse(parsedLine[1]);
            li.Description = parsedLine[2];
            li.UnitPrice = double.Parse(parsedLine[3]);
            Items.Add(li);
        }

        public override string ToString()
        {
            return this.Title;
        }

    }
}
