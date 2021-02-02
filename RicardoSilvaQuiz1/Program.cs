using System;

namespace RicardoSilvaQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the total charges for the food purchases:");
            Double vTotal = Double.Parse(Console.ReadLine());
            Console.WriteLine("Total Before Taxes and Tip:  {0:C}" , vTotal);
            Console.WriteLine("After tax (7%): {0:C} " ,   CalculateBillWithTax(vTotal));
            Console.WriteLine("Tip (15%):  {0:C} " , AfterTax(CalculateBillWithTax(vTotal)));
            Console.WriteLine("Total including Taxes with 15% Tip: {0:C} " , CalculateTip(AfterTax(CalculateBillWithTax(vTotal)), CalculateBillWithTax(vTotal)));
            Console.ReadKey();

        }

        public static double CalculateBillWithTax(double v1)
        {
           double vCalc = (v1 * 7) / 100;
            
            return vCalc + v1;
        }

        public static double AfterTax (double v2)
        {
            double vTax = (v2 * 15) /100;
            return vTax;
        }

        public static double CalculateTip (double v1,  double v3)
        {

               return v1 + v3;
        }


    }
}
