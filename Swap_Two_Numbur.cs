using System;

namespace Swap_Two_Numbur
{
    internal class Swap_Two_Numbur
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the first numbur:");
            num1 =
            int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second numbur:");
            num2 =
            int.Parse(Console.ReadLine());
            num1 = num1 ^ num2;
            num2 = num1 ^ num2;
            num1 = num1 ^ num2;
            Console.WriteLine("After the swipping....");
            Console.WriteLine("Enter first numbur:" + num1);
            Console.WriteLine("Enter second numbur:" + num2);
        }
    }
}
