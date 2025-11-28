using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint5.Task2.V20.Lib;

namespace Tyuiu.DevyatovEV.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            // Тестовый массив из условия
            int[,] matrix = new int[3, 3]
            {
                { 5, -5, -1 },
                { -4, 2, -4 },
                { -7, 1, 4 }
            };

            string path = ds.SaveToFileTextData(matrix);

            // Ждем немного для освобождения файла
            System.Threading.Thread.Sleep(100);

            // Проверяем, что файл существует
            bool fileExists = File.Exists(path);
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

            // Очистка
            TryDeleteFile(path);
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