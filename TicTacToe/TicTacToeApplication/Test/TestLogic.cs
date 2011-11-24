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
		[Test]
		public void TestMarkMatrix()
		{
			// 1. Arrange:
			Global.PLAYER1 = "Siggi";
			Global.PLAYER2 = "Gunnar";
			Logic logic = new Logic();
			int x1 = 1, y1 = 2;
			int x2 = 2, y2 = 1;

			// 2. Act:
			logic.MarkMatrix(x1, y1);
			logic.MarkMatrix(x2, y2);

			// 3. Assert:
			Assert.AreEqual(logic.matrix[x1][y1], "X");
			Assert.AreEqual(logic.matrix[x2][y2], "O");
			Assert.AreEqual(logic.moveCounter, 2);
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if( !( i == x1 || i == x2 || j == y1 || j == y2) )
					{
						Assert.AreEqual(logic.matrix[i][j], "E");
					}
				}
			}

		}
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
        
        [Test]
        /*********************************************************************
        * This function will test if the current player is player number 1
        * after you initialize the "Logic" class.
        *********************************************************************/
        public void TestCurrentPlayer()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:

            // 3. Assert:
            Assert.AreEqual(logic.currentPlayer, Global.PLAYER1);
        }

        [Test]
        /*********************************************************************
        * This function will test the "ChangePlayers" function and see
        * if you have the other player after running it.
        *********************************************************************/
        public void TestChangePlayer()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.ChangePlayers();

            // 3. Assert:
            Assert.AreEqual(logic.currentPlayer, Global.PLAYER2);
        }



        #endregion

        #region petur
        #endregion

        #region snorri
        #endregion
    }
}
