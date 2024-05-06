using System;

namespace GuessTheNumber
{
    class Program
    {

        static void Main(string[] args)
        {
             string? inputName;
             Player jugadorSimple = new Player();
             Player jugadorConPropiedades = new Player("addis");
             bool result = jugadorConPropiedades.MakeGuess(10);
             

             Console.WriteLine(jugadorSimple.userName);
             Console.WriteLine(jugadorConPropiedades.userName);
             Console.WriteLine(result);
            //  Game gameClass = new Game();

            //  Console.WriteLine($"Bienvenida al juego de adivinar números");
            //  Console.WriteLine("Ingresa tu nombre: ");

            //  inputName = Console.ReadLine();
    
            //  playerClass.UserName = inputName;

            //  gameClass.StartGame();
        }
    }
}
 
