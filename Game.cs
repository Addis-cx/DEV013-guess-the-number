using System;

namespace GuessTheNumber
{
    class Game
    {
        int randomNumber;
        int numberUser;
        bool gameOver;

        public void startGame()
        {
            randomNumber = new Random().Next(0, 100);

            Console.WriteLine("Ingresa el número aquí");
            if (!int.TryParse(Console.ReadLine(), out numberUser))
            {
                Console.WriteLine("Error... Inresa un número válido");
                return;
            }
            gameOver = false;

            if (numberUser > randomNumber)
            {
                Console.WriteLine("¡To High!");
            }
            else if (numberUser < randomNumber)
            {
                Console.WriteLine("¡To Low!");
            }
            else 
            {
                Console.WriteLine("¡You Win!");
            }
        }
    }
}