using System;

namespace GuessTheNumber
{
    class Game
    {
        int randomNumber;
        int numberUser;
        bool gameOver;

        public Game()
        {
            randomNumber = new Random().Next(0, 100);

            Console.WriteLine("Ingresa el número aquí");
            numberUser = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("¡YOU WIN!");
            }
        }
    }
}