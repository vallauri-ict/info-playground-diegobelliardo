using System;

namespace _15_SecondoEventiContatore
{
    public class OverMaxEventArgs:EventArgs
    {
        public int ValoreSoglia { get; }

        public OverMaxEventArgs(int valoreSoglia)
        {
            ValoreSoglia = valoreSoglia;
        }
    }
}