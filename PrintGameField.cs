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
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}|", i);
            for (int j = 0; j < n; j++)
            {
                char c;
                switch (arr[i, j])
                {
                    case 0:
                        c = '-';
                        break;
                    case -1:
                        c = 'X';
                        break;
                    default:
                        c = (char)('0' + arr[i, j]);
                        break;
                }
                Console.Write("{0} ", c);
            }
            Console.WriteLine();
        }
    }
}