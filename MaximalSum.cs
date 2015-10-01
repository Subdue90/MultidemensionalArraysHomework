using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your matrix:");
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = dimentions[0];
            int m = dimentions[1];

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] rowNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rowNumbers[j];
                }
            }

            int currentSum = 0;
            int[] maxSubMatrix = { 0, 0, 0 };

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    currentSum = CalcSum(matrix, i, j)[0];
                    if (currentSum > maxSubMatrix[0])
                    {
                        maxSubMatrix[0] = currentSum;
                        maxSubMatrix[1] = i;
                        maxSubMatrix[2] = j;
                    }
                }
            }

            int startRow = maxSubMatrix[1], startCol = maxSubMatrix[2];

            Console.WriteLine("Sum = {0}", maxSubMatrix[0]);
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int[] CalcSum(int[,] matrix, int startRow, int startCol)
        {
            int[] subMatrix = { 0, startRow, startCol };
            int i = startRow, j = startCol;

            for (i = startRow; i < startRow + 3; i++)
            {
                for (j = startCol; j < startCol + 3; j++)
                {
                    subMatrix[0] += matrix[i, j];
                }
            }
            subMatrix[1] = i;
            subMatrix[2] = j;

            return subMatrix;
        }
    }

