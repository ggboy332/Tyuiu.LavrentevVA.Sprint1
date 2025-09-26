using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LavrentevVA.Sprint1.Task6.V7.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task6.V7
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
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова, удалив из них последнюю букву.               *");
            Console.WriteLine("*                                                                                                                   *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* ИСХОРДНЫЕ ДАННЫЕ:                                                                                                 *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
         


            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Итоговый текст с учетом удаление последней буквы с каждого слова = " + ds.DeleteLastLetter(str));

            Console.ReadKey();
        }
    }
}