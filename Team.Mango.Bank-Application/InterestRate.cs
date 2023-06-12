using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class InterestRate
    {
        public double _InterestRate { get; set; }

        public InterestRate(double interestRate)
        {
            _InterestRate = interestRate;
        }
        public static double IntRateMultiply()
        {
            double intRateMin = 0.1;
            Random R = new Random();
            double newInterestRate = R.NextDouble();
            double interestRate = intRateMin * newInterestRate;

            Console.WriteLine("Current interest rate is {0} at the Mango Bank Inc", Math.Round(interestRate, 2));
            return interestRate;


        }

    }
}
