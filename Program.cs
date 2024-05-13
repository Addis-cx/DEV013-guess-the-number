namespace GuessTheNumber
{
    class Program
    {

        static void Main(string[] args)
        {
             Game gameObject = new Game();
            //  Player playerOject = new Player();

             gameObject.StartGame();
             gameObject.CheckGuess(10, 20);
            //  playerOject.MakeGuess(10);
        }
    }
}
 
