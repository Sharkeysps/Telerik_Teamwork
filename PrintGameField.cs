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
        Console.Write(" ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" {0}", i);
        }

        Console.WriteLine();
        Console.Write("  ");
        for (int i = 0; i < n * 2; i++)
        {
            Console.Write("-");
        }

        Console.WriteLine();
        for (int row = 0; row < n; row++)
        {
            Console.Write("{0}|", row);
            for (int col = 0; col < n; col++)
            {
                char c;
                switch (arr[row, col])
                {
                    case 0:
                        c = '-';
                        break;
                    case -1:
                        c = 'X';
                        break;
                    default:
                        c = (char)('0' + arr[row, col]);
                        break;
                }
                Console.Write("{0} ", c);
            }
            Console.WriteLine();
        }
    }
}