using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint6.Task4.V2.Lib;
namespace Tyuiu.KimAV.Sprint6.Task4.V2.Test
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
            waitArray[0] = 59.49;
            waitArray[1] = 38.47;
            waitArray[2] = -2.81;
            waitArray[3] = -19.67;
            waitArray[4] = -8.42;
            waitArray[5] = 0.57;
            waitArray[6] = -6.3;
            waitArray[7] = -20.14;
            waitArray[8] = -3.51;
            waitArray[9] = 38.13;
            waitArray[10] = 59.6;

            double[] resultArray = new double[len];
            resultArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
