using System;

namespace Quotient_and_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, quotient, remainder;
            Console.WriteLine("Enter numbur 1");
            num1 =
            int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 ");
            num2 =
                int.Parse(Console.ReadLine());
            quotient = (num1 / num2);
            remainder = (num2 % num1);
            Console.WriteLine("quotient:{0}" + quotient);
            Console.WriteLine("remainder:{0}" + remainder);

        }
    }
}
