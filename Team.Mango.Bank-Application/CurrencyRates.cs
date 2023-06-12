using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class CurrencyRates
    {
        public string _currencyType;
        public double _currencyRate;

        public CurrencyRates(string currentcyType, double currentcyRate)
        {
            this._currencyType = currentcyType;
            this._currencyRate = currentcyRate;

        }


        public static void UpdateCurrentcyRate(CurrencyRates CurrRate)
        {
            Console.Clear();
            double minValue = 9.5;
            Random R = new Random();
            double newRate = R.NextDouble();
            CurrRate._currencyRate = newRate + minValue;

            string currUp = "New USD rate is  ";
            string goback = "Press enter to go back";
            Console.SetCursorPosition((Console.WindowWidth - currUp.Length) / 2, Console.CursorTop);
            Console.WriteLine(currUp + Math.Round(CurrRate._currencyRate, 2));
            Console.SetCursorPosition((Console.WindowWidth - goback.Length) / 2, Console.CursorTop);
            Console.WriteLine(goback);

            Console.ReadKey();

        }


    }
}
