using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint5.Task3.V5.Lib;

namespace Tyuiu.DevyatovEV.Sprint5.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 2;

            string path = ds.SaveToFileTextData(x);

            // Ждем немного для освобождения файла
            System.Threading.Thread.Sleep(100);

            // Проверяем, что файл существует
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);

            // Проверяем имя файла
            string fileName = Path.GetFileName(path);
            Assert.AreEqual("OutPutFileTask3.bin", fileName);

            // Проверяем вычисление через метод Calculate
            double expectedValue = ds.Calculate(x);

            // Проверяем конкретное значение: F(2) = 2*8 + 0.5*4 - 7 + 2 = 16 + 2 - 7 + 2 = 13
            Assert.AreEqual(13.0, expectedValue);

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