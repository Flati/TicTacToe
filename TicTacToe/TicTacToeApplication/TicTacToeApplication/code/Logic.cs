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
            matrix[x][y] = currentPlayer;
			moveCounter++;
		}

		public bool Tie()
		{
            if (moveCounter > 8)
            {
                dataReader.Winning("tie");
                return true;
            }
            return false;
		}
        #endregion

        #region flati
        /*********************************************************************
        * This function checks if the given index in the matrix is already
        * marked.
        *********************************************************************/
        public bool IsAvailable(int x, int y)
        {
            if (matrix[x][y] == "E")
                return true;
            return false;
        }
        #endregion

        #region hjalli
        /*********************************************************************
        * This function will change what player is active.
        * INPUT: none.
        * OUTPUT: none.
        *********************************************************************/
        public void ChangePlayers()
        {
            if (currentPlayer == Global.PLAYER1)
                currentPlayer = Global.PLAYER2;
            else
                currentPlayer = Global.PLAYER1;
        }

        #endregion

        #region petur
        public bool IsWon()
        {
            bool isWon = false;
            for (int i = 0; i < 3; i++)
            {
                if (matrix[i][0] == matrix[i][1] && matrix[i][0] == matrix[i][2])
                {
                    if (matrix[i][0] != "E")
                        isWon =  true;
                }
                else if (matrix[0][i] == matrix[1][i] && matrix[0][i] == matrix[2][i])
                {
                    if (matrix[0][i] != "E")
                        isWon =  true;
                }
            }
            if (matrix[0][0] == matrix[1][1] && matrix[0][0] == matrix[2][2])
            {
                if (matrix[0][0] != "E")
                    isWon = true;
            }
            else if (matrix[2][0] == matrix[1][1] && matrix[2][0] == matrix[0][2])
            {
                if (matrix[1][1] != "E")
                    isWon = true;
            }
            if (isWon)
            {
                dataReader.Winning(currentPlayer);
            }
            return isWon;
        }
        #endregion

        #region snorri
        #endregion
    }
}
