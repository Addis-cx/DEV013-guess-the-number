namespace GuessTheNumber
{
    class Game
    {
        private int randomNumber;

        public Game()
        {
        }
        public void StartGame( string? inputName )
        {
            Console.WriteLine($"Bienvenida al juego de adivinar números");
            Console.WriteLine("Ingresa tu nombre: ");

            inputName = Console.ReadLine();
        }
        private void RandomNumberGenerator()
        {
            randomNumber = new Random().Next(0, 101);
        }
        public void CheckGuess( int number, int randomNumber )
        {
            Player firstPlayer = new Player("Addis");

            number = 0;
            while ( number != randomNumber )
            {
                number = firstPlayer.MakeGuess( number );
                if ( number == randomNumber )
                {
                    Console.WriteLine("¡YOU WIN!");
                    break;
                }
            }
        }
    }
} 