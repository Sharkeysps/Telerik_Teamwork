using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Class for exploding the mines in brutal fashion.Class also checks the type of explosions
/// </summary>
    static class MinesExplosion
    {

        public static int CheckForExplosion(int[,] arr, int n, int x, int y)
        {
            int[,] expl;
            //TODO make a new class for making the type of explosion
            expl = TypesOfExplosionsChoice.ExplosionChoice(arr, x, y);
            //gyrmi bombata
            int counter = 0;
            for (int i = -2; i < 3; i++)
            {
                for (int j = -2; j < 3; j++)
                {
                    if (x + i >= 0 && x + i < n && y + j >= 0 && y + j < n)
                    {
                        if (expl[i + 2, j + 2] == 1)
                        {
                            if (arr[x + i, y + j] > 0) counter++;
                            arr[x + i, y + j] = -1;
                        }
                    }
                }
            }
            return counter;
        }
    }
