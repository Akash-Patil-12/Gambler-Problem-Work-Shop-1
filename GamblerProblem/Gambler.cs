using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerProblem
{
    class Gambler
    {
        public void GamblerInitial()
        {
            const int STAKE = 100;
            const int BET = 1;
            Console.WriteLine("stake is =" + STAKE + " and Bet is =" + BET);
        }
        public void Bet()
        {
            int stake = 100;
            int bet = 1;
            Random random = new Random();
            int player = random.Next(0, 2);
            if (player == 0)
            {
                Console.WriteLine("Loss game");
                 stake = stake - 1;
            }
            else
            {
                stake = stake + 1;
                Console.WriteLine("Win a game");
            }
            Console.WriteLine("After bet stake is =" + stake);

        }

    }
}
