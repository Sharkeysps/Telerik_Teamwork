using System;
using System.Linq;
using System.Text;

/// <summary>
/// Made a static class Printgamefield with static method Printfield from class Battlefield
/// </summary>
static class PrintGameField
{
    public static void PrintField(int[,] arr, int n)
    {
        StringBuilder buffer = new StringBuilder();
        // Prints first row
        buffer.Append(" ");
        for (int i = 0; i < n; i++)
        {
            buffer.Append(" " + i);
        }
        buffer.AppendLine();

        // Prints second row
        buffer.Append("  ");
        for (int i = 0; i < n * 2; i++)
        {
            buffer.Append("-");
        }

        // Prints the game field.
        buffer.AppendLine();
        for (int row = 0; row < n; row++)
        {
            buffer.Append(row);
            buffer.Append("|");
            for (int col = 0; col < n; col++)
            {
                char currentCharacter;
                switch (arr[row, col])
                {
                    case 0:
                        currentCharacter = '-';
                        break;
                    case -1:
                        currentCharacter = 'X';
                        break;
                    default:
                        currentCharacter = (char)('0' + arr[row, col]);
                        break;
                }
                buffer.Append(currentCharacter);
                buffer.Append(" ");
            }
            buffer.AppendLine();
        }
        Console.Write(buffer.ToString());
    }
}