namespace GuessTheNumber
{
    class Player
    {
        //propiedades que caracterizan el objeto
        public string? UserName;
        private int LastGuess;
        //propiedades que caracterizan el objeto

        //constructor
        public Player()
        {
        }
        public Player(string name)
        {
            UserName = name;
            LastGuess = 0;
        }
        //funcion
        public int MakeGuess()
        {
            Console.WriteLine("Ingresa tu número: ");
            LastGuess = Convert.ToInt32(Console.ReadLine());
            return LastGuess;
        }
        public int GetLastGuess()
        {
            return LastGuess;
        }
    }
}