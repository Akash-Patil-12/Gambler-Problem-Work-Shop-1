using System;

namespace GamblerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Gambler gambler = new Gambler();
            gambler.GamblerInitial();
            gambler.Bet();
        }
    }
}
