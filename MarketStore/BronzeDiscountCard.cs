using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class BronzeDiscountCard : DiscountCard
    {
        public BronzeDiscountCard(int turnover)
        {
            PreviousMonthTurnover = turnover;
            InitialDiscountRate = 0;
            DiscountRate = this.CalculateDiscountRate();
        }
        public override Double CalculateDiscountRate()
        {
            if (PreviousMonthTurnover < 100) return InitialDiscountRate;
            else if (PreviousMonthTurnover >= 100 && PreviousMonthTurnover <= 300) return 0.01;
            else return 0.025;
            throw new NotImplementedException();
        }

    }
}
