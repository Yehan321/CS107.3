using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Console.Write("enter the first number: ");
            string firstInput = Console.ReadLine();

            
            Console.Write("enter the second number: ");
            string secondInput = Console.ReadLine();

            
            if (double.TryParse(firstInput, out double firstNumber) && double.TryParse(secondInput, out double secondNumber))
            {
                
                double sum = firstNumber + secondNumber;

                
                Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            }

        
            
            Console.ReadKey();
        }
    }
}
