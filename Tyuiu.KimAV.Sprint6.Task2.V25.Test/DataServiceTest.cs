using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint6.Task2.V25.Lib;
namespace Tyuiu.KimAV.Sprint6.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;

            double[] waitArray = new double[len];
            waitArray[0] = 23.61;
            waitArray[1] = 16.08;
            waitArray[2] = 7.84;
            waitArray[3] = 4.58;
            waitArray[4] = 2.88;
            waitArray[5] = 0.75;
            waitArray[6] = -4.47;
            waitArray[7] = -9.46;
            waitArray[8] = -7.41;
            waitArray[9] = -6.16;
            waitArray[10] = -7.29;

            double[] resultArray = new double[len];
            resultArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
