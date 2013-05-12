using System;
using System.Linq;

public static class GameFieldGenerator
{
    private static int[,] gameField;
    private static int minesNumber;
    public static int[,] GameField 
    {
        get
        {
            if (gameField.Length == 0)
            {
                throw new NullReferenceException("The game field is not yet created");
            }
            else
            {
                return gameField;
            }
        }
    }
    public static int MinesNumber
    {
        get
        {
            if (minesNumber==0)
            {
                throw new NullReferenceException("The mines are not yet created");
            }
            else
            {
                return minesNumber;
            }
        }
    }
    
    public static void InputFieldSize()//User Input
    {
        Console.WriteLine("Welcome to \"Battle Field\" game.");
        Console.Write("Enter battle field size: ");

        int fieldSize;
        int.TryParse(Console.ReadLine(), out fieldSize);
        while (fieldSize < 1 || fieldSize > 10)
        {
            Console.WriteLine("Field size must be between 1 and 10!");
            Console.Write("Please enter new size: ");
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
        int endRandomRange = ((30 * fieldSize * fieldSize) / 100) + 1;
        minesNumber = RandomGenerator(startRandomRange, endRandomRange);

        gameField = new int[fieldSize, fieldSize];
        for (int i = 0; i < minesNumber; i++) // Randomizing the positions of the mines on the field
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
    }
}
