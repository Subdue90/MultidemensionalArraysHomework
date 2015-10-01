using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CollectTheCoins
    {
        static int currentRow = 0;
        static int currentCol = 0;
        static int coinCount = 0;
        static int wallHits = 0;

        static void Main()
        {
            string[] board = new string[4];
            FillTheBoard(board);

            string commands = Console.ReadLine();
            MoveAroundTheBoard(commands, board);

            Console.WriteLine();
            Console.WriteLine("Coins collected: {0}", coinCount);
            Console.WriteLine("Walls hit: {0}", wallHits);
        }

        static void FillTheBoard(string[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Console.ReadLine();
            }
        }

        static void MoveAroundTheBoard(string commands, string[] board)
        {
            CollectCoin(board);

            foreach (char command in commands)
            {
                if (command == '>')
                {
                    PerformMove(board, currentRow, currentCol + 1);
                }
                else if (command == '<')
                {
                    PerformMove(board, currentRow, currentCol - 1);
                }
                else if (command == '^')
                {
                    PerformMove(board, currentRow - 1, currentCol - 1);
                }
                else if (command == 'V')
                {
                    PerformMove(board, currentRow + 1, currentCol - 1);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\"{0}\" is an unrecognised command.", command);
                    Console.WriteLine("The command \"{0}\" was not executed.", command);
                }
            }
        }

        static void PerformMove(string[] field, int row, int col)
        {
            if (ValidMove(field, row, col))
            {
                currentCol = col;
                currentRow = row;
                CollectCoin(field);
            }
            else
            {
                wallHits++;
            }
        }

        static bool ValidMove(string[] field, int row, int col)
        {
            bool isValid = false;

            if (row >= 0 && row < field.Length)
            {
                if (col >= 0 && col < field[row].Length)
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        static void CollectCoin(string[] field)
        {
            if (field[currentRow][currentCol] == '$')
            {
                coinCount++;
            }
        }
    }

