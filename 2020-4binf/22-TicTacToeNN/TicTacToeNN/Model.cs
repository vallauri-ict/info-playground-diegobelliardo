using AForge.Neuro;

namespace TicTacToeNN
{
    public class Model
    {
        ActivationNetwork net;
        internal Model(ActivationNetwork network)
        {
            net = network;
        }

        public int BestSquare(TicTacToeGame game)
        {
            int bestSquare = 0;
            double bestScore = double.NegativeInfinity;

            foreach (int square in game.ValidSquares())
            {
                double[] boardAfter = game.GetBoardAsDouble(game.IsXTurn);
                boardAfter[square] = 1;
                double score = net.Compute(boardAfter)[0];

                if (score > bestScore)
                {
                    bestScore = score;
                    bestSquare = square;
                }
            }
            return bestSquare;
        }
    }
}
