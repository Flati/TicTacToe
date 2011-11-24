using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicTacToeApplication.code;

namespace TicTacToeApplication
{
    static class Program
    {
        /*********************************************************************
        * This is the main function of the application. It keeps running the
        * game until the user doesn't want to play anymore.
        *********************************************************************/
        [STAThread]
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                while (Global.PLAY_AGAIN)
                {
                    Application.Run(new Form1());
                    Application.Run(new StatisticsForm());
                }
            }
            else if (args[0] == "test")
                return 0;
            return 0;
        }
    }
}
