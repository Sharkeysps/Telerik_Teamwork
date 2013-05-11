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
    private static void CheckForVictory(int minesNumber, int[,] gameField, int fieldSize)
    {
        int totalNumberOfMoves = 0;
        while (minesNumber > 0)
        {
            int tmp = GameInput.InputVariables(gameField, fieldSize);
            minesNumber -= tmp;
            PrintGameField.PrintField(gameField, fieldSize);
            //Console.WriteLine("Mines Blowed this round: {0}",tmp);
            totalNumberOfMoves++;
        }
        Console.WriteLine("Total number of moves：{0}", totalNumberOfMoves);
    }
}