using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevyatovEV.Sprint5.Task7.V1.Lib;
using System.IO;

namespace Tyuiu.DevyatovEV.Sprint5.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Девятов Е.В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Девятов Егор Владимирович | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все цифры     *");
            Console.WriteLine("* из файла. Полученный результат сохранить в файл OutPutDataFileTask7V1.txt.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            Console.WriteLine("Исходные данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = @"C:\Users\Egor\source\repos\Tyuiu.DevyatovEV.Sprint5\Tyuiu.DevyatovEV.Sprint5.Task7.V1\bin\Debug\OutPutDataFileTask7V1.txt";
            Console.WriteLine("Конечные данные находятся в файле: " + pathSaveFile);

            pathSaveFile = ds.LoadDataAndSave(path);


            Console.ReadKey();
        }
    }
}