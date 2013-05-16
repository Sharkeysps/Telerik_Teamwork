// ********************************
// <copyright file="GameInput.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// ********************************

namespace Mines
{
    using System;
    using System.Linq;

    /// <summary>
    /// Game input in separate static class-game variables input is here
    /// </summary>
    public static class GameInput
    {
        /// <summary>
        /// ManageUserInput is asking the user to input coordinates in the int[,] gameField and responds accordingly.
        /// </summary>
        /// <param name="gameField">The matrix representing the game field.</param>
        /// <param name="gameFieldSize">The parameter identifying the power of the explosion.</param>
        /// <returns>Explosion state.</returns>
        public static int ManageUserInput(int[,] gameField)
        {
            // Reset the coordinates value.
            int gameFieldSize = gameField.GetLength(0);
            bool isSelectingNextCoordinates = true;
            int row = 0, col = 0;  

            // Checks if the user input is correct for every single coordinates choosen.
            while (isSelectingNextCoordinates) 
            {
                PromptUserForInput();

                string selectedCoordinates = ReadInput();

                if (selectedCoordinates.Length > 2)
                {
                    row = selectedCoordinates.ElementAt(0) - '0';
                    col = selectedCoordinates.ElementAt(2) - '0';

                    bool isOutsideBattleField = row < 0 || row > 9 || col < 0 || col > 9;
                    if (isOutsideBattleField || !char.IsWhiteSpace(selectedCoordinates, 1))
                    {
                        Console.WriteLine("Outside of BattleField Or no white space between selected coordinates!");
                    }
                    else
                    {
                        if (selectedCoordinates.Length > 3)
                        {
                            //          if (!(char.IsWhiteSpace(selectedCoordinates, 2)))
                            {
                                Console.WriteLine("Choose x and y coordinates, seperated by white space in correct format [Example:2 5] and make shure they are inside the BattleField !");
                            }

                            //          else
                            //         {
                            //               isSelectingNextCoordinates = false;
                            //        }
                        }
                        else
                        {
                            isSelectingNextCoordinates = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Choose x and y coordinates, seperated by white space in correct format [Example:2 5]");
                }

                if (isSelectingNextCoordinates == false)
                {
                    if (gameField[row, col] <= 0)
                    {
                        isSelectingNextCoordinates = true;

                        Console.WriteLine("Empty Field! Choose another coordinates!");
                    }
                }
            }

            return MinesExplosion.CheckForExplosion(gameField, row, col);
        }

        /// <summary>
        /// ReadInput Method passes the user input  to other methods coordinates.
        /// </summary>
        /// <returns>The coordinates.</returns>
        private static string ReadInput()
        {
            string selectedCoordinates = Console.ReadLine();
            return selectedCoordinates;
        }

        /// <summary>
        /// PromptUserForInput Method prompts the user to input coordinates of the BattleField.
        /// </summary>
        private static void PromptUserForInput()
        {
            Console.Write("Please enter coordinates: ");
        }
    }
}