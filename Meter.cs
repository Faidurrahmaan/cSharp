using System;

namespace Basics1
{
    class addmeterNumbers
    {
        public void addMeterNum()
        {
            Console.WriteLine("Enter feet :");
		    double feet = Convert.ToInt32(Console.ReadLine());
            double meter = feet / 3.2808399;
        	Console.WriteLine("\nFeet in meter : " + meter);
        }
    }
}