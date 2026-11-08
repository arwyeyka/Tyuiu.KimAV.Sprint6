using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint6.Task3.V7.Lib;
namespace Tyuiu.KimAV.Sprint6.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5]
            {
            {31, 25, -18, 12, 9 },
            {6, 34, -2, 2, -18 },
            {-5, 4, 27, 4, -1 },
            {4, 15, 34, -6, -10 },
            {0, 8, 5, 14, -17 }};

            int[,] waitMatrix = new int[5, 5]
            {
            {31, 25, -18, -6, 9 },
            {6, 34, -2, 2, -18 },
            {-5, 4, 27, 4, -1 },
            {4, 15, 34, 12, -10 },
            {0, 8, 5, 14, -17 }};

            int[,] resultMatrix = new int[5, 5];
            resultMatrix = ds.Calculate(mtrx);

            CollectionAssert.AreEqual(waitMatrix, resultMatrix);
        }
    }
}
