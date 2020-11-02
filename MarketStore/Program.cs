using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                DiscountCard bronzeCard = new BronzeDiscountCard(0);
                bronzeCard.Output(150);
                DiscountCard silverCard = new SilverDiscountCard(600);
                silverCard.Output(850);
                DiscountCard goldCard = new GoldDiscountCard(1500);
                goldCard.Output(1300);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.ToString());
            }
        }
    }
}
