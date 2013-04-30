using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class GameEngine
{
    public static void InitiateGame()
    {
        int n = 10;
        Console.Write("Welcome to \"Battle Field\" game.\nEnter battle field size: n = ");
        int.TryParse(Console.ReadLine(), out n);
        while (n < 1 || n > 10)
        {
            Console.Write("n is between 1 and 10! Please enter new n = ");
            int.TryParse(Console.ReadLine(), out n);
        }
        int[,] arr = new int[n, n];
        Random ProizvolniChisla = new Random(); //vhoid i inicializaciq na n i matricata;
        int mineNumber = ProizvolniChisla.Next(15 * n * n / 100, 30 * n * n / 100 + 1);
        for (int i = 0; i < mineNumber; i++) // randomizirane na minite i postavqneto im iz poleto
        {
            int x = ProizvolniChisla.Next(0, n);
            int y = ProizvolniChisla.Next(0, n);
            while (arr[x, y] != 0)
            {
                x = ProizvolniChisla.Next(0, n);
                y = ProizvolniChisla.Next(0, n);
            }
            arr[x, y] = ProizvolniChisla.Next(1, 6);
        }
        PrintGameField.PrintField(arr, n);

        int 爆 = 0;
        while (mineNumber > 0)
        {
            int tmp = GameInput.InputVariables(arr, n);
            mineNumber -= tmp;
            PrintGameField.PrintField(arr, n);
            //Console.WriteLine("Mines Blowed this round: {0}",tmp);
            爆++;
        }
        Console.WriteLine("游戏结束。引爆地雷：{0}", 爆);
    }
}