using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint5.Task2.V20.Lib;

namespace Tyuiu.DevyatovEV.Sprint5.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[3, 3];

            Console.WriteLine("Введите 9 элементов массива 3x3:");

            // Ввод данных с клавиатуры
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Вывод исходного массива
            Console.WriteLine("\nИсходный массив:");
            PrintArray(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Обработка массива
            int[,] resultArray = ProcessArray(array);

            Console.WriteLine("Преобразованный массив:");
            PrintArray(resultArray);

            // Сохранение в файл
            string res = ds.SaveToFileTextData(array);
            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан!");

            // Вывод содержимого файла
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine(File.ReadAllText(res));

            Console.ReadKey();
        }

        // Метод для обработки массива
        static int[,] ProcessArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = array[i, j] > 0 ? 1 : 0;
                }
            }

            return result;
        }

        // Метод для вывода массива на консоль
        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}