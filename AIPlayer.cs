using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    class AIPlayer : Player
    {
        private Random random;

        public AIPlayer(string name) : base(name)
        {
        }
        public override int MakeGuess()
        {
           random = new Random();
           int guess = random.Next(0, 101);
           Guesses.Add(guess);
           return guess;

        }

    }
}