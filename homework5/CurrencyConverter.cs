using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class CurrencyConverter
    {
       public List<ExchangeRate> ExchangeRates;
         
        public CurrencyConverter()
        {
            ExchangeRates = new List <ExchangeRate>();
        }

        public void AddExchangeRate(ExchangeRate exchangeRate)
        {
            ExchangeRates.Add(exchangeRate);
        }

        public void AddExchangeRates(ExchangeRate[] exchangeRates)
        {
            ExchangeRates.AddRange(exchangeRates);
        }

        public void TryDeleteExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            if (FindExchangeRate(firstCurrency, secondCurrency) != null)
            { 
                ExchangeRates.Remove(FindExchangeRate(firstCurrency, secondCurrency));
            
            }

        }

        public ExchangeRate FindExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            foreach (ExchangeRate exchangeRate in ExchangeRates)
            {
                if ((exchangeRate.FirstCurrency == firstCurrency && exchangeRate.SecondCurrency == secondCurrency) || (exchangeRate.FirstCurrency == secondCurrency && exchangeRate.FirstCurrency == firstCurrency))
                { return exchangeRate; }

            }    
                return null;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ExchangeRate exchangeRate in ExchangeRates)
            {
                sb.Append(exchangeRate);
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public ExchangeRate Convert (Currencies firstCurrency, Currencies secondCurrency, int count)
        {
            ExchangeRate ExchangeFind = FindExchangeRate(firstCurrency, secondCurrency);


            if (ExchangeFind != null)
            { 
                var result=(count * ExchangeFind.Value) / ExchangeFind.CurrencyCount;
                ExchangeFind.SetCount(count);
                ExchangeFind.SetValue(result);
            }
            return ExchangeFind;
            
        }
    }
}
