using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    //Clase abstracta para representar un jugador general
    abstract class Player
    {
        //propiedades que caracterizan el objeto
        public string? UserName; //Nombre del jugador
        public List<int> Guesses; //Lista de intentos 

        public Player(string name)
        {
            UserName = name;
            Guesses = new List<int>(); //Inicialice la lista de intentos 
        }
        //Método abstracto para que las clases heredadas la adapten segun las necesidades
        public abstract int MakeGuess();
    }
}