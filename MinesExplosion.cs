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
        for (int row = -2; row < 3; row++)
        {
            for (int collumn = -2; collumn < 3; collumn++)
            {
                if (xCoordinate + row >= 0 && xCoordinate + row < bombPower && yCoordinate + collumn >= 0 && yCoordinate + collumn < bombPower)
                {
                    if (explosionDamageArea[row + 2, collumn + 2] == 1)
                    {
                        if (gameField[xCoordinate + row, yCoordinate + collumn] > 0)
                            counter++;
                        gameField[xCoordinate + row, yCoordinate + collumn] = -1;
                    }
                }
            }
        }
        return counter;
    }
}