using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class SilverDiscountCard : DiscountCard
    {
        public SilverDiscountCard(int turnover)
        {
            PreviousMonthTurnover = turnover;
            InitialDiscountRate = 0.02;
            DiscountRate = this.CalculateDiscountRate();
        }
        public override double CalculateDiscountRate()
        {
            return (PreviousMonthTurnover > 300)? 0.035 : InitialDiscountRate;
            throw new NotImplementedException();
        }
    }
}
