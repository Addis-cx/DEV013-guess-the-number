using System;

namespace GuessTheNumber
{
    class Player
    {
        string inputName = "";
        int lastNumber;

        public void StartPlayer()
        {
        }

        public void SetUserName(string name)
        {
            inputName = name;
        }
        public void SetLastNumber(int number)
        {
            lastNumber = number;
        }

        public string GetUserName()
        {
            return inputName;
        }
        public int GetLastNumber()
        {
            return lastNumber;
        }
    }
}