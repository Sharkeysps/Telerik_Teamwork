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
        // [ExpectedException(typeof(NullReferenceException))]
        public void TestUserInputOutsideOfField()
        {

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("10{0}5 5{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    GameBoardGenerator.GetBoardSize();
                    GameInput.ManageUserInput(GameBoardGenerator.GameField);
                }
            }
        }

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
                    Assert.IsTrue(GameInput.ColCoordinate==5 && GameInput.RowCoordinate==5);
                }
            }
        }


       
    }
}