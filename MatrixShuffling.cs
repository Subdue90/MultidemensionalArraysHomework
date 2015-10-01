using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MatrixShuffling
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your string matrix:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            string[] commands = new string[5];
            while (commands[0] != "END")
            {
                commands = Console.ReadLine().Split().ToArray();
                if (commands[0] == "swap")
                {
                    int y1 = int.Parse(commands[1]);
                    int x1 = int.Parse(commands[2]);
                    int y2 = int.Parse(commands[3]);
                    int x2 = int.Parse(commands[4]);

                    if (!AreDimentionsValid(y1, x1, y2, x2, n, m))
                    {
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine();
                        continue;
                    }

                    string tempValue = matrix[y1, x1];
                    matrix[y1, x1] = matrix[y2, x2];
                    matrix[y2, x2] = tempValue;

                    PrintMatrix(matrix);
                }
                else if (commands[0] == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine();
                    continue;
                }
            }
        }

        static bool AreDimentionsValid(int y1, int x1, int y2, int x2,
            int rowLength, int colLength)
        {
            bool areValid = true;

            if (x1 < 0 || x1 >= colLength)
            {
                areValid = false;
            }
            else if (x2 < 0 || x2 >= colLength)
            {
                areValid = false;
            }
            else if (y1 < 0 || y1 >= rowLength)
            {
                areValid = false;
            }
            else if (y2 < 0 || y2 >= rowLength)
            {
                areValid = false;
            }

            return areValid;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
