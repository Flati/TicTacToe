using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicTacToeApplication.code;

namespace TicTacToeApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (Global.PLAY_AGAIN)
            {
                Application.Run(new Form1());
                Application.Run(new StatisticsForm());
            }
        }
    }
}
