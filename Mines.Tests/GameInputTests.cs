// ********************************
// <copyright file="GameInputTests.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
// ********************************

namespace Mines.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;

    [TestClass]
    public class GameInputTests
    {
        [TestMethod]
        public void TestUserInputCorrectCoordinates()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("10{0}5 5{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    GameBoardGenerator.GetBoardSize();
                    GameInput.ManageUserInput(GameBoardGenerator.GameField);
                    Assert.IsTrue(GameInput.ColCoordinate==5);
                    Assert.IsTrue(GameInput.RowCoordinate == 5);
                }
            }
        }

        [TestMethod]
        public void TestCorrectUserInputPromt()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("10{0}5 5{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    GameBoardGenerator.GetBoardSize();
                    GameInput.ManageUserInput(GameBoardGenerator.GameField);
                    string actualStringOutput = sw.ToString();
                    string expectedStringOutput = "Welcome to \"Battle Field\" game.\nEnter battle field size between 1 and 10:\n  Please enter coordinates:";
                    Assert.AreEqual(expectedStringOutput.Length,actualStringOutput.Length);
                }
            }
        }

        [TestMethod]
        public void TestInCorrectUserInputOutsideOfField()
        {
            //Problem-doesnt get to the console output that coordinates is outside field-all yours
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("5{0}8 8{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    GameBoardGenerator.GetBoardSize();
                    GameInput.ManageUserInput(GameBoardGenerator.GameField);
                    string actualStringOutput = sw.ToString();
                    string expectedStringOutput = "Welcome to \"Battle Field\" game.\nEnter battle field size between 1 and 10:\n  Please enter coordinates:";
                    Assert.AreEqual(expectedStringOutput.Length, actualStringOutput.Length);
                }
            }
        }
    }
}