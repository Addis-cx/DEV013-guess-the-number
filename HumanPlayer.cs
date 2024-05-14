using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
     class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        //ocupo override para reescribir el metodo MakeGuess()
        public override int MakeGuess()
        {
            Console.Write("Ingresa tu número: ");
            int Guesses = Convert.ToInt32(Console.ReadLine());
            return Guesses;
        }
    }
}