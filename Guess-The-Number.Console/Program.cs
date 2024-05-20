using System;
using System.Text;

namespace GuessTheNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Ingresa tu nombre: ");
            string? name = Console.ReadLine();
            //Instancia de la clase Game
             Game gameObject = new Game(name);
             //Llamo al metodo StartGame para comenzar el juego
             gameObject.StartGame(name);
        }
    }
}
 
