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
<<<<<<< HEAD

    private static void CheckForVictory(int minesNumber, int[,] gameField, int fieldSize)
=======
    private static void CheckForVictory(int totalMinesNumber,int[,] gameField,int fieldSize)
>>>>>>> 8968706681f39704699aa6d04f58a0255932f30c
    {
        int totalNumberOfMoves = 0;
        while (minesNumber > 0)
        {
<<<<<<< HEAD
            int tmp = GameInput.ManageUserInput(gameField, fieldSize);
            minesNumber -= tmp;
=======
            int blownMinesThisRound = GameInput.ManageUserInput(gameField, fieldSize);
            totalMinesNumber -= blownMinesThisRound;
>>>>>>> 8968706681f39704699aa6d04f58a0255932f30c
            PrintGameField.PrintField(gameField, fieldSize);
            //Console.WriteLine("Mines Blowed this round: {0}",tmp);
            totalNumberOfMoves++;
        }
        Console.WriteLine("Total number of moves：{0}", totalNumberOfMoves);
    }
}