using System;
using System.Linq;

public static class GameEngine
{
    public static void InitiateGame()
    {
        GameFieldGenerator.InputFieldSize();
        
        PrintGameField.PrintField(GameFieldGenerator.GameField, 
            GameFieldGenerator.GameField.GetLength(0));

        CheckForVictory(GameFieldGenerator.MinesNumber, 
            GameFieldGenerator.GameField, 
            GameFieldGenerator.GameField.GetLength(0));

    }

    {
        int totalNumberOfMoves = 0;

        while (totalMinesNumber > 0)
        {
            int blownMinesThisRound = GameInput.InputVariables(gameField, fieldSize);
            totalMinesNumber -= blownMinesThisRound;
            PrintGameField.PrintField(gameField, fieldSize);
            Console.WriteLine("Mines Blowed this round: {0}",blownMinesThisRound);
            totalNumberOfMoves++;
        }

        Console.WriteLine("Congratulations you won the game in {0} moves", totalNumberOfMoves);
    }
}