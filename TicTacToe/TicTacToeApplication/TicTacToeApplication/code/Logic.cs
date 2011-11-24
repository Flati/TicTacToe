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

        /*********************************************************************
        * This is a constructor. It initializes the matrix behind the
        * tictactoe, the moveCounter, the dataReader and currentPlayer.
        * INPUT: none.
        * OUTPUT: none.
        *********************************************************************/
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

        /*********************************************************************
        * This function marks the given spot in the matrix as taken.
        * It uses the currentPlayer variable to mark it with the correct symbol.
        * INPUT: x- and y-coordinates of type int.
        * OUTPUT: none.
        *********************************************************************/
        public void MarkMatrix(int x, int y)
		{
            matrix[x][y] = currentPlayer;
			moveCounter++;
		}

        /*********************************************************************
        * This function checks if the game has reached a tie.
        * INPUT: none.
        * OUTPUT: tie of type bool.
        *********************************************************************/
        public bool Tie()
		{
            if (moveCounter > 8)
            {
                dataReader.Winning("tie");
                return true;
            }
            return false;
		}

        /*********************************************************************
        * This function checks if the given index in the matrix is already
        * marked.
        * INPUT: x- and y-coordinates of type int.
        * OUTPUT: availability of type bool.
        *********************************************************************/
        public bool IsAvailable(int x, int y)
        {
            if (matrix[x][y] == "E")
                return true;
            return false;
        }

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

        /*********************************************************************
        * This function checks if either player has reached a winning position.
        * INPUT: none.
        * OUTPUT: isWon of type bool.
        *********************************************************************/
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
    }
}
