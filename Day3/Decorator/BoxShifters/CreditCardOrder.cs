using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxShifters
{
    public enum CardType
    {
        Visa,
        AmericanExpress
    }

    public class CreditCardOrder : OrderDecorator
    {
        private const decimal visaSurcharge = 2M;
        private const decimal amexSurcharge = 10M;

        private readonly CardType cardType;
        private Dictionary<CardType, decimal> cardSurchargeDictionary = new Dictionary<CardType, decimal>();

        public CreditCardOrder(Order order, CardType cardType) : base(order)
        {
            this.cardType = cardType;
            cardSurchargeDictionary.Add(CardType.Visa, visaSurcharge);
            cardSurchargeDictionary.Add(CardType.AmericanExpress, amexSurcharge);
        }

        public override decimal TotalCost
        {
            get
            {
                return base.TotalCost + cardSurchargeDictionary[cardType];
            }
        }

        public override void PrintOrderItems()
        {
            base.PrintOrderItems();
            Console.WriteLine("Credit Card Surcharge {0:C}", cardSurchargeDictionary[cardType]);
        }
    }
}
