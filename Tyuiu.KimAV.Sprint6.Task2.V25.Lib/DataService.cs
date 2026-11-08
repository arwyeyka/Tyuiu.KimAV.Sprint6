using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KimAV.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                //if ((Math.Sin(i) - 2) != 0)
                // {
                y = (5 * i + 2.5) / (Math.Sin(i) - 2) + 2;
                y = Math.Round(y, 2);
                //}
                //else
                // {
                //    y = 0;
                // }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
