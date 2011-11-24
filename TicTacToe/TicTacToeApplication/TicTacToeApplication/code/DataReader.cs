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

        public void Winning(string winner)
        {
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
