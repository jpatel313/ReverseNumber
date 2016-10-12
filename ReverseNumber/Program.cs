using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro Message
            Console.WriteLine("This program will reverse the number you enter.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            
            //Ask user for number input
            Console.Write("Please enter a number: ");
            String inputNumber = Console.ReadLine();

            //Display results
            Console.Write("Reversed Result: ");
            ReverseString(inputNumber);
            Console.ReadLine();
        }

            //Helper Method
            private static void ReverseString(string result)
        {
            //Turn user input string into an array of characters
            char[] inputNumber = result.ToCharArray();

            //Reverse the array of individual digits 
            Array.Reverse(inputNumber);
            foreach (char item in inputNumber)
            {
                Console.Write(item);
            }
        }
    }
}