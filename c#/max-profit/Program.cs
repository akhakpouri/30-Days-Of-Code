using System;

namespace MaxProfit
{

    /*
        You will be given a list of stock prices for a given day and your goal is to return the maximum profit that could have been made by buying a stock at the 
        given price and then selling the stock later on. For example if the input is: [45, 24, 35, 31, 40, 38, 11] then your program should return 16 because 
        if you bought the stock at $24 and sold it at $40, a profit of $16 was made and this is the largest profit that could be made. 
        
        If no profit could have been made, return -1.
    */
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new int[] {45, 24, 35, 31, 40, 38, 11};
            var profit = CalculateMaxProfit(prices);
            Console.WriteLine($"{profit}");
        }

        static int CalculateMaxProfit(int[] prices)
        {
            var maxProfit = -1;
            var buy = 0;
            var sell = 0;
            return 0;
        }
    }
}
