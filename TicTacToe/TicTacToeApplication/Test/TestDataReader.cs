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
        public void TestPlayer1Win()
        {
            // 1. Arrange:
            DataReader reader = new DataReader();
            int player1;
            int player2;
            int ties;
            if (File.Exists(reader.path))
            {
                using (StreamReader sr = new StreamReader(reader.path))
                {
                    player1 = int.Parse(sr.ReadLine());
                    player2 = int.Parse(sr.ReadLine());
                    ties = int.Parse(sr.ReadLine());
                }
            }
            else
            {
                player1 = 0;
                player2 = 0;
                ties = 0;
            }

            // 2. Act:
            reader.Winning(Global.PLAYER1);

            // 3. Assert:
            Assert.AreEqual(player1 + 1, Global.PLAYER1WIN);
            Assert.AreEqual(player2, Global.PLAYER2WIN);
            Assert.AreEqual(ties, Global.TIENUMBER);
        }

        [Test]
        public void TestPlayer2Win()
        {
            // 1. Arrange:
            DataReader reader = new DataReader();
            int player1;
            int player2;
            int ties;
            if (File.Exists(reader.path))
            {
                using (StreamReader sr = new StreamReader(reader.path))
                {
                    player1 = int.Parse(sr.ReadLine());
                    player2 = int.Parse(sr.ReadLine());
                    ties = int.Parse(sr.ReadLine());
                }
            }
            else
            {
                player1 = 0;
                player2 = 0;
                ties = 0;
            }

            // 2. Act:
            reader.Winning(Global.PLAYER2);

            // 3. Assert:
            Assert.AreEqual(player1, Global.PLAYER1WIN);
            Assert.AreEqual(player2 + 1, Global.PLAYER2WIN);
            Assert.AreEqual(ties, Global.TIENUMBER);
        }

        [Test]
        public void TestTie()
        {
            // 1. Arrange:
            DataReader reader = new DataReader();
            int player1;
            int player2;
            int ties;
            if (File.Exists(reader.path))
            {
                using (StreamReader sr = new StreamReader(reader.path))
                {
                    player1 = int.Parse(sr.ReadLine());
                    player2 = int.Parse(sr.ReadLine());
                    ties = int.Parse(sr.ReadLine());
                }
            }
            else
            {
                player1 = 0;
                player2 = 0;
                ties = 0;
            }

            // 2. Act:
            reader.Winning("tie");

            // 3. Assert:
            Assert.AreEqual(player1, Global.PLAYER1WIN);
            Assert.AreEqual(player2, Global.PLAYER2WIN);
            Assert.AreEqual(ties + 1, Global.TIENUMBER);
        }

        [Test]
        public void TestNoFileExists()
        {
            // 1. Arrange:
            DataReader reader = new DataReader();
            if (File.Exists(reader.path))
            {
                File.Delete(reader.path);
            }

            // 2. Act:
            reader.Winning(Global.PLAYER1);

            // 3. Assert:
            Assert.IsTrue(File.Exists(reader.path));
        }
    }
}
