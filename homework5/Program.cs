// See https://aka.ms/new-console-template for more information

using homework5;
using System;

CurrencyConverter currencyConverter = new CurrencyConverter();
Random random = new Random();
int[,] numbers = new int[10, 3];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    numbers[i, 2] = random.Next(50, 150);

    do
    {
        numbers[i, 0] = random.Next(0, numbers.GetLength(0));
        numbers[i, 1] = random.Next(0, numbers.GetLength(0));
    }
    while ((numbers[i, 0] == numbers[i, 1]) || (!(currencyConverter.FindExchangeRate((Currencies)numbers[i, 0], (Currencies)numbers[i, 1]) == null)));

    ExchangeRate ex = new((Currencies)numbers[i, 0], (Currencies)numbers[i, 1], (float)numbers[i, 2] / 100);
    currencyConverter.AddExchangeRate(ex);
}
    Console.WriteLine("Валютный калькулятор. Курс на данный момент:");
    Console.WriteLine(currencyConverter);

    while(true)
    {
        Console.WriteLine("Введите валюту для перевода:");
        string ourCurrency = Console.ReadLine();
        Console.WriteLine("Введите валюту, в которую необходимо перевести:");
        string needCurrency=Console.ReadLine();
        Console.WriteLine("Введите сумму для перевода");
        int howMoney= Convert.ToInt32(Console.ReadLine());

        Currencies value1;
        Currencies value2;
        if(Enum.TryParse(ourCurrency, out value1)&& Enum.TryParse(needCurrency, out value2))
        {
            if (currencyConverter.Convert(value1, value2, howMoney) == null)
            { Console.WriteLine("Неверная операция");
                break;
            }
            else
            {
                Console.WriteLine(currencyConverter.Convert(value1, value2, howMoney));
                break;
            }
        }

    }


