using System;
using System.Security.Cryptography.X509Certificates;
namespace CsharpProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // USD
            CurrencyUSD usd1 = new CurrencyUSD(1);

            CurrencyEUR eur1 = (CurrencyEUR)usd1;
            Console.WriteLine($"USD {usd1.Value} преобразован в EUR: {eur1.Value}");

            CurrencyRUB rub1 =(CurrencyRUB)usd1;
            Console.WriteLine($"USD {usd1.Value} преобразован в RUB: {rub1.Value}");
            // EUR
            CurrencyEUR eur2 = new CurrencyEUR(1);

            CurrencyUSD usd2 = (CurrencyUSD)eur2;
            Console.WriteLine($"EUR {eur2.Value} преобразован в USD: {usd2.Value}");

            CurrencyRUB rub2=(CurrencyRUB)eur2;
            Console.WriteLine($"EUR {eur2.Value} преобразован в RUB: {rub2.Value}");
            //RUB
            CurrencyRUB rub3 = new CurrencyRUB(1);

            CurrencyUSD usd3=(CurrencyUSD)rub3;
            Console.WriteLine($"RUB {rub3.Value} преобразован в USD: {usd3.Value}");

            CurrencyEUR eur3=(CurrencyEUR)rub3;
            Console.WriteLine($"RUB {rub3.Value} преобразован в EUR: {eur3.Value}");
        }



    }


    public class Currency
    {
        public double Value { get; set; }

        public Currency(double value) {
            this.Value = value;
        }

    }

    public class CurrencyUSD : Currency
    {
       public CurrencyUSD(double Value) : base(Value) { }


        public static explicit operator CurrencyEUR(CurrencyUSD currencyUSD) {
            double result = 0.9 *currencyUSD.Value;
            CurrencyEUR obj = new(result);
            return obj;
        }

        public static explicit operator CurrencyRUB(CurrencyUSD currencyUSD)
        {
            double result =  currencyUSD.Value*90;
            CurrencyRUB obj = new(result);
            return obj;
        }




    }



    public class CurrencyEUR : Currency
    {
        public CurrencyEUR(double Value) : base(Value) { }

        public static explicit operator CurrencyUSD(CurrencyEUR currencyEUR)
        {
            double result =  currencyEUR.Value/0.9;
            CurrencyUSD obj = new(result);
            return obj;
        }

        public static explicit operator CurrencyRUB(CurrencyEUR currencyEUR)
        {
            double result = currencyEUR.Value *100;
            CurrencyRUB obj = new(result);
            return obj;
        }

    }
    public class CurrencyRUB : Currency
    {
        public CurrencyRUB(double Value) : base(Value) { }

        public static explicit operator CurrencyUSD(CurrencyRUB currencyRUB) {
            double result = currencyRUB.Value / 90;
            CurrencyUSD obj = new(result);
            return obj;
        }
        public static explicit operator CurrencyEUR(CurrencyRUB currencyRUB) {
            double result = currencyRUB.Value / 100;
            CurrencyEUR obj =new(result);
            return obj;
        }




    }



}
