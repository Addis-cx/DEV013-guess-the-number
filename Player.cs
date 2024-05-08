using System;

namespace GuessTheNumber
{
    class Player
    {
        public string? userName;
        private int lastNumber;
        public int predicNumber;
        //propiedades que caracterizan el objeto

        //constructor
        public Player()
        {
        }
        public Player(string name)
        {
            userName = name;
            lastNumber = 0;
        }
        //funcion
        public bool MakeGuess( int randomNumber )
        {
            Console.WriteLine("Ingresa tu número: ");
            predicNumber = Convert.ToInt32(Console.ReadLine());

                    if (predicNumber > randomNumber)
                    {
                        Console.WriteLine("¡To High!");
                        return false;
                    }
                    else if (predicNumber < randomNumber)
                    {
                        Console.WriteLine("¡To Low!");
                        return false;
                    } 
                    else 
                    {
                        Console.WriteLine("¡YOU WIN!");
                        return true;
                    }
            
        }
    }
}