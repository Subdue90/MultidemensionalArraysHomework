using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SequenceInMatrix
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the matrix dimensions, separated by a space.");
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];

            string[,] matrix = new string[n, m];

            Console.WriteLine("Please, enter the strings in each row, separated by a space.");
            for (int i = 0; i < n; i++)
            {
                string[] rowStrins = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rowStrins[j];
                }
            }

            int maxCount = 0;
            string maxString = "";
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    int countX = 0;
                    int countY = 0;

                    while (row + countX < matrix.GetLength(0))
                    {
                        if (matrix[row, col] == matrix[row + countX, col])
                        {
                            countX++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (countX + 1 > maxCount)
                    {
                        maxCount = countX;
                        maxString = matrix[row, col];
                    }

                    while (col + countY < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row, col + countY])
                        {
                            countY++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (countY + 1 > maxCount)
                    {
                        maxCount = countY;
                        maxString = matrix[row, col];
                    }
                    countX = 0;

                    while (row + countX < matrix.GetLength(0) && col + countX < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row + countX, col + countX])
                        {
                            countX++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (countX + 1 > maxCount)
                    {
                        maxCount = countX;
                        maxString = matrix[row, col];
                    }
                }
            }

            Console.Write("The longest sequence is: {0}", maxString);
            for (int i = 1; i < maxCount; i++)
            {
                Console.Write(",{0}", maxString);
            }
            Console.WriteLine();
        }
    }

