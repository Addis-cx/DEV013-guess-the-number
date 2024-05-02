using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine($"Bienvenida al juego de adivinar números");

             Player playerClass = new Player();
             Game gameClass = new Game();

             Console.WriteLine("Ingresa tu nombre: ");
             string playerName = Console.ReadLine();
             playerClass.SetUserName(playerName);

             gameClass.Game();
        }
    }
}
 
