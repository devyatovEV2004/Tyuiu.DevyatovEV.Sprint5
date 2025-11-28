using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.DevyatovEV.Sprint5.Task1.V24.Lib;

namespace Tyuiu.DevyatovEV.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

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