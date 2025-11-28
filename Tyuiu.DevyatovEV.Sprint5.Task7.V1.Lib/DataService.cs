using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.DevyatovEV.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");

            // Читаем весь файл
            string text = File.ReadAllText(path, Encoding.UTF8);

            // Удаляем все цифры с помощью регулярного выражения
            string result = Regex.Replace(text, @"[0-9]", "");

            result = Regex.Replace(result, @"\.\s*$", "");
            // Убираем лишние пробелы в начале и конце
            result = result.Trim();

            // Записываем результат
            File.WriteAllText(pathSaveFile, result, Encoding.UTF8);

            return pathSaveFile;
        }
    }
}