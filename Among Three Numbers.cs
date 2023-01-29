using System;

namespace Among_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three difrent ");
            Console.WriteLine("ente no.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no.");
            int c = int.Parse(Console.ReadLine());
            int large = 0;
            if (a > b && a > c)
            {
                large = a;

            }
            else if (b > a && b > c)
            {
                large = b;

            }
            else
            {
                large = c;

            }

            Console.WriteLine(large + " is larger than other");
        }
    }
}
