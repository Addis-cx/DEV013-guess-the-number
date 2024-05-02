using System;

namespace GuessTheNumber
{
    class Program
    {
        string inputName = "";

        static void Main(string[] args)
        {
        }

        public void StartProgram()
        {
             Console.WriteLine($"Bienvenida al juego de adivinar números");

             Player playerClass = new Player();
             Game gameClass = new Game();

             Console.WriteLine("Ingresa tu nombre: ");
             inputName = Console.ReadLine();
             if (!string.IsNullOrEmpty(inputName))
            {
                playerClass.SetUserName(inputName);
            }
            else
            {
                Console.WriteLine("Nombre inválido. Inténtalo de nuevo.");
        
            }
             playerClass.SetUserName(inputName);

             gameClass.StartGame();

        }
    }
}
 
