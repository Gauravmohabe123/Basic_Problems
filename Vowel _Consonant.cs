using System;

namespace Vowel__Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a alphbet ");

            char given = char.Parse(Console.ReadLine());
            char[] chars = { 'a', 'i', 'o', 'u', 'e' };
            bool check = false;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == given)
                {

                    check = true;

                }


            }
            if (check == true)
            {
                Console.WriteLine(given + " is a vowel");
            }
            else
            {
                Console.WriteLine(given + " is a consonant");
            }
        }
    }
}
