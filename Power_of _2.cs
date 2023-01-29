using System;

namespace Power_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no. as power of 2");

            int n = int.Parse(Console.ReadLine());
            int number = 2;
            int sum = 1;
            for (int i = 0; i < n; i++)
            {
                sum = sum * number;
            }
            Console.WriteLine(sum);
        }
    }
}
