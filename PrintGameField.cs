using System;
using System.Linq;
using System.Text;

/// <summary>
/// Made a static class Printgamefield with static method Printfield from class Battlefield
/// </summary>
public static class PrintGameField
{
    /// <summary>
    /// Prints the game field.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <param name="matrixSize">Size of the matrix.</param>
    public static void PrintField(int[,] matrix, int matrixSize)
    {
        string buffer = GenerateField(matrix, matrixSize);
        Console.Write(buffer);
    }

    /// <summary>
    /// Generates the game field.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <param name="matrixSize">Size of the matrix.</param>
    /// <returns>The generated field.</returns>
    private static string GenerateField(int[,] matrix, int matrixSize)
    {
        StringBuilder buffer = new StringBuilder();
        // Prints first row
        buffer.Append(" ");
        for (int i = 0; i < matrixSize; i++)
        {
            buffer.Append(" " + i);
        }
        buffer.AppendLine();

        // Prints second row
        buffer.Append("  ");
        for (int i = 0; i < matrixSize * 2; i++)
        {
            buffer.Append("-");
        }

        // Prints the game field.
        buffer.AppendLine();
        for (int row = 0; row < matrixSize; row++)
        {
            buffer.Append(row);
            buffer.Append("|");
            for (int col = 0; col < matrixSize; col++)
            {
                char currentCharacter;
                switch (matrix[row, col])
                {
                    case 0:
                        currentCharacter = '-';
                        break;
                    case -1:
                        currentCharacter = 'X';
                        break;
                    default:
                        currentCharacter = (char)('0' + matrix[row, col]);
                        break;
                }
                buffer.Append(currentCharacter);
                buffer.Append(" ");
            }
            buffer.AppendLine();
        }
        return buffer.ToString();
    }
}