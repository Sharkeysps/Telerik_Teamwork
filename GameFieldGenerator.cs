using System;
using System.Linq;

public static class GameFieldGenerator
{
    public static int[,] GameField { private set; get; }//Gamefield is visible to all
    public static int MinesNumber { private set; get; }
    
    public static void InputFieldSize()//User Input
    {
        Console.Write("Welcome to \"Battle Field\" game.");
        Console.Write("\nEnter battle field size: ");
        int fieldSize;
        int.TryParse(Console.ReadLine(), out fieldSize);
        while (fieldSize < 1 || fieldSize > 10)
        {
            Console.Write("Field size must be between 1 and 10! \nPlease enter new size: ");
            int.TryParse(Console.ReadLine(), out fieldSize);
        }
        GameFieldCreation(fieldSize);
    }

    private static int RandomGenerator(int startRange, int endRange)
    {
        Random randomNumber = new Random(); //vhoid i inicializaciq na n i matricata;
        int result = randomNumber.Next(startRange, endRange);
        return result;
    }

    private static void GameFieldCreation(int fieldSize)
    {
        int startRandomRange = (15 * fieldSize * fieldSize) / 100;
        int endRandomRange = (30 * fieldSize * fieldSize) / 100 + 1;
        MinesNumber = RandomGenerator(startRandomRange, endRandomRange);

        GameField = new int[fieldSize, fieldSize];
        for (int i = 0; i < MinesNumber; i++) // Randomizing the positions of the mines on the field
        {
            int x = RandomGenerator(0, fieldSize);
            int y = RandomGenerator(0, fieldSize);
            while (GameField[x, y] != 0)
            {
                x = RandomGenerator(0, fieldSize);
                y = RandomGenerator(0, fieldSize);
            }
            GameField[x, y] = RandomGenerator(1, 6);
        }  
    }
}
