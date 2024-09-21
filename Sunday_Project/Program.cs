using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace RandomArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraysize = random.Next(10, 21);
            List<int> numbers = new List<int>();

            while (numbers.Count < arraysize)
            {
                int newnumber = random.Next(0, 101);
                if (!numbers.Contains(newnumber)) numbers.Add(newnumber);
            }

            Console.WriteLine("Array Size: " + arraysize);
            Console.WriteLine("Array Element: " + string.Join(", ", numbers));

            int largest = numbers[0];
            int smallest = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largest) largest = number;
                if (number < smallest) smallest = number;
            }
            Console.WriteLine("Largest Number: " + largest);
            Console.WriteLine("Smallest Number: " + smallest);
        }
    }
}
            















            


