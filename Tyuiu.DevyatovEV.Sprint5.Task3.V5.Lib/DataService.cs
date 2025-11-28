using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DevyatovEV.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double F = Calculate(x);

            // Упрощенная запись в файл
            File.WriteAllText(path, F.ToString());

            return path;
        }

        public double Calculate(int x)
        {
            double F = 2 * Math.Pow(x, 3) + 0.5 * Math.Pow(x, 2) - 3.5 * x + 2;
            F = Math.Round(F, 3);
            return F;
        }
    }
}