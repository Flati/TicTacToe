using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TicTacToeApplication.code;

namespace Test
{
    [TestFixture]
    public class TestLogic
    {
        [Test]
        public void TestMatrix()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            

            // 3. Assert:
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(logic.matrix[i][j],"E");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreNotEqual(logic.matrix[i][j], "Null");
                }
            }
        }
        #region palli
        #endregion

        #region flati
        [Test]
        public void TestDataReader()
        {
            // 1. Arrange:
            Logic logic = new Logic();
            // 2. Act:

            // 3. Assert:
            Assert.IsNotNull(logic.dataReader);
        }

        [Test]
        public void TestMoveCounter()
        {
            // 1. Arrange:
            Logic logic = new Logic();
            // 2. Act:

            // 3. Assert:
            Assert.IsNotNull(logic.moveCounter);
            Assert.AreEqual(logic.moveCounter, 0);
        }
        #endregion

        #region hjalli
        #endregion

        #region petur
        [Test]
        public void TestIsWonInTopHorizonalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[0][1] = "X";
            logic.matrix[0][2] = "X";
            logic.isWon();
           
            // 3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInMidHorizonalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.isWon();
            logic.matrix[1][0] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[1][2] = "X";
            logic.isWon();
            
            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInBottomHorizonalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "X";
            logic.matrix[2][1] = "X";
            logic.matrix[2][2] = "X";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInLeftVerticalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[1][0] = "X";
            logic.matrix[2][0] = "X";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInMidVerticalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[1][0] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[1][2] = "X";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInRightVerticalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "X";
            logic.matrix[2][1] = "X";
            logic.matrix[2][2] = "X";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInDiagonalPositionForXTopLeftToBottomRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[2][2] = "X";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInDiagonalPositionForXBottomLeftToTopRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][2] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[0][0] = "X";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInTopHorizonalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.isWon();
            logic.matrix[0][0] = "O";
            logic.matrix[0][1] = "O";
            logic.matrix[0][2] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }


        [Test]
        public void TestIsWonInMidHorizonalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.isWon();
            logic.matrix[1][0] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[1][2] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInBottomHorizonalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "O";
            logic.matrix[2][1] = "O";
            logic.matrix[2][2] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInLeftVerticalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "O";
            logic.matrix[1][0] = "O";
            logic.matrix[2][0] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInMidVerticalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[1][0] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[1][2] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInRightVerticalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "O";
            logic.matrix[2][1] = "O";
            logic.matrix[2][2] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInDiagonalPositionForOTopLeftToBottomRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[2][2] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonInDiagonalPositionForOBottomLeftToTopRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][2] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[0][0] = "O";
            logic.isWon();

            //3. Assert:
            Assert.AreEqual(logic.isWon(), true);
        }

        [Test]
        public void TestIsWonForTenRandomGamesWhereThereIsATie()
        {
            
        }

        #endregion

        #region snorri
        #endregion
    }
}
