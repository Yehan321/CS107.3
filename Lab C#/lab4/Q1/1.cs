using System;

namespace KilometerToMeterConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            

           
            Console.Write("enter the distance in kilometers: ");
            string kmInput = Console.ReadLine();

            
            if (double.TryParse(kmInput, out double kilometers))
            {
                
                ConvertValues converter = new ConvertValues();

                
                converter.kilometerTOmeter(kilometers);
            }
            else
            {
                Console.WriteLine("Error: Invalid input.enter a valid number for kilometers.");
            }

           
         
            Console.ReadKey();
        }
    }

   
    class ConvertValues
    {
        public void kilometerTOmeter(double kilometers)
        {
            double meters = kilometers * 1000;
            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
        }
    }
}
