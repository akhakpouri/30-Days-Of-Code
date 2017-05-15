using System;

namespace ThirtyDaysOfCode.MealCost
{
    public class Program
    {
        static void Main(string[] args)
        {
            double mealCost;
            int tipPercent;
            int taxPercent;
            double.TryParse(Console.ReadLine(), out mealCost);
            int.TryParse(Console.ReadLine(), out tipPercent);
            int.TryParse(Console.ReadLine(), out taxPercent);

            double tip = (mealCost *  tipPercent) / 100;
            double tax = (mealCost * taxPercent) / 100;
            var totalCost = Math.Round(mealCost + tip + tax, 0);
            Console.WriteLine($"The total meal cost is {totalCost} dollars.");
            Console.ReadLine();


        }
    }
}