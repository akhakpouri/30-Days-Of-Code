using System;

namespace StringShift
{
    class Program
    {
        ///Check if two strings are a rtoation of one and other or not.
        static void Main(string[] args)
        {
            //string 1: amazon. string 2: azonam -- true. it is rotating anti-clockwise
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
