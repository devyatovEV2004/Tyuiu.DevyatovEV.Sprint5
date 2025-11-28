using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DevyatovEV.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y;

                    if (4 * x - 0.5 == 0)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = ((3 * Math.Cos(x)) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2;
                    }

                    y = Math.Round(y, 2);

                    if (x != stopValue)
                    {
                        writer.WriteLine(y);
                    }
                    else
                    {
                        writer.Write(y);
                    }
                }
            }

            return path;
        }
    }
}