using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] matrix = new int[nm[0]][];
            for (int i = 0; i <=matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i][j] = input[j];
                }
            }
            int sumMax = int.MinValue;
            for (int row = 1; row <= matrix.GetUpperBound(0)-1; row++)
            {
                for (int col = 1; col < matrix[row].Length-1; col++)
                {
                    int sum = MatrixCalcSum(matrix, row, col);
                    if (sum>sumMax)
                    {
                        sumMax = sum;
                    }
                }
            }
            Console.WriteLine(sumMax);
        }

        private static int MatrixCalcSum(int[][] matrix, int row, int col)
        {
            int result = 0;
            for (int i = row-1; i <= row+1; i++)
            {
                for (int j = col-1; j <= col+1; j++)
                {
                    result += matrix[i][j];
                }
            }
            return result;
        }
    }
}
