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

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\chaze\Desktop\grep.txt");

            string text = Console.ReadLine();

            // Display the file contents by using a foreach loop.
            Console.WriteLine("The word " + text + " is found on the following lines:");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                if(line.IndexOf(text) != -1)
                {
                    Console.WriteLine("\t" + (line.IndexOf(text)+1));
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
