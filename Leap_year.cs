using System;

namespace Leapyear
{
    internal class Leap_year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year is a leap year");
            int a=int.Parse(Console.ReadLine());
            int P = (a % 400);
            int Q = (a % 4);
            int R = (a % 100);
            int b = 0;
            if(b==Q)
            {
                Console.WriteLine("is a leap year");

            }else if(b == P)
            {
                Console.WriteLine(" year is a leap year");

            } else if(b == R)
            {
                Console.WriteLine("year is leap year ");
            }
            else
            {
                Console.WriteLine("Is not a leap year");
            }
            
        }

            
    }
}

