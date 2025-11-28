using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint5.Task3.V5.Lib;

namespace Tyuiu.DevyatovEV.Sprint5.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи в бинарный файл                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2x³ + ½x² - 3.5x + 2, вычислить его значение      *");
            Console.WriteLine("* при x = 2, результат сохранить в бинарный файл OutPutFileTask3.bin      *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение x: " + x);
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.ReadLine();
        }
    }
}