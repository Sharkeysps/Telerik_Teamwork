using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Made a static class Printgamefield with static method Printfield from class Battlefield
/// </summary>
static class PrintGameField
{
    public static void PrintField(int[,] arr, int n)
    {
        // Prints first row
        Console.Write(" ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" {0}", i);
        }
        Console.WriteLine();

        // Prints second row
        Console.Write("  ");
        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("-");
        }

        // Prints the game field.
        Console.WriteLine();
        for (int row = 0; row < n; row++)
        {
            Console.Write("{0}|", row);
            for (int col = 0; col < n; col++)
            {
                char buffer;
                switch (arr[row, col])
                {
                    case 0:
                        buffer = '-';
                        break;
                    case -1:
                        buffer = 'X';
                        break;
                    default:
                        buffer = (char)('0' + arr[row, col]);
                        break;
                }
                Console.Write("{0} ", buffer);
            }
            Console.WriteLine();
        }
    }
}