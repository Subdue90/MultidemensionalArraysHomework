using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FillTheMatrix
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the size of the matrix:");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++, number++)
                {
                    matrix[j, i] = number;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Array.Clear(matrix, 0, matrix.Length);
            number = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++, number++)
                    {
                        matrix[j, i] = number;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--, number++)
                    {
                        matrix[j, i] = number;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

