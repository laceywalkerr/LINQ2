using System;
using System.Collections.Generic;
using System.Linq;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
            {
                "Lemon",
                "Apple",
                "Orange",
                "Lime",
                "Watermelon",
                "Loganberry"

            };

            IEnumerable<string> LFruits = from fruit in fruits.Where(fruits => fruits.StartsWith("L"))

            Console.WriteLine(LFruits);

            // where fruit.StartsWith(L)
            // select fruit;
        }
    };
};