using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirtyDaysOfCode.ScratchPad
{
    internal delegate bool MeDelegate(int n);
    internal static class Program
    {
        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            return numbers.Where(number => gauntlet(number));
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 7, 3, 9, 17, 5, 13, 18, 25 };
            var results = RunNumbersThroughGauntlet(numbers, n => n < 5);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}