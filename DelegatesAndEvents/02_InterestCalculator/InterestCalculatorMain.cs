using System;

namespace _02_InterestCalculator
{
    class InterestCalculatorMain
    {
        public const int DefaultN = 12;

        public static decimal GetSimpleInterest(decimal sum, decimal rate, int years)
        {
            decimal balance = sum*(1 + rate*years/100);
            return balance;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal rate, int years)
        {
            double power = years*DefaultN;
            decimal toBePowered = 1 + (rate/DefaultN)/100;
            decimal powered = (decimal) Math.Pow((double) toBePowered, power);
            decimal balance = sum*powered;
            return balance;
        }

        public static void Main()
        {
            CalculateInterest delSimple = GetSimpleInterest;
            InterestCalculator simple = new InterestCalculator(2500m, 7.2m, 15, delSimple);
            Console.WriteLine(simple);

            CalculateInterest delCompound = new CalculateInterest(GetCompoundInterest);
            InterestCalculator compound = new InterestCalculator(500, 5.6m, 10, delCompound);
            Console.WriteLine(compound);

            Console.WriteLine(compound.Rate);
        }
    }
}
