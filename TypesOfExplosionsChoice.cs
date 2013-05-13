using System;
using System.Linq;

/// <summary>
/// Putting the type of explosions and its choice in static class
/// </summary>
static class TypesOfExplosionsChoice
{
    static readonly int[,] explosionLevelOne =
    {
        { 0, 0, 0, 0, 0 },
        { 0, 1, 0, 1, 0 },
        { 0, 0, 1, 0, 0 },
        { 0, 1, 0, 1, 0 },
        { 0, 0, 0, 0, 0 }
    };
    static readonly int[,] explosionLevelTwo =
    {
        { 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 0 },
        { 0, 1, 1, 1, 0 },
        { 0, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0 }
    };
    static readonly int[,] explosionLevelThree =
    {
        { 0, 0, 1, 0, 0 },
        { 0, 1, 1, 1, 0 },
        { 1, 1, 1, 1, 1 },
        { 0, 1, 1, 1, 0 },
        { 0, 0, 1, 0, 0 }
    };
    static readonly int[,] explosionLevelFour =
    {
        { 0, 1, 1, 1, 0 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 1 },
        { 0, 1, 1, 1, 0 }
    };
    static readonly int[,] explosionLevelFive =
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
                return explosionLevelOne;
            case 2:
                return explosionLevelTwo; 
            case 3:
                return explosionLevelThree; 
            case 4:
                return explosionLevelFour; 
            default:
                return explosionLevelFive;
        }
    }
}