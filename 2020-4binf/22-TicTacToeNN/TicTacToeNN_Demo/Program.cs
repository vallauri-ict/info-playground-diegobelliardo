using System;
using System.Diagnostics;
using System.Linq;
using TicTacToeNN;

namespace TicTacToeNN_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainer = new Trainer();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            trainer.Train(500000); // 500K training games
            sw.Stop();
            Console.WriteLine("Training completed in {0} seconds.", sw.Elapsed.TotalSeconds.ToString("0.0"));

            var model = trainer.Model;

            bool playerIsX = true;
 
            while (true)
            {
                Console.WriteLine("Let's play a game.");

                TicTacToeGame game = new TicTacToeGame();
                while (game.GetResult() == TicTacToeGame.Result.Unknown)
                {
                    game.PrintBoard();
                    if (game.IsXTurn == playerIsX)
                    {
                        Console.Write("Type a square (0-8): ");
                        int square = int.Parse(Console.ReadLine().Trim());
                        if (game.ValidSquares().Contains(square))
                        {
                            game.Move(square);
                        }
                        else
                        {
                            Console.WriteLine("Invalid square");
                        }
                    }
                    else
                    {
                        game.Move(model.BestSquare(game));
                    }
                }
                game.PrintBoard();
                Console.WriteLine("Result: {0}", game.GetResult().ToString());

                playerIsX = !playerIsX;
            }
        }
    }
}
