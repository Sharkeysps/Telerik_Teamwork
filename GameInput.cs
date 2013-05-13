using System;
using System.Linq;

/// <summary>
/// Game input in separate static class-game variables input is here
/// </summary>
static class GameInput
{
    /// <summary>
    /// ManageUserInput is asking the user to unput coordinates in the int[,] gameField and responds accordingly.
    /// </summary>
    /// <param name="gameField">The matrix representing the game field.</param>
    /// <param name="minePower">The parameter indentifying the power of the explosion.</param>
    public static int ManageUserInput(int[,] gameField, int minePower)
    {
        bool isSelectingNextCoordinates = true;
        int xCoordinate = 0, yCoordinate = 0;  // Reset the coordinates value .

        while (isSelectingNextCoordinates) //Checks if the user input is correct for every single coordinates choosen.
        {
            PromptUserForInput(); 

            string selectedCoordinates = ReadInput();
            
            if (selectedCoordinates.Length > 2)
            {
                xCoordinate = selectedCoordinates.ElementAt(0) - '0';
                yCoordinate = selectedCoordinates.ElementAt(2) - '0';

                if (xCoordinate < 0 || xCoordinate > 9 || yCoordinate < 0 || yCoordinate > 9 || !(char.IsWhiteSpace(selectedCoordinates, 1)))
                {
                    Console.WriteLine("Outside of BattleField Or no white space between selected coordinates!");
                }
                else
                {
                    if (selectedCoordinates.Length > 3)
                    {
                        if (!(char.IsWhiteSpace(selectedCoordinates, 2)))
                        {
                            Console.WriteLine("Choose x and y coordinates, seperated by white space in correct format [Example:2 5] and make shure they are inside the BattleField !");
                        }
                        else
                        {
                            isSelectingNextCoordinates = false;
                        }
                    }
                    else
                    {
                        isSelectingNextCoordinates = false;
                    }
                }
            }
            else
                Console.WriteLine("Choose x and y coordinates, seperated by white space in correct format [Example:2 5]");

            if (isSelectingNextCoordinates == false)
            {
                if (gameField[xCoordinate, yCoordinate] <= 0)
                {
                    isSelectingNextCoordinates = true;

                    Console.WriteLine("Empty Field! Choose another coordinates!");
                }
            }
        }

        return MinesExplosion.CheckForExplosion(gameField, minePower, xCoordinate, yCoordinate);
    }

    /// <summary>
    /// ReadInput Method passes the user input  to other methods coordinates.
    /// </summary>
    private static string ReadInput()
    {
        string selectedCoordinates = Console.ReadLine();
        return selectedCoordinates;
    }

    /// <summary>
    /// PromptUserForInput Method prompts the user to input coordinates of the BattleFied.
    /// </summary>
    private static void PromptUserForInput()
    {
        Console.Write("Please enter coordinates: "); 
    }
}