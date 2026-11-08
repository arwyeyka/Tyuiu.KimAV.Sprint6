using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint6.Task5.V14.Lib;
namespace Tyuiu.KimAV.Sprint6.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V14.txt";

            DataService ds = new DataService();

            double[] waitArray = new double[9];
            double[] resultArray = new double[9];
            resultArray = ds.LoadFromDataFile(path);

            waitArray[0] = 13;
            waitArray[1] = 11.49;
            waitArray[2] = 10;
            waitArray[3] = 14.52;
            waitArray[4] = 16;
            waitArray[5] = 13.66;
            waitArray[6] = 19;
            waitArray[7] = 11;
            waitArray[8] = 11.28;

            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
