using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grep
{
    class Program
    {
        static void Main(string[] args)
        {
            string resourceName = @"C:\Users\chaze\Desktop\grep.txt";
            int counter = 1;

            // All lines stored in an array
            string[] lines = System.IO.File.ReadAllLines(resourceName);
            
            // Text/word to find
            string text = Console.ReadLine().ToLower();

            Console.WriteLine("$ grab from " + resourceName);

            Console.WriteLine("The word " + text + " is found on the following lines:");
            foreach (string line in lines)
            {
                if (line.ToLower().Contains(text))
                    Console.WriteLine("\t" + counter + ": " + line);

                counter++;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
