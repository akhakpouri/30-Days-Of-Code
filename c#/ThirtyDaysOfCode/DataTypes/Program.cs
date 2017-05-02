using System;

namespace ThirtyDaysOfCode.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 4;
            var d = 4.0;
            var s = "HackerRank ";
            int num;
            double db;
            // Read and save an integer, double, and String to your variables.
            int.TryParse(Console.ReadLine(), out num);
            double.TryParse(Console.ReadLine(), out db);
            var sentence = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            var sumNum = i + num;
            Console.WriteLine(sumNum);
            // Print the sum of the double variables on a new line.
            var sumDb = d + db;
            Console.WriteLine(sumDb.ToString("0.0") );
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s}{sentence}");
            Console.ReadKey();
        }
    }
}