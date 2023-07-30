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

                
                double meters = converter.KilometerToMeter(kilometers);

                
                Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number for kilometers.");
            }

            
            Console.ReadKey();
        }
    }

   
    class ConvertValues
    {
        public double KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            return meters;
        }
    }
}
