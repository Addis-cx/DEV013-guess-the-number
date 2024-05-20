using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;

namespace GuessTheNumber
{
    public class Game
    {
        private int RandomNumber;
        private readonly Player _AIPlayer;
        private readonly Player _HumanPlayer;

        public Game( string? name )
        {
            RandomNumberGenerator();
            _AIPlayer = new AIPlayer();
            _HumanPlayer = new HumanPlayer();
        }
        private void RandomNumberGenerator()
        {
            RandomNumber = new Random().Next(0, 101);
        }
        public bool CheckGuess( int guess, int targetNumber )
        {
            Thread.Sleep(500);
            if ( guess > targetNumber )
            {
                Console.WriteLine("¡Too High!");
                return false;
            }
            else if ( guess < targetNumber )
            {
                Console.WriteLine("¡Too Low!");
                return false;
            }
            else
            {
                Console.WriteLine("¡YOU WIN!");
                return true;
            }
        }
        public void StartGame(string? name)
        {
            Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine($"BIENVENIDAS AL JUEGO DE ADIVINAR NÚMEROS");

            bool gameContinue = true;
            while (gameContinue)
            {
                Console.WriteLine("");
                Console.WriteLine($"TURNO DE {name}");
                int humanGuess = _HumanPlayer.MakeGuess();
                if (CheckGuess( humanGuess, RandomNumber))
                {
                    gameContinue = false;
                }
                else
                {
                    Console.WriteLine("");
                    Thread.Sleep(500);
                    Console.WriteLine("TURNO DE System");
                    Thread.Sleep(500);
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