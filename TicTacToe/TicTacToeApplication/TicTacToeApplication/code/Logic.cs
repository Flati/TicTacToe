using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeApplication.code
{
    public class Logic
    {
        public List<List<string>> matrix;
        public string currentPlayer;
        public DataReader dataReader;
        public int moveCounter;

        public Logic()
        {
            moveCounter = 0;
            dataReader = new DataReader();
            currentPlayer = Global.PLAYER1;
            matrix = new List<List<string>>();
            for (int i = 0; i < 3; i++)
            {
                matrix.Add(new List<string>());
                for (int j = 0; j < 3; j++)
                {
                    matrix[i].Add("E");
                }
            }
        }
        #region palli
		public void MarkMatrix(int x, int y)
		{
			if (currentPlayer.Equals(Global.PLAYER1))
			{
				matrix[x][y] = "X";
				currentPlayer = Global.PLAYER2;
			}
			else
			{
				matrix[x][y] = "O";
				currentPlayer = Global.PLAYER1;
			}
			moveCounter++;
		}

		public bool Tie()
		{
			return true;
		}
        #endregion

        #region flati
        #endregion

        #region hjalli

        public void ChangePlayers()
        {
            if (currentPlayer == Global.PLAYER1)
                currentPlayer = Global.PLAYER2;
            else
                currentPlayer = Global.PLAYER1;
        }

        #endregion

        #region petur
        #endregion

        #region snorri
        #endregion
    }
}
