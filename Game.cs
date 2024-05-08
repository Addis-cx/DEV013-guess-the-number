        using System;

        namespace GuessTheNumber
        {
            class Game
            {
                private int randomNumber;

                public Game()
                {
                }
                public void StartGame( int number )
                {
                    randomNumber = new Random().Next(0, 101);
                    Player firstPlayer = new Player("Addis");
                    bool resultPlayer = firstPlayer.MakeGuess(10);

                    number = 0;
                    while ( number != randomNumber )
                    {
                        firstPlayer.MakeGuess( number );
                        if ( number == randomNumber )
                        {
                            Console.WriteLine("¡YOU WIN!");
                        }
                    }
                }
            }
        }