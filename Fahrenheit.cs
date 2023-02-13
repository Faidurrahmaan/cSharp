using System;

namespace Basics1
{
    class addFahrenheitNumbers
    {
        public void addFahrenheitNum()
        {
            Console.WriteLine("Enter Celsius:");
		    double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius: " + celsius);

            double fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
        }
    }
}