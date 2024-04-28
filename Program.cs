using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
             string userName = "";
             
             Console.WriteLine("Ingresa tu nombre...");
             userName = Console.ReadLine();
             Console.WriteLine($"Hola {userName}, bienvenida al juego de adivinar números");

             Game game = new Game();
             game.startGame();
        }
    }
}
 
