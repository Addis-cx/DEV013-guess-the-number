using System;

namespace GuessTheNumber
{
    class Player
    {
        string? userName;
        int lastNumber;
        
        public string? UserName
        {
             set { userName = value; }
             get { return userName; }
        }
        public void StartPlayer()
        {
        }
        public int LastNumber
        {
             set { lastNumber = value; }
             get { return lastNumber; }
        }
    }
}