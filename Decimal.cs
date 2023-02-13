using System;

namespace Basics1
{
    class addFloatNumbers
    {
        public void addFloatNum()
        {
            Console.WriteLine("Enter a floating number1:");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter a floating number2:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            decimal Total = num1 * num2;
            Console.WriteLine("Multiplication of two Floating Point Numbers is: " + Total);
        }
    }
}