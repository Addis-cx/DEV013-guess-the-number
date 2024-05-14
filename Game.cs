using System;
using System.Collections.Generic;
using System.Numerics;

namespace GuessTheNumber
{
    class Game
    {
        private int RandomNumber;
        private readonly Player _AIPlayer;
        private readonly Player _HumanPlayer;

        public Game()
        {
            RandomNumberGenerator();
        }
        private void RandomNumberGenerator()
        {
            RandomNumber = new Random().Next(0, 101);
        }
        public bool CheckGuess( int guess, int targetNumber )
        {
            if ( guess > targetNumber )
            {
                Console.Write("¡To High!");
                return false;
            }
            else if ( guess < targetNumber )
            {
                Console.Write("¡To Low!");
                return false;
            }
            else
            {
                Console.Write("¡YOU WIN!");
                return true;
            }
        }
        public void StartGame()
        {
            Console.WriteLine($"BIENVENIDA AL JUEGO DE ADIVINAR NÚMEROS");
            while (true)
            {
                int guess = ;
                if (CheckGuess( guess, RandomNumber))
                {
                    break;
                }
            }
        }
    }
} 