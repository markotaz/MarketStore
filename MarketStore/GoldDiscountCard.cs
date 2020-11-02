using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldDiscountCard : DiscountCard
    {
        public GoldDiscountCard(int turnover)
        {
            PreviousMonthTurnover = turnover;
            InitialDiscountRate = 0.02;
            DiscountRate = this.CalculateDiscountRate();
        }

        public override double CalculateDiscountRate()
        {
            DiscountRate = InitialDiscountRate + (double)(PreviousMonthTurnover / 100) / 100;
            if (DiscountRate > 0.1)
                DiscountRate = 0.1;
            return DiscountRate;
            throw new NotImplementedException();
        }
    }
}
