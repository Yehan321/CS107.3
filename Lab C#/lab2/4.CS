using System;

namespace EvenOrOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
        

           
            Console.Write("enter a number: ");
            string userInput = Console.ReadLine();

            
            if (int.TryParse(userInput, out int number))
            {
               
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
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
