using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToeApplication.code;

namespace TicTacToeApplication
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            if (Global.WINNER == Global.PLAYER1)
                WinnerMessage.Text = "Player 1 won this game!";
            else if (Global.WINNER == Global.PLAYER2)
                WinnerMessage.Text = "Player 2 won this game!";
            else
                WinnerMessage.Text = "The game resulted in a tie.";
            StatisticsMessage.Text = "History:\n\nPlayer 1: " + Global.PLAYER1WIN + " wins.\nPlayer 2: "
                                   + Global.PLAYER2WIN + " wins.\nTies: " + Global.TIENUMBER + " games.";
            WinnerMessage.Refresh();
            StatisticsMessage.Refresh();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Global.PLAY_AGAIN = true;
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Global.PLAY_AGAIN = false;
            Close();
        }
    }
}
