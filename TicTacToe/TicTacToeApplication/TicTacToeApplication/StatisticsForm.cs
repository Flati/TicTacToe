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
            if (Global.WINNER == "tie")
                WinnerMessage.Text = "The game resulted in a tie.";
            else
                WinnerMessage.Text = "Player " + Global.WINNER + " won this game!";
            StatisticsMessage.Text = "History:\n\nPlayer X wins: " + Global.PLAYER1WIN + "\nPlayer O wins: "
                                   + Global.PLAYER2WIN + "\nTied games: " + Global.TIENUMBER;
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
