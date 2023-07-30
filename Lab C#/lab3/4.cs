using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

           
            Console.Write("enter a positive integer: ");
            string userInput = Console.ReadLine();

            
            if (int.TryParse(userInput, out int n))
            {
                if (n > 0)
                {
                    int sumOfOddNumbers = 0;

                   
                    for (int i = 1; i <= n; i += 2)
                    {
                        sumOfOddNumbers += i;
                    }

                    
                    Console.WriteLine($"Sum of odd numbers from 1 to {n}: {sumOfOddNumbers}");
                }
                else
                {
                    Console.WriteLine("Error:enter a positive integer greater than zero.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. enter a valid positive integer.");
            }

         
            Console.ReadKey();
        }
    }
}
