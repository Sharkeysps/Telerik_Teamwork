using System;
using System.Linq;

/// <summary>
/// Class for exploding the mines in brutal fashion.Class also checks the type of explosions
/// </summary>
static class MinesExplosion
{
    public static int CheckForExplosion(int[,] gameField, int bombPower, int x, int y)
    {
        int[,] explosionDamageArea;
        //TODO make a new class for making the type of explosion
        explosionDamageArea = TypesOfExplosionsChoice.ExplosionChoice(gameField, x, y);
        //gyrmi bombata
        int counter = 0;
        for (int row = -2; row < 3; row++)
        {
            for (int collumn = -2; collumn < 3; collumn++)
            {
                if (x + row >= 0 && x + row < bombPower && y + collumn >= 0 && y + collumn < bombPower)
                {
                    if (explosionDamageArea[row + 2, collumn + 2] == 1)
                    {
                        if (gameField[x + row, y + collumn] > 0)
                            counter++;
                        gameField[x + row, y + collumn] = -1;
                    }
                }
            }
        }
        return counter;
    }
}