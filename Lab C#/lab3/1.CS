using System;

namespace EvenOrOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            

           
            Console.Write("enter an integer: ");
            string userInput = Console.ReadLine();

           
            if (int.TryParse(userInput, out int number))
            {
                
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }

            
           
            Console.ReadKey();
        }
    }
}

