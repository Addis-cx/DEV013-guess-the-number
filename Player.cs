using System;

namespace GuessTheNumber
{
    class Player
    {
        string userName;
        int lastNumber;

        public void StartPlayer()
        {
        }

        public void SetUserName(string name)
        {
            userName = name;
        }
        public void SetLastNumber(int number)
        {
            lastNumber = number;
        }

        public string GetUserName()
        {
            return userName;
        }
        public int GetLastNumber()
        {
            return lastNumber;
        }
    }
}