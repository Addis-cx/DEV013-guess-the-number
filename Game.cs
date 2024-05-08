        using System;

        namespace GuessTheNumber
        {
            class Game
            {
                private int randomNumber;

                public Game()
                {
                }
                public void StartGame()
                {
                    randomNumber = new Random().Next(0, 100);

                }
            }
        }