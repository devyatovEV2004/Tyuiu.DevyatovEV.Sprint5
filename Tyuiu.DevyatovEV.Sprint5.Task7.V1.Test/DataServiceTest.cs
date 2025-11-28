using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevyatovEV.Sprint5.Task7.V1.Lib;
using System.IO;
namespace Tyuiu.DevyatovEV.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}