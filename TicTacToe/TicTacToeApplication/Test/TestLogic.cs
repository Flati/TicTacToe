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
		[Test]
		public void TestMarkMatrix()
		{
			// 1. Arrange:
			Logic logic = new Logic();
			int x1 = 1, y1 = 2;
			int x2 = 2, y2 = 1;

			// 2. Act:
			logic.MarkMatrix(x1, y1);
            logic.currentPlayer = Global.PLAYER2;
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

		[Test]
		public void TestTie()
		{
			// 1. Arrange:
			Logic logic = new Logic();
			
			// 2. Act.

			// 3. Assert:
			Assert.IsFalse(logic.Tie() );

			// 2. Act.
			logic.moveCounter = 9;

			// 3. Assert:
			Assert.IsTrue(logic.Tie() );
		}

        #endregion

        #region flati
        [Test]
        /*********************************************************************
        * This function tests if the constructor initializes the dataReader
        * variable.
        *********************************************************************/
        public void TestDataReader()
        {
            // 1. Arrange:
            Logic logic = new Logic();
            // 2. Act:

            // 3. Assert:
            Assert.IsNotNull(logic.dataReader);
        }

        [Test]
        /*********************************************************************
        * This function tests if the constructor initializes the moveCounter
        * variable.
        *********************************************************************/
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
        /*********************************************************************
        * This function tests if the IsAvailable function will return a correct
        * value for any situation.
        *********************************************************************/
        public void TestIsAvailable()
        {
            // 1. Arrange:
            Logic logic = new Logic();
            // 2. Act:
            logic.matrix[0][0] = Global.PLAYER1;
            logic.matrix[1][1] = Global.PLAYER2;
            // 3. Assert:
            Assert.IsTrue(logic.IsAvailable(2, 2));
            Assert.IsFalse(logic.IsAvailable(1, 1));
            Assert.IsFalse(logic.IsAvailable(0, 0));
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

            // 4. Act Again:
            logic.ChangePlayers();

            // 5. Assert Again:
            Assert.AreEqual(logic.currentPlayer, Global.PLAYER1);
        }



        #endregion

        #region petur
        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * X X X
        * e e e
        * e e e
        *********************************************************************/
        public void TestIsWonInTopHorizonalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[0][1] = "X";
            logic.matrix[0][2] = "X";
           
            // 3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        /*********************************************************************
        * Test if isWon function returns true if:
        * e e e
        * X X X
        * e e e
        *********************************************************************/
        [Test]
        public void TestIsWonInMidHorizonalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[1][0] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[1][2] = "X";
            
            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e e e
        * e e e
        * X X X
        *********************************************************************/
        public void TestIsWonInBottomHorizonalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "X";
            logic.matrix[2][1] = "X";
            logic.matrix[2][2] = "X";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }


        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * X e e
        * X e e
        * X e e
        *********************************************************************/
        public void TestIsWonInLeftVerticalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[1][0] = "X";
            logic.matrix[2][0] = "X";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }


        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e X e
        * e X e
        * e X e
        *********************************************************************/
        public void TestIsWonInMidVerticalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[1][0] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[1][2] = "X";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        
        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e e X
        * e e X
        * e e X
        *********************************************************************/
        public void TestIsWonInRightVerticalPositionForX()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "X";
            logic.matrix[2][1] = "X";
            logic.matrix[2][2] = "X";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * X e e
        * e X e
        * e e X
        *********************************************************************/
        public void TestIsWonInDiagonalPositionForXTopLeftToBottomRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[2][2] = "X";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e e X
        * e X e
        * X e e
        *********************************************************************/
        public void TestIsWonInDiagonalPositionForXBottomLeftToTopRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][2] = "X";
            logic.matrix[1][1] = "X";
            logic.matrix[0][0] = "X";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }


        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * O O O
        * e e e
        * e e e
        *********************************************************************/
        public void TestIsWonInTopHorizonalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "O";
            logic.matrix[0][1] = "O";
            logic.matrix[0][2] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e e e
        * O O O
        * e e e
        *********************************************************************/
        public void TestIsWonInMidHorizonalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[1][0] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[1][2] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e e e
        * e e e
        * O O O
        *********************************************************************/
        public void TestIsWonInBottomHorizonalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "O";
            logic.matrix[2][1] = "O";
            logic.matrix[2][2] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * O e e
        * O e e
        * O e e
        *********************************************************************/
        public void TestIsWonInLeftVerticalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "O";
            logic.matrix[1][0] = "O";
            logic.matrix[2][0] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e O e
        * e O e
        * e O e
        *********************************************************************/
        public void TestIsWonInMidVerticalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[1][0] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[1][2] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e e O
        * e e O
        * e e O
        *********************************************************************/
        public void TestIsWonInRightVerticalPositionForO()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][0] = "O";
            logic.matrix[2][1] = "O";
            logic.matrix[2][2] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * O e e
        * e O e
        * e e O
        *********************************************************************/
        public void TestIsWonInDiagonalPositionForOTopLeftToBottomRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[2][2] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns true if:
        * e e O
        * e O e
        * O e e
        *********************************************************************/
        public void TestIsWonInDiagonalPositionForOBottomLeftToTopRight()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[2][2] = "O";
            logic.matrix[1][1] = "O";
            logic.matrix[0][0] = "O";

            //3. Assert:
            Assert.AreEqual(logic.IsWon(), true);
        }

        [Test]
        /*********************************************************************
        * Test if isWon function returns false if:
        * X O X
        * X O X     
        * O X O     
        *********************************************************************/
        public void TestIsWonForRandomGameWhereThereIsATie()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "X";
            logic.matrix[0][1] = "O";
            logic.matrix[0][2] = "X";
            logic.matrix[1][0] = "X";
            logic.matrix[1][1] = "O";
            logic.matrix[1][2] = "X";
            logic.matrix[2][0] = "O";
            logic.matrix[2][1] = "X";
            logic.matrix[2][2] = "O";

            // 3. Assert:
            Assert.AreEqual(logic.IsWon(), false);
        }


        /*********************************************************************
        * Test if isWon function false true if:
        * O X O
        * O X X     
        * X O X     
        *********************************************************************/
        public void TestIsWonForRandomGame2WhereThereIsATie()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "O";
            logic.matrix[0][1] = "X";
            logic.matrix[0][2] = "O";
            logic.matrix[1][0] = "O";
            logic.matrix[1][1] = "X";
            logic.matrix[1][2] = "O";
            logic.matrix[2][0] = "X";
            logic.matrix[2][1] = "O";
            logic.matrix[2][2] = "X";

            // 3. Assert:
            Assert.AreEqual(logic.IsWon(), false);
        }

        /*********************************************************************
        * Test if isWon function returns true if:
        * O O X
        * X O X     
        * X X O     
        *********************************************************************/
        public void TestIsWonForRandomGame3WhereThereIsATie()
        {
            // 1. Arrange:
            Logic logic = new Logic();

            // 2. Act:
            logic.matrix[0][0] = "O";
            logic.matrix[0][1] = "O";
            logic.matrix[0][2] = "X";
            logic.matrix[1][0] = "X";
            logic.matrix[1][1] = "O";
            logic.matrix[1][2] = "X";
            logic.matrix[2][0] = "X";
            logic.matrix[2][1] = "X";
            logic.matrix[2][2] = "O";

            // 3. Assert:
            Assert.AreEqual(logic.IsWon(), false);
        }


        #endregion

        #region snorri
        #endregion
    }
}
