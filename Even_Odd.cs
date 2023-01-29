using System;

namespace Even_Odd_Numbur
{
    internal class Even_Odd
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a numbur:");
            int numbur =

                int.Parse(Console.ReadLine());



            if (numbur % 2 == 0)
            {
                Console.WriteLine(numbur + " Is even numbur");

            }
            else
            {
                Console.WriteLine(numbur + " It is odd numbur");
            }
        }
    }
}
