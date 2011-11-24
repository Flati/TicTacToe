using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TicTacToeApplication.code;
using System.IO;

namespace Test
{
    [TestFixture]
    class TestDataReader
    {
        [Test]
        /*********************************************************************
        * This function tests if the number of player 1 wins increases by 1
        * when player 1 wins the game.
        *********************************************************************/
        public void TestPlayer1Win()
        {
            // 1. Arrange:
            DataReader reader = new DataReader();
            int player1 = Global.PLAYER1WIN;
            int player2 = Global.PLAYER2WIN;
            int ties = Global.TIENUMBER;

            // 2. Act:
            reader.Winning(Global.PLAYER1);

            // 3. Assert:
            Assert.AreEqual(player1 + 1, Global.PLAYER1WIN);
            Assert.AreEqual(player2, Global.PLAYER2WIN);
            Assert.AreEqual(ties, Global.TIENUMBER);
        }

        [Test]
        /*********************************************************************
        * This function tests if the number of player 2 wins increased by 1
        * when player 2 wins the game.
        *********************************************************************/
        public void TestPlayer2Win()
        {
            // 1. Arrange:
            DataReader reader = new DataReader();
            int player1 = Global.PLAYER1WIN;
            int player2 = Global.PLAYER2WIN;
            int ties = Global.TIENUMBER;

            // 2. Act:
            reader.Winning(Global.PLAYER2);

            // 3. Assert:
            Assert.AreEqual(player1, Global.PLAYER1WIN);
            Assert.AreEqual(player2 + 1, Global.PLAYER2WIN);
            Assert.AreEqual(ties, Global.TIENUMBER);
        }

        [Test]
        /*********************************************************************
        * This function tests if the number of ties wins increased by 1
        * when the game results in a tie.
        *********************************************************************/
        public void TestTie()
        {
            // 1. Arrange:
            DataReader reader = new DataReader();
            int player1 = Global.PLAYER1WIN;
            int player2 = Global.PLAYER2WIN;
            int ties = Global.TIENUMBER;

            // 2. Act:
            reader.Winning("tie");

            // 3. Assert:
            Assert.AreEqual(player1, Global.PLAYER1WIN);
            Assert.AreEqual(player2, Global.PLAYER2WIN);
            Assert.AreEqual(ties + 1, Global.TIENUMBER);
        }

        [Test]
        /*********************************************************************
        * This function tests if the file is created when no file is found.
        *********************************************************************/
        public void TestNoFileExists()
        {
            // 1. Arrange:
            if (File.Exists("ProgressLog.txt"))
            {
                File.Delete("ProgressLog.txt");
            }
            DataReader reader = new DataReader();

            // 2. Act:
            reader.Winning(Global.PLAYER1);

            // 3. Assert:
            Assert.IsTrue(File.Exists(reader.path));
        }
    }
}
