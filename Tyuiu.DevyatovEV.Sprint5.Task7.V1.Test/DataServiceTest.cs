using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevyatovEV.Sprint5.Task7.V1.Lib;
using System.IO;
using System.Text;

namespace Tyuiu.DevyatovEV.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл во временной директории
            string testInputPath = Path.Combine(Path.GetTempPath(), "TestInputFileTask7V1.txt");

            // Записываем тестовые данные
            string testData = "abc123def456ghi789";
            File.WriteAllText(testInputPath, testData, Encoding.UTF8);

            try
            {
                // Вызываем метод обработки
                string resultPath = ds.LoadDataAndSave(testInputPath);

                // Проверяем, что файл создан
                Assert.IsTrue(File.Exists(resultPath), "Выходной файл не создан");

                // Проверяем содержимое
                string resultContent = File.ReadAllText(resultPath);
                string expectedContent = "abcdefghi"; // Все цифры удалены

                Assert.AreEqual(expectedContent, resultContent.Trim(), "Цифры удалены некорректно");
            }
            finally
            {
                // Очистка
                if (File.Exists(testInputPath))
                    File.Delete(testInputPath);
            }
        }
    }
}