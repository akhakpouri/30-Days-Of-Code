using System;

namespace StringShift
{
    class Program
    {
        ///Check if a string can be obtained byu rotating another string 2 places. 
        static void Main(string[] args)
        {
            //Given the two strings below, the task is to find if a string can be obtained by rotating another string 2 places.
            //string 1: amazon. string 2: azonam -- true. rotating anti-clockwise
            //string 1: amazon. string 2: onamaz -- true. rotating clockwise
            //stirng 1: amazon. string 2; zonmaz -- false.
            string first = "amazon";
            string second = "azonam";
            Console.WriteLine($"Rotation is: {isRotated(first, second)}");
        }

        static bool isRotated(string first, string second)
        {
            //peform logic here
            return false;
        }
    }
}
