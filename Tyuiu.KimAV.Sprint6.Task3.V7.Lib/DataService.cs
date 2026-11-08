using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KimAV.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[,] resultMatrix = new int[rows, columns];

            int colIndex = 3; // 4-й столбец

            int[] columnValues = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                columnValues[i] = matrix[i, colIndex];
            }

            Array.Sort(columnValues);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, colIndex] = columnValues[i];
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultMatrix[i, j] = matrix[i, j];

                    if (j == 3)
                    {
                        resultMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            return resultMatrix;
        }
    }
}
