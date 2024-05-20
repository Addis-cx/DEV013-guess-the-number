using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber;
using System;

namespace GuessTheNumber.Test;

[TestClass] //Especifica que esta clase es para test 
public class GameTest
{
    [TestMethod]
    public void CheckGuessTest_TooHigh_ReturnsFalse()
    {
        var game = new Game("Addis");
        int targetNumber = 15;
        int guess = 10; 

        bool resultTooHigh = game.CheckGuess( guess, targetNumber );

        Assert.IsFalse( resultTooHigh );
    }
    [TestMethod]
    public void CheckGuessTest_TooLow_ReturnsFalse()
    {
        var game = new Game("Addis");
        int targetNumber = 10;
        int guess = 15; 

        bool resultTooLow = game.CheckGuess( guess, targetNumber );

        Assert.IsFalse( resultTooLow );
    }
    [TestMethod]
    public void CheckGuessTest_YOUWIN_ReturnsTrue()
    {
        var game = new Game("Addis");
        int targetNumber = 15;
        int guess = 15; 

        bool resultYOUWIN = game.CheckGuess( guess, targetNumber );

        Assert.IsTrue( resultYOUWIN );
    }
}