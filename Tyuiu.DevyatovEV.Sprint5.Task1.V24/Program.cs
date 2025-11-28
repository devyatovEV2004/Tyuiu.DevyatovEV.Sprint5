using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint5.Task1.V24.Lib;

namespace Tyuiu.DevyatovEV.Sprint5.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (3 * cos(x)) / (4x - 0.5) + sin(x) - 5x - 2         *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.           *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
            Console.WriteLine("* Результат сохранить в текстовый файл и вывести на консоль.              *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Выводим таблицу на консоль
            Console.WriteLine("x\tF(x)");
            Console.WriteLine("----------------");

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (4 * x - 0.5 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((3 * Math.Cos(x)) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2;
                }

                y = Math.Round(y, 2);
                Console.WriteLine($"{x}\t{y}");
            }

            // Сохраняем в файл
            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"\nФайл: {res}");
            Console.WriteLine("Создан!");

            // Выводим содержимое файла
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine(File.ReadAllText(res));

            Console.ReadKey();
        }
    }
}