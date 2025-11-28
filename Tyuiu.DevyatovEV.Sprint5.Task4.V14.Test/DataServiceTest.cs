using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint5.Task4.V14.Lib;

namespace Tyuiu.DevyatovEV.Sprint5.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл с временным путем
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask4.txt");

            // Записываем тестовое значение в файл
            double testValue = 2.5;
            File.WriteAllText(path, testValue.ToString());

            try
            {
                // Вычисляем результат
                double result = ds.LoadFromDataFile(path);

                // ПРАВИЛЬНОЕ вычисление ожидаемого значения:
                // x = 2.5
                // x³ = 2.5 * 2.5 * 2.5 = 15.625
                // sin(15.625) = sin(15.625 радиан)
                // 2/x = 2/2.5 = 0.8
                // y = sin(15.625) + 0.8

                double xCubed = Math.Pow(testValue, 3); // 15.625
                double sinValue = Math.Sin(xCubed);     // sin(15.625) ≈ 0.999
                double fraction = 2 / testValue;        // 0.8
                double expected = sinValue + fraction;  // 0.999 + 0.8 ≈ 1.799
                expected = Math.Round(expected, 3);

                Console.WriteLine($"x = {testValue}");
                Console.WriteLine($"x³ = {xCubed}");
                Console.WriteLine($"sin(x³) = {sinValue}");
                Console.WriteLine($"2/x = {fraction}");
                Console.WriteLine($"y = {expected}");
                Console.WriteLine($"result = {result}");

                // Проверяем результат
                Assert.AreEqual(expected, result);
            }
            finally
            {
                // Очистка
                TryDeleteFile(path);
            }
        }

        private void TryDeleteFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch
            {
                // Игнорируем ошибки удаления
            }
        }
    }
}