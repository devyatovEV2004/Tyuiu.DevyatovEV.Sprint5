using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DevyatovEV.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < (line.Length) - 2; i++)
                    {
                        if ((char.IsDigit(line[i])) && (char.IsDigit(line[i + 1])) && (char.IsDigit(line[i + 2])))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}