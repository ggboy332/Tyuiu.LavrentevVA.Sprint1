using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LavrentevVA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Сприт #1 | Выполнил: Лаврентьев В. А. | ИСПБ-25-1";
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #1                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                *");
            Console.WriteLine("* Задание #0                                                      *");
            Console.WriteLine("* Вариант #0                                                      *");
            Console.WriteLine("* Выполнил: Лаврентьев В. А. | ИСПБ-25-1                          *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)    *");
            Console.WriteLine("* и печатает результат на экране.                                 *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ИСХОРДНЫЕ ДАННЫЕ:                                               *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* 4 * 5 / 2 - 18 / 2 / 3                                          *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadKey();

        }
    }
}

