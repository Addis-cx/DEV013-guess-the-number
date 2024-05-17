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

        public Game( string name )
        {
            RandomNumberGenerator();
            _AIPlayer = new AIPlayer();
            _HumanPlayer = new HumanPlayer(name);
        }
        private void RandomNumberGenerator()
        {
            RandomNumber = new Random().Next(0, 101);
        }
        public bool CheckGuess( int guess, int targetNumber )
        {
            if ( guess > targetNumber )
            {
                Console.WriteLine("¡To High!");
                return false;
            }
            else if ( guess < targetNumber )
            {
                Console.WriteLine("¡To Low!");
                return false;
            }
            else
            {
                Console.WriteLine("¡YOU WIN!");
                return true;
            }
        }
        public void StartGame(string name)
        {
            Console.WriteLine($"BIENVENIDAS AL JUEGO DE ADIVINAR NÚMEROS");
            bool gameContinue = true;
            while (gameContinue)
            {
                Console.WriteLine($"TURNO DE {name}");
                int humanGuess = _HumanPlayer.MakeGuess();
                if (CheckGuess( humanGuess, RandomNumber))
                {
                    gameContinue = false;
                }
                else
                {
                    Console.WriteLine("TURNO DE System");
                    int aiGuess = _AIPlayer.MakeGuess();
                    if (CheckGuess( aiGuess, RandomNumber ))
                    {
                        gameContinue = false;
                    }
                }
            }
        }
    }
} 