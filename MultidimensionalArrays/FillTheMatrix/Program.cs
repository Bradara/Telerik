using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//91/100 in BG Coder.
namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());

            int[,] matrix = new int[n, n];
            if (c == 'a')
            {
                FillMatrixA(n, matrix);
            }
            if (c == 'b')
            {
                FillMatrixB(n, matrix);
            }
            if (c == 'c')
            {
                FillMatrixC(matrix, n);
            }
            if (c=='d')
            {
                FillMatrixD(matrix, n);
            }

            PrintMatrix(n, matrix);
            Hello();
        }

        private static void Hello()
        {
            Console.WriteLine("Hallo Penko");
        }

        private static void FillMatrixD(int[,] matrix, int n)
        {
            int count = 1;
            int k = 0;
            int row = 0;
            int col = 0;
            matrix[row, col] = count++;
            while (row+1<n-k&&col+1<n-k)
            {
                row++;
                if (row+1<n-k&&col+1<n-k)
                {
                    for (int i =row; i < n-k; i++)
                    {
                        row = i;
                        matrix[row, col] = count++;                      
                    }
                }
                if (row+1==n-k&&col+1<n-k)
                {
                    col++;
                    for (int i = col; i < n-k; i++)
                    {
                        col = i;
                        matrix[row, col] = count++;
                    }
                }
                if (row+1==n-k&&col+1==n-k)
                {
                    row--;
                    for (int i = row; i >= k; i--)
                    {
                        row = i;
                        matrix[row, col] = count++;
                    }
                }
                if (row==k&&col==n-k-1)
                {
                    col--;
                    for (int i =col; i > k; i--)
                    {
                        col = i;
                        matrix[row, col] = count++;
                    }
                    k++;
                }
            }
        }

        private static void FillMatrixA(int n, int[,] matrix)
        {
            int count = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count++;
                }

            }
        }

        static void PrintMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 3}", matrix[row, col]);
                   
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrixB(int n, int[,] matrix)
        {
            int count = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (col % 2 == 1)
                    {
                        matrix[n - 1 - row, col] = count++;
                    }
                    else
                    {
                        matrix[row, col] = count++;
                    }
                }
            }
        }

        private static void FillMatrixC(int[,] matrix,int n)
        {
            int row = n-1;
            int col = 0;
            int count = 1;
            while (true)
            {
                matrix[row, col] = count++;
                //Variant 1: row reach end, but colon have enough space.
                if (row + 1 == n&&col+1<n)
                {
                    row = row - 1 - col;
                    col = 0;                   
                }
                //Variant2: colon and row have enough spave.
                else if (row+1<n&&col+1<n)
                {
                    row++;
                    col++;
                }
                //Variant3:colon reach end, but row have spave.
                else if (row+1<=n&&col+1==n&&row>0)
                {
                    col = n - row;
                    row = 0;
                }
               
                //Break condition: matrix is full.
                else if (row==0&&col==n-1)
                {
                    break;
                }
            }
        }
    }
}
