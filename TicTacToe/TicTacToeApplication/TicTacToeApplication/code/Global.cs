using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeApplication.code
{
    /*********************************************************************
    * This is a global class that contains the variables we need to use
    * in many classes or in different forms. It's the only way to pass
    * information between forms. It would be very redundant to pass the
    * information we need between classes as parameters for every instance.
    *********************************************************************/
    public class Global
    {
        /*********************************************************************
        * This is a global variable that contains the string for player 1.
        *********************************************************************/
        public static string PLAYER1 = "X";

        /*********************************************************************
        * This is a global variable that contains the string for player 2.
        *********************************************************************/
        public static string PLAYER2 = "O";

        /*********************************************************************
        * This is a global variable that contains the string for the winner.
        *********************************************************************/
        public static string WINNER = "There's no winner.";

        /*********************************************************************
        * This is a global variable that contains the number of player 1 wins.
        *********************************************************************/
        public static int PLAYER1WIN;

        /*********************************************************************
        * This is a global variable that contains the number of player 2 wins.
        *********************************************************************/
        public static int PLAYER2WIN;

        /*********************************************************************
        * This is a global variable that contains the number of ties.
        *********************************************************************/
        public static int TIENUMBER;

        /*********************************************************************
        * This is a global variable that contains the answer from the user
        * if he would like to play again.
        *********************************************************************/
        public static bool PLAY_AGAIN = true;
    }
}
