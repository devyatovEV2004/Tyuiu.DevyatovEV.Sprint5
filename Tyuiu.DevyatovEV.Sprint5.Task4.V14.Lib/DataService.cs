using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DevyatovEV.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            // Чтение значения из файла
            string strValue = File.ReadAllText(path);

            // Преобразование в double (с учетом региональных настроек)
            double x = Convert.ToDouble(strValue);

            // Вычисление формулы y = sin(x³) + 2/x
            double xCubed = Math.Pow(x, 3);
            double sinValue = Math.Sin(xCubed);
            double fraction = 2 / x;
            double y = sinValue + fraction;

            // Округление до трёх знаков после запятой
            y = Math.Round(y, 3);

            return y;
        }
    }
}