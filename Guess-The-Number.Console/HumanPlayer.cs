using System;

namespace GuessTheNumber
{
     class HumanPlayer : Player //Clase HumanPlayer heredada de Player, con sus propiedades y métodos
    {
        public HumanPlayer() : base( "Addis" )  //Llama al constructor de la clase base Player con el nombre "Addis".
        {
        }

        //Sobrescribe el método MakeGuess() definido en la clase base Player, con override.
        public override int MakeGuess()
        {   
            //Este método solicita al jugador humano que ingrese un número.
            Console.Write( "Ingresa tu número: " ); //Lee la entrada del usuario desde la consola, la convierte a un entero y la asigna a la variable Guesses.
            int Guesses = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 se usa para convertir la entrada de texto en un número entero.
            return Guesses; //Devuelve el número ingresado por el jugador.
        }
    }
}