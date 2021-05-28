using AForge.Neuro;
using AForge.Neuro.Learning;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeNN
{
    public class Trainer
    {
        public List<bool> Progress { get; private set; }
        public Model Model { get; private set; }
        Random rand = new Random();

        public Trainer()
        {
            Progress = new List<bool>();
            Model = null;
        }

        public void Train(int games)
        {
            ActivationNetwork net = new ActivationNetwork(new BipolarSigmoidFunction(), 9, 18, 9, 3, 1);
            BackPropagationLearning teacher = new BackPropagationLearning(net);

            net.Randomize();

            teacher.LearningRate = 0.025;

            for (int i = 0; i < games; i++)
            {
                var trainingGame = PlayTrainingGame(net, i % 2 == 0, i % 3 == 0);
                double[][] inputs = trainingGame.Item1;
                double[][] outputs = trainingGame.Item2;
                for (int j = 0; j < inputs.Length; j++)
                {
                    teacher.Run(inputs[j], outputs[j]);
                }
            }

            Model = new Model(net);
        }

        Tuple<double[][], double[][]> PlayTrainingGame(ActivationNetwork net, bool aiX, bool fullAi)
        {
            TicTacToeGame game = new TicTacToeGame();
            List<double[]> inputs = new List<double[]>();
            List<double[]> outputs = new List<double[]>();

            Model current = new Model(net);

            while (game.GetResult() == TicTacToeGame.Result.Unknown)
            {
                int playSquare;

                if (aiX == game.IsXTurn || fullAi)
                {
                    playSquare = current.BestSquare(game);
                }
                else
                {
                    int[] validSquares = game.ValidSquares().ToArray();
                    playSquare = validSquares[rand.Next(validSquares.Length)];
                }

                game.Move(playSquare);
                inputs.Add(game.GetBoardAsDouble(!game.IsXTurn));
            }

            double output;
            TicTacToeGame.Result result = game.GetResult();
            if (result == TicTacToeGame.Result.XWins)
            {
                output = 1;

            }
            else if (result == TicTacToeGame.Result.OWins)
            {
                output = -1;
            }
            else
            {
                output = 0;
            }
            for (int i = 0; i < inputs.Count; i++)
            {
                outputs.Add(new double[] { output * (i % 2 == 0 ? 1 : -1) });
            }
            Progress.Add(fullAi ? result == TicTacToeGame.Result.Tie : (aiX ? result == TicTacToeGame.Result.XWins : result == TicTacToeGame.Result.OWins));
            return new Tuple<double[][], double[][]>(inputs.ToArray(), outputs.ToArray());
        }
    }
}
