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

        [Test]
        public void TestIsAvailable()
        {
            // 1. Arrange:
            Logic logic = new Logic();
            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[1][1] = "O";
            // 3. Assert:
            Assert.IsTrue(logic.IsAvailable(2, 2));
            Assert.IsFalse(logic.IsAvailable(1, 1));
            Assert.IsFalse(logic.IsAvailable(0, 0));
        }
        #endregion

        #region hjalli
        #endregion

        #region petur
        #endregion

        #region snorri
        #endregion
    }
}
