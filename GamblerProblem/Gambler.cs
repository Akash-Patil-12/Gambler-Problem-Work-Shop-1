using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerProblem
{
    class Gambler
    {
        public void Bet()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            Random random = new Random();
            int player = random.Next(0,2);
            Console.WriteLine(player);
            if (player == 0)
            {
                Console.WriteLine("Loss game");
                int stackPreviousValue = stack.Pop();
                stack.Push(stackPreviousValue - 1);
            }
            else
            {
                Console.WriteLine("Won the game");
                int stackPreviousValue = stack.Pop();
                stack.Push(stackPreviousValue + 1);
            }
            Console.WriteLine("After Game play Stack Value is =" + stack.Peek());
        }
    }
}
