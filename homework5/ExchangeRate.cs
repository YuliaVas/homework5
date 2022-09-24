using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class ExchangeRate
    {
        public Currencies FirstCurrency;
        public Currencies SecondCurrency;
        public float Value;
        public int CurrencyCount = 1;

        public override string ToString()
        {
            return $"{string.Format("{0:f2}", CurrencyCount)}{FirstCurrency}={string.Format("{0:f2}", Value)}{SecondCurrency}";
        }
        public ExchangeRate(Currencies FirstCurrency, Currencies SecondCurrency)
        {
            this.FirstCurrency = FirstCurrency;
            this.SecondCurrency = SecondCurrency;

        }

        public ExchangeRate(Currencies FirstCurrency, Currencies SecondCurrency, float Value) : this(FirstCurrency, SecondCurrency)
        {
            this.Value = Value;
        }

        public void SetValue(float value)
        {
            Value = value;
        }

        public void SetCount(int count)
        {
            CurrencyCount = count;
        }
    }
}
