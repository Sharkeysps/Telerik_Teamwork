using System;
using System.Linq;

/// <summary>
/// Class for exploding the mines in brutal fashion.Class also checks the type of explosions
/// </summary>
internal static class MinesExplosion
{
    /// <summary>
    /// The method stores the number of the nearby mines in destroyedNearMinesCount
    /// </summary>
    /// <param name="gameField">The game field size</param>
    /// <param name="mineRange">The range of the mine</param>
    /// <param name="xCoordinate"></param>
    /// <param name="yCoordinate"></param>
    /// <returns>int destroyedNearMinesCount - the </returns>
    public static int CheckForExplosion(int[,] gameField, int mineRange, int xCoordinate, int yCoordinate)
    {
        int[,] explosionDamageArea;
        //TODO make a new class for making the type of explosion
        explosionDamageArea = TypesOfExplosionsChoice.ExplosionChoice(gameField, xCoordinate, yCoordinate);

        int destroyedNearMinesCount = 0;

        for (int collumn = -2; collumn < 3; collumn++)
        {
            for (int row = -2; row < 3; row++)
            {
                bool isInsideBattleField = (xCoordinate + collumn >= 0 && xCoordinate + collumn < mineRange &&
                                            yCoordinate + row >= 0 && yCoordinate + row < mineRange);

                if (isInsideBattleField)
                    if (explosionDamageArea[collumn + 2, row + 2] == 1)
                    {
                        if (gameField[xCoordinate + collumn, yCoordinate + row] > 0)
                            destroyedNearMinesCount++;

                        gameField[xCoordinate + collumn, yCoordinate + row] = -1;
                    }
            }
        }

        return destroyedNearMinesCount;
    }
}