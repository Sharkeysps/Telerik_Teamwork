using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Putting the type of explosions and its choice in static class
/// </summary>
   static class TypesOfExplosionsChoice
    {
        static readonly int[,] минаЕдно = {{0,0,0,0,0},
                          {0,1,0,1,0},
                          {0,0,1,0,0},
                          {0,1,0,1,0},
                          {0,0,0,0,0}};
        static readonly int[,] минаДве =    {{0,0,0,0,0},
                            {0,1,1,1,0},
                            {0,1,1,1,0},
                            {0,1,1,1,0},
                            {0,0,0,0,0}};
        static readonly int[,] минаТри =    {{0,0,1,0,0},
                            {0,1,1,1,0},
                            {1,1,1,1,1},
                            {0,1,1,1,0},
                            {0,0,1,0,0}};
        static readonly int[,] минаЧетири =    {{0,1,1,1,0},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {0,1,1,1,0}};
        static readonly int[,] минаПет =    {{1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1}};
        public static int[,] ExplosionChoice(int[,] arr, int x, int y)
        {
            switch (arr[x, y]) // zadava ni koi vid bomba imame
            {
                case 1: return минаЕдно; break;
                case 2: return минаДве; break;
                case 3: return минаТри; break;
                case 4: return минаЧетири; break;
                default: return минаПет; break;
            }
        }
    }

