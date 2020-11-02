using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    abstract class DiscountCard
    {
        public String OwnerFullName { get; set; }

        public int PreviousMonthTurnover { get; set; }

        public Double InitialDiscountRate { get; set; }

        public Double DiscountRate { get; set; }

        public abstract Double CalculateDiscountRate();

        public Double CalculateDiscount(int valueOfPurchase)
        {
            return valueOfPurchase * DiscountRate;
        }
        public Double CalculateTotal(int valueOfPurchase)
        {
            return valueOfPurchase - CalculateDiscount(valueOfPurchase);
        }

        public void Output(int valueOfPurchase)
        {
            Console.WriteLine("Purchase value: $" + valueOfPurchase);
            Console.WriteLine("Discount rate: " + Math.Round(DiscountRate * 100, 2) + "%");
            Console.WriteLine("Discount: $" + Math.Round(this.CalculateDiscount(valueOfPurchase), 2));
            Console.WriteLine("Total: $" + this.CalculateTotal(valueOfPurchase));
            Console.WriteLine();
        }
    }
}
