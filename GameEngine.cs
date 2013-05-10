using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class GameEngine
{
    public static void InputFieldSize()
    {
        int fieldSize = 10;
        Console.WriteLine("Welcome to \"Battle Field\" game.");
        Console.Write("Enter battle field size: ");
        int.TryParse(Console.ReadLine(), out fieldSize);
        while (fieldSize < 1 || fieldSize > 10)
        {
            Console.Write("Field size must be between 1 and 10! Please enter new size: ");
            int.TryParse(Console.ReadLine(), out fieldSize);
        }
        InitiateGame(fieldSize);
    }

    private static int RandomGenerator(int startRange, int endRange)
    {
        Random randomNumber = new Random(); //vhoid i inicializaciq na n i matricata;
        int result = randomNumber.Next(startRange, endRange);
        return result;
    }

    private static int[,] GameFieldCreation(int fieldSize, int mineNumber)
    {
        int[,] gameField = new int[fieldSize, fieldSize];
        for (int i = 0; i < mineNumber; i++) // randomizirane na minite i postavqneto im iz poleto
        {
            int x = RandomGenerator(0, fieldSize);
            int y = RandomGenerator(0, fieldSize);
            while (gameField[x, y] != 0)
            {
                x = RandomGenerator(0, fieldSize);
                y = RandomGenerator(0, fieldSize);
            }
            gameField[x, y] = RandomGenerator(1, 6);
        }
        return gameField;
    }

    private static void InitiateGame(int fieldSize)
    {
        int mineNumber = RandomGenerator(15 * fieldSize * fieldSize / 100, 30 * fieldSize * fieldSize / 100 + 1);
        int[,] gameField = new int[fieldSize, fieldSize];
        gameField = GameFieldCreation(fieldSize, mineNumber);
        PrintGameField.PrintField(gameField, fieldSize);
        CheckForVictory(mineNumber, gameField, fieldSize);

    }
    private static void CheckForVictory(int mineNumber, int[,] gameField, int fieldSize)
    {
        int totalNumberOfMoves = 0;
        while (mineNumber > 0)
        {
            int tmp = GameInput.InputVariables(gameField, fieldSize);
            mineNumber -= tmp;
            PrintGameField.PrintField(gameField, fieldSize);
            //Console.WriteLine("Mines Blowed this round: {0}",tmp);
            totalNumberOfMoves++;
        }
        Console.WriteLine("Total number of moves：{0}", totalNumberOfMoves);
    }
}