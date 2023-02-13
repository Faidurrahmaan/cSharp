using System;

namespace Basics1
{
    class addTwoNumbers
    {
        static void Main(string[] args)
        {
            //arithmetics
            addArithNumbers arith = new addArithNumbers();
            arith.addArithNum();

            //floating claculation
            addFloatNumbers flt = new addFloatNumbers();
            flt.addFloatNum();

            //Fahrenheit convert
            addFahrenheitNumbers frt = new addFahrenheitNumbers();
            frt.addFahrenheitNum();

            //meters
            addmeterNumbers met = new addmeterNumbers();
            met.addMeterNum();

            //swaping value
            addSwapNumbers swap = new addSwapNumbers();
            swap.addSwapNum();
        }
    }
}