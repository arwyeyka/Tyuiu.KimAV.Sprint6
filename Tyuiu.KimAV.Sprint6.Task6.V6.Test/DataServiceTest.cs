using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint6.Task6.V6.Lib;
namespace Tyuiu.KimAV.Sprint6.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V6.txt";

            string wait = "YebQ HbJcPW";
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual(wait, result);
        }
    }
}
