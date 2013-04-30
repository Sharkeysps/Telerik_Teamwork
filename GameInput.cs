using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Game input in separate static class-game variables input is here
/// </summary>
static class GameInput
{
    public static int InputVariables(int[,] arr, int n)
    {
        int x = 0, y = 0;
        bool cond = true;
        while (cond) //check input
        {
            Console.Write("Please enter coordinates: ");
            string s = Console.ReadLine();
            if (s.Length > 2)
            {
                x = s.ElementAt(0) - '0';
                y = s.ElementAt(2) - '0';
                if (x < 0 || x > 9 || y < 0 || y > 9 || s.ElementAt(1) != ' ')
                    Console.WriteLine("Invalid move!");
                else
                {
                    if (s.Length > 3)
                    {
                        if (s.ElementAt(3) != ' ')
                            Console.WriteLine("Invalid move!");
                        else
                            cond = false;
                    }
                    else
                        cond = false;
                }
            }
            else
                Console.WriteLine("Invalid move!");
            if (cond == false)
                if (arr[x, y] <= 0)
                {
                    cond = true;
                    Console.WriteLine("Invalid move!");
                }
        }
        return MinesExplosion.CheckForExplosion(arr, n, x, y);
    }
}