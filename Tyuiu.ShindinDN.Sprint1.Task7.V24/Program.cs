﻿using Tyuiu.ShindinDN.Sprint1.Task7.V24.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шиндин Д. Н. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание 7                                                               *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Шиндин Денис Николаевич | ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*           _________                                                     *");
            Console.WriteLine("*      1 + /cos x + 1                                                     *");
            Console.WriteLine("* z =  --------------                                                     *");
            Console.WriteLine("*       sin(15y - 4)                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("z = {0}",ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
