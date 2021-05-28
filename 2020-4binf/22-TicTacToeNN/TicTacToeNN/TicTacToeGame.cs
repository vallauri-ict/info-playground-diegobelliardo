using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeNN
{
    public class TicTacToeGame
    {
        int[] board;

        public bool IsXTurn
        {
            get;
            private set;
        }

        public enum Result
        {
            Unknown,
            XWins,
            OWins,
            Tie
        }

        public TicTacToeGame()
        {
            board = new int[9];
            IsXTurn = true;
        }

        public void Move(int square)
        {
            board[square] = IsXTurn ? 1 : -1;
            IsXTurn = !IsXTurn;
        }

        public double[] GetBoardAsDouble(bool xPointOfView)
        {
            double[] bd = new double[board.Length];
            int view = xPointOfView ? 1 : -1;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == -1)
                {
                    bd[i] = -view;
                }
                else if (board[i] == 1)
                {
                    bd[i] = view;
                }
                else
                {
                    bd[i] = 0.01;
                }
            }
            return bd;
        }

        public IEnumerable<int> ValidSquares()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == 0)
                {
                    yield return i;
                }
            }
        }

        public Result GetResult()
        {
            int diagonal1 = board[0] + board[4] + board[8];
            int diagonal2 = board[2] + board[4] + board[6];

            int row1 = board[0] + board[1] + board[2];
            int row2 = board[3] + board[4] + board[5];
            int row3 = board[6] + board[7] + board[8];

            int col1 = board[0] + board[3] + board[6];
            int col2 = board[1] + board[4] + board[7];
            int col3 = board[2] + board[5] + board[8];
            if (diagonal1 == 3 || diagonal2 == 3 || row1 == 3 || row2 == 3 || row3 == 3 || col1 == 3 || col2 == 3 || col3 == 3)
            {
                return Result.XWins;
            }
            else if (diagonal1 == -3 || diagonal2 == -3 || row1 == -3 || row2 == -3 || row3 == -3 || col1 == -3 || col2 == -3 || col3 == -3)
            {
                return Result.OWins;
            }

            if (board.Contains(0))
            {
                return Result.Unknown;
            }
            else
            {
                return Result.Tie;
            }
        }

        public void PrintBoard()
        {
            Console.WriteLine(@"-------------
| {0} | {1} | {2} |
-------------
| {3} | {4} | {5} |
-------------
| {6} | {7} | {8} |
-------------", board.Select(x => x == 1 ? "X" : (x == 0 ? " " : "O")).ToArray<object>());
        }
    }
}
