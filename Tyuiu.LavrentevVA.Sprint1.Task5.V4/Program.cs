using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LavrentevVA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Сприт #1 | Выполнил: Лаврентьев В. А. | ИСПБ-25-1";
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                                  *");
            Console.WriteLine("* Задание #5                                                                                                        *");
            Console.WriteLine("* Вариант #4                                                                                                        *");
            Console.WriteLine("* Выполнил: Лаврентьев В. А. | ИСПБ-25-1                                                                            *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                          *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                                                              *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h) прошло к этому моменту (например, h=3, если k=13257).*");
            Console.WriteLine("*                                                                                                                   *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* ИСХОРДНЫЕ ДАННЫЕ:                                                                                                 *");
            Console.WriteLine("*********************************************************************************************************************");

            int x;

            Console.WriteLine("Введите количество секунд: ");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Количество часов = " + ds.SecondsToHours(x));

            Console.ReadLine();
        }
    }
}