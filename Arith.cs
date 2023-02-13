using System;

namespace Basics1
{
    class addArithNumbers
    {
        public void addArithNum()
        {
            Console.WriteLine("Enter a number1:");
		    int num1 = Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine("Enter a number2:");
		    int num2 = Convert.ToInt32(Console.ReadLine());
		    int addt = num1 + num2;
		    int sub = num1 - num2; 
		    int multi = num1 * num2;
		    int modulo = num1 % num2;
		    Console.WriteLine("Addition of your two numbers is: " + addt);
		    Console.WriteLine("Subtraction  of your two numbers is: " + sub);
		    Console.WriteLine("Multiplication of your two numbers is: " + multi);
		    Console.WriteLine("Modulo of your two numbers is: " + modulo);
        }
    }
}