using System;

namespace GuessTheNumber
{
    class Program
    {

        static void Main(string[] args)
        {
             string? inputName;
             
             Game gameClass = new Game();
             Player playerClass = new Player();

             Console.WriteLine($"Bienvenida al juego de adivinar números");
             Console.WriteLine("Ingresa tu nombre: ");

             inputName = Console.ReadLine();

             gameClass.StartGame(10);
        }
    }
}
 
