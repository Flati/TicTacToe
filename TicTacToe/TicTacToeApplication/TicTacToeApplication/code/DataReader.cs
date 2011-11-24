using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TicTacToeApplication.code
{
    public class DataReader
    {
        public string path = "ProgressLog.txt";

        /*********************************************************************
        * This is a constructor. It reads the ProgressLog and initializes the
        * global variables for statistics.
        * INPUT: none.
        * OUTPUT: none.
        *********************************************************************/
        public DataReader()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Global.PLAYER1WIN = int.Parse(sr.ReadLine());
                    Global.PLAYER2WIN = int.Parse(sr.ReadLine());
                    Global.TIENUMBER = int.Parse(sr.ReadLine());
                }
            }
            else
            {
                Global.PLAYER1WIN = 0;
                Global.PLAYER2WIN = 0;
                Global.TIENUMBER = 0;
            }
        }

        /*********************************************************************
        * This is a function that changes the global variables for statistics
        * according to the winner. It then writes the result into the "DataBase".
        * INPUT: winner of type string.
        * OUTPUT: none.
        *********************************************************************/
        public void Winning(string winner)
        {
            Global.WINNER = winner;
            if (winner == Global.PLAYER1)
                Global.PLAYER1WIN++;
            else if (winner == Global.PLAYER2)
                Global.PLAYER2WIN++;
            else
                Global.TIENUMBER++;
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(Global.PLAYER1WIN);
                sw.WriteLine(Global.PLAYER2WIN);
                sw.WriteLine(Global.TIENUMBER);
            }
        }
    }
}
