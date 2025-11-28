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

            int x = 2;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вычисление значения для вывода на консоль
            double result = ds.Calculate(x);
            Console.WriteLine($"Вычисленное значение F({x}) = {result}");

            // Сохранение в бинарный файл
            string path = ds.SaveToFileTextData(x);
            Console.WriteLine($"Результат сохранен в файл: {path}");

            // Чтение и вывод содержимого бинарного файла
            double fileValue = ReadBinaryFile(path);
            Console.WriteLine($"Значение из файла: {fileValue}");

            Console.ReadKey();
        }

        // Метод для чтения бинарного файла
        private static double ReadBinaryFile(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                return reader.ReadDouble();
            }
        }
    }
}