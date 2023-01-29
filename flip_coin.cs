using System;
using System.Net;
using System.Security.Cryptography;

namespace flipcoin
{
    internal class Program
    {
        static void Main(string[] args)
        {for(int i=0;i<6;i++) 
            {
                Random ran = new Random();
                int num = ran.Next(0,2);
                int.Parse(num.ToString());

                if (num==0)
                {
                    Console.WriteLine("Head");

                }
                else
                {
                    Console.WriteLine("Tail");
                }
            }
        }
    }
            
}
    

