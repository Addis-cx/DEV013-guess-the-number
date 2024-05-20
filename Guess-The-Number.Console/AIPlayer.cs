using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    class AIPlayer : Player //Clase heredada de Player, con sus propiedades y métodos
    {
        private Random? random; //Variable para generar números aleatorios

        public AIPlayer() : base("System")
        {
        }
        public override int MakeGuess() //override indica que estoy reescribiendo el metodo MakeGuess
        {
            random = new Random();
            int guess = random.Next(0, 101);
            Guesses.Add(guess); //Agregué el numero(guess) a la lista de intentos(Guesses)
            Console.Write("Numero ingresado: ");
            Console.WriteLine(guess);
            return guess;
        }

    }
}