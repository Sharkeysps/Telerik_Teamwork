using System;
using System.Linq;

/// <summary>
/// Class for exploding the mines in brutal fashion.Class also checks the type of explosions
/// </summary>
static class MinesExplosion
{
    public static int CheckForExplosion(int[,] gameField, int bombPower, int xCoordinate, int yCoordinate)
    {
        int[,] explosionDamageArea;
        //TODO make a new class for making the type of explosion
        explosionDamageArea = TypesOfExplosionsChoice.ExplosionChoice(gameField, xCoordinate, yCoordinate);
        //gyrmi bombata
        int counter = 0;
        for (int collumn = -2; collumn < 3; collumn++)
        {
            for (int row = -2; row < 3; row++)
            {
                if (xCoordinate + collumn >= 0 && xCoordinate + collumn < bombPower && yCoordinate + row >= 0 && yCoordinate + row < bombPower)
                {
                    if (explosionDamageArea[collumn + 2, row + 2] == 1)
                    {
                        if (gameField[xCoordinate + collumn, yCoordinate + row] > 0)
                            counter++;
                        gameField[xCoordinate + collumn, yCoordinate + row] = -1;
                    }
                }
            }
        }
        return counter;
    }
}