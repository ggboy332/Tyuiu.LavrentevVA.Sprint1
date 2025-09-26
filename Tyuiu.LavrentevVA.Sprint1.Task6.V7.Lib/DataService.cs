using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LavrentevVA.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {

            if (string.IsNullOrEmpty(value))
                return value;

            string result = string.Join(" ", value.Split(' ').Select(word => word.Length > 1 ? word.Remove(word.Length - 1) : word));

            return result;
        }
    }
}
