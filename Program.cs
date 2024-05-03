using System;

namespace GuessTheNumber
{
    class Program
    {

        static void Main(string[] args)
        {
             string? inputName;
             Player playerClass = new Player();
             Game gameClass = new Game();

             Console.WriteLine($"Bienvenida al juego de adivinar números");
             Console.WriteLine("Ingresa tu nombre: ");

             inputName = Console.ReadLine();
    
             playerClass.UserName = inputName;

             gameClass.StartGame();
        }
    }
}
 
