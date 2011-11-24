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
        #endregion

        #region flati
        public bool IsAvailable(int x, int y)
        {
            if (matrix[x][y] == "E")
                return true;
            return false;
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
