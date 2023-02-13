using System;

namespace Basics1
{
    class addSwapNumbers
    {
        public void addSwapNum()
        {
            int num1 = 20;
           	int num2 = 100;
		    int num3 =  num1 * num2;     
            		
		    num1 = num3 / num1;      
        	num2 = num3 / num2;
            Console.WriteLine("After swap num1: " + num1);
            Console.WriteLine("\nAfter swap num2: " + num2);
        }
    }
}