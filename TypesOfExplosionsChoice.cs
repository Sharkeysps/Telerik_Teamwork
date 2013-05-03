using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Putting the type of explosions and its choice in static class
/// </summary>
static class TypesOfExplosionsChoice
{
    static readonly int[,] mineOne =
    {
        { 0, 0, 0, 0, 0 },
        { 0, 1, 0, 1, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 1, 0, 1, 0 },
        { 0, 0, 0, 0, 0 }
    };
    static readonly int[,] mineTwo =
    {
        { 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 0 },
        { 0, 1, 1, 1, 0 },
        { 0, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0 }
    };
    static readonly int[,] minrThree =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 1, 0 },
        { 1, 1, 1, 1, 1 },
        { 0, 1, 1, 1, 0 },
        { 0, 0, 1, 0, 0 }
    };
    static readonly int[,] mineFour =
    {
        { 0, 1, 1, 1, 0 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 0, 1, 1, 1, 0 }
    };
    static readonly int[,] mineFive =
    {
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 }
    };

    public static int[,] ExplosionChoice(int[,] arr, int x, int y)
    {
        switch (arr[x, y]) // zadava ni koi vid bomba imame
        {
            case 1:
                return mineOne;
            case 2:
                return mineTwo; 
            case 3:
                return minrThree; 
            case 4:
                return mineFour; 
            default:
                return mineFive;
        }
    }
}