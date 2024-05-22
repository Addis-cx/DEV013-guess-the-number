using System;
using System.Collections.Generic;
using System.Threading;

namespace GuessTheNumber
{
    // Clase principal del juego que contiene la lógica y estado del juego.
    public class Game
    {
        private int RandomNumber; //Almacena el numero que se debe adivinar 
        private readonly Player _AIPlayer; 
        private readonly Player _HumanPlayer;

        // Constructor que inicializa el número aleatorio y los jugadores.
        public Game( string? name )
        {
            RandomNumberGenerator(); // Genera un número aleatorio entre 0 y 100.
            _AIPlayer = new AIPlayer(); // Inicializa el jugador de IA.
            _HumanPlayer = new HumanPlayer(); // Inicializa el jugador humano.
        }
        // Método para generar un número aleatorio entre 0 y 100.
        private void RandomNumberGenerator()
        {
            RandomNumber = new Random().Next(0, 101); 
        }
        // Método que verifica si la suposición del jugador es correcta.
        public bool CheckGuess( int guess, int targetNumber )
        {
            Thread.Sleep(500); // Añade un retraso de 500 milisegundos para simular procesamiento.
            // Compara la suposición con el número objetivo y proporciona retroalimentación.
            if ( guess > targetNumber )
            {
                Console.WriteLine("¡Too High!"); // Informa que la suposición es demasiado alta.
                return false; // Retorna false, indicando que la suposición es incorrecta.
            }
            else if ( guess < targetNumber )
            {
                Console.WriteLine("¡Too Low!");
                return false;
            }
            else
            {
                Console.WriteLine("¡YOU WIN!"); // Informa que la suposición es correcta.
                return true; // Retorna true, indicando que la suposición es correcta.
            }
        }
        // Método que inicia y controla el flujo del juego.
        public void StartGame(string? name)
        {
            Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine($"BIENVENIDAS AL JUEGO DE ADIVINAR NÚMEROS");

            bool gameContinue = true; // Bandera para controlar el bucle del juego.
            // Bucle principal del juego que alterna entre los turnos del jugador humano y el de IA.
            while (gameContinue)
            {
                Console.WriteLine("");
                Console.WriteLine($"TURNO DE {name}"); // Informa de que es el turno del jugador humano.
                int humanGuess = _HumanPlayer.MakeGuess(); // Obtiene la suposición del jugador humano.
                if (CheckGuess( humanGuess, RandomNumber)) // Verifica la suposición del jugador humano.
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
                        gameContinue = false; // Si es correcta, termina el juego.
                    }
                }
            }
        }
    }
} 