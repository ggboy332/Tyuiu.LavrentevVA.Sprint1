using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LavrentevVA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int num = (int)number;

            int digit1 = num / 100;
            int digit2 = (num / 10) % 10;
            int digit3 = num % 10;

            double product = digit1 * digit2 * digit3;

            return Math.Round(product, 3);
        }
    }
}
