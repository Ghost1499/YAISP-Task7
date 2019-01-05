using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BalanceOfPower : IIndicator
    {
        public BalanceOfPower()
        { }

        public decimal Calculate(Candle candle) => (candle.Close - candle.Open) / (candle.High - candle.Low) * 100;
    }
}
