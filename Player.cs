using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    //clase abstracta 
    abstract class Player(string name)
    {
        //propiedades que caracterizan el objeto
        public string? UserName = name;
        public List<int>;

        //método
        public abstract int MakeGuess();
    }
}