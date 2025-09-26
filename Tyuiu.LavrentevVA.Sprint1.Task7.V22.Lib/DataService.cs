using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LavrentevVA.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double tan = Math.Tan(x);
            double ctg = 1.0 / tan;  
            double result = Math.Pow(1 - tan, ctg) + Math.Cos(x - y);
            return Math.Round(result, 3);
        }
    }
}
