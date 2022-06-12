using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };   
            var even = new List <int>();
            var odd = new List <int>();

            foreach (int i in numbers)
            {
                int c = i % 2;
                if (c == 0)
                   even.Add(i);
                else 
                   odd.Add(i);

            }
            
            Console.WriteLine("Hello! Please name a a random object.");
            string Object= Console.ReadLine();
            Console.WriteLine($"Alright! Our even numbers will now represent {Object}'s. Let's see how many we have!");
            
            foreach (int i in even)
            {
                Console.WriteLine($"{i} {Object}'s");
            }
            
            Console.WriteLine("That was fun! Please, name another object.");
            string Object2 = Console.ReadLine(); ;
            Console.WriteLine($"We couldn't leave our odd numbers out! Odd numbers will now represent {Object2}'s.");

            foreach (int i in odd)
            {
                if (i == 1)
                    Console.WriteLine($"{i} {Object2}");
                else
                    Console.WriteLine($"{i} {Object2}'s");
            }

        }
    }
}
