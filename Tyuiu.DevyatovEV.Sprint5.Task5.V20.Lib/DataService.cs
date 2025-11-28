using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DevyatovEV.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(' ');
            List<double> data = [];
            double sum = 0;
            foreach (string str in strings)
            {
                double number = double.Parse(str, CultureInfo.InvariantCulture);
                if (number % 1 == 0 && number >= -10 && number <= 10)
                {
                    data.Add(number);
                }
            }
            foreach (double number in data)
            {
                sum += number;
            }
            return Math.Round(sum / data.Count, 3);
        }
    }
}