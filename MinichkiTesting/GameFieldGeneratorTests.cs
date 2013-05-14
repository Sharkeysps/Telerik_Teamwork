using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace MinichkiTesting
{
    [TestClass]
    public class GameFieldGeneratorTests
    {
        //TODO add test for checking input and correct values of fields after inpuy
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
                            "The game field is not yet created")]
        public void TestIfGameFieldIsEmptyWhenNotCalled()
        {

            Assert.AreEqual(GameFieldGenerator.GameField.Length, 0);
        }

        [TestMethod]
        public void TestIfMineNumberIsZeroWhenNotCalled()
        {
            Assert.AreEqual(GameFieldGenerator.MinesNumber, 0);
        }

        [TestMethod]
        public void TestIfCorrectNumbersOfMinesAreCreated()
        {
            PrivateType privateType = new PrivateType(typeof(GameFieldGenerator));
            var fieldSize = 1;
            int startRandomRange = ((15 * fieldSize * fieldSize) / 100)+1;
            int endRandomRange = ((30 * fieldSize * fieldSize) / 100) + 1;
            int randomCheck = (int)privateType.InvokeStatic("RandomGenerator",startRandomRange,endRandomRange);
            Assert.IsTrue(randomCheck >= 1);
        }

        [TestMethod]
        public void TestUserInputCorrectFieldSize()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using(StringReader sr=new StringReader(string.Format("5{0}",Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    GameFieldGenerator.InputFieldSize();
                    Assert.AreEqual(GameFieldGenerator.GameField.Length, 25);
                }
            }
        }

        [TestMethod]
        public void TestUserInputMinesNumberWithTen()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("10{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    GameFieldGenerator.InputFieldSize();
                    Assert.IsTrue(GameFieldGenerator.MinesNumber >= 15 && GameFieldGenerator.MinesNumber <= 31);
                }
            }
        }

        [TestMethod]
        public void TestUserInputMinesNumberWithOne()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("1{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    GameFieldGenerator.InputFieldSize();
                    Assert.IsTrue(GameFieldGenerator.MinesNumber >= 1);
                }
            }
        }
    }
}
