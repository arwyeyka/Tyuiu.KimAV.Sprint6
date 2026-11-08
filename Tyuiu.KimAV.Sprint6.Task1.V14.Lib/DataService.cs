using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KimAV.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] result = new double[len];
            double function = 0;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((Math.Cos(i) + i) != 0)
                {
                    function = (2 * i + 6) / (Math.Cos(i) + i) - 3;
                    result[count] = Math.Round(function, 2);
                }
                else
                {
                    function = 0;
                    result[count] = function;
                }
                count++;
            }
            return result;
        }
    }
}
