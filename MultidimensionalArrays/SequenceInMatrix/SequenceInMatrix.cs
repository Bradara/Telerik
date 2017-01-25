using System;
using System.Collections.Generic;
using System.Linq;



namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            int[] inputNM = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = inputNM[0];
            int m = inputNM[1];

            string[,] matrix = new string[n, m];
            FillTheMatrix(matrix);
            int maxSequence = MaxSequence(matrix);

        }

        private static int MaxSequence(string[,] matrix)
        {
            int result = 0;
            List<string> sequence = new List<string>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int sequence = SequenceOf(matrix, row, col);
                }
            }


        }

        private static int SequenceOf(string[,] matrix, int row, int col)
        {
            List<string> sequence = new List<string>();
            string root = row.ToString() + col.ToString();
            sequence.Add(root);
            int startRow = (row - 1 >= 0) ? (row - 1) : (0);
            int endRow = (row + 1 <= matrix.GetLength(0)) ? (row + 1) : (matrix.GetLength(0)-1);
            int startCol = (col - 1 >= 0) ? (col - 1) : (0);
            int endCol = (col + 1 <= matrix.GetLength(1)) ? (col + 1) : (matrix.GetLength(1)-1);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <=endCol; j++)
                {
                    if (matrix[i,j]==matrix[row,col])
                    {
                        string temp = i.ToString() + j.ToString();
                        if (sequence.Contains(temp))
                        {
                            continue;
                        }
                        else
                        {
                            sequence.Add(temp);
                        }
                    }
                }
            }
        }

        private static void FillTheMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
