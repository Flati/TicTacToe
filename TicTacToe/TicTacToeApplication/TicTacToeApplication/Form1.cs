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
    public partial class Form1 : Form
    {
        private Logic logic;
        private Image cross;
        private Image circle;

        public Form1()
        {
            InitializeComponent();
            logic = new Logic();
            cross = Image.FromFile("..\\..\\Images\\kross.png");
            circle = Image.FromFile("..\\..\\Images\\hringur.png");
        }

        public void MarkField(Button field)
        {
            if (logic.currentPlayer == Global.PLAYER1)
                field.Image = cross;
            else
                field.Image = circle;
        }

        public void MarkMatrix(int x, int y)
        {
            logic.MarkMatrix(x, y);
            if (logic.IsWon() || logic.Tie())
            {
                //logic.WinScreen();
                Close();
            }
            logic.ChangePlayers();
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            if(logic.IsAvailable(0,0))
            {
                MarkField(TopLeft);
                MarkMatrix(0,0);
            }
        }

        private void TopCenter_Click(object sender, EventArgs e)
        {
            if(logic.IsAvailable(0,1))
            {
                MarkField(TopCenter);
                MarkMatrix(0,1);
            }
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            if(logic.IsAvailable(0,2))
            {
                MarkField(TopRight);
                MarkMatrix(0,2);
            }
        }

        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            if (logic.IsAvailable(1, 0))
            {
                MarkField(MiddleLeft);
                MarkMatrix(1, 0);
            }
        }

        private void MiddleCenter_Click(object sender, EventArgs e)
        {
            if (logic.IsAvailable(1, 1))
            {
                MarkField(MiddleCenter);
                MarkMatrix(1, 1);
            }
        }

        private void MiddleRight_Click(object sender, EventArgs e)
        {
            if (logic.IsAvailable(1, 2))
            {
                MarkField(MiddleRight);
                MarkMatrix(1, 2);
            }
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            if (logic.IsAvailable(2, 0))
            {
                MarkField(BottomLeft);
                MarkMatrix(2, 0);
            }
        }

        private void BottomCenter_Click(object sender, EventArgs e)
        {
            if (logic.IsAvailable(2, 1))
            {
                MarkField(BottomCenter);
                MarkMatrix(2, 1);
            }
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            if (logic.IsAvailable(2, 2))
            {
                MarkField(BottomRight);
                MarkMatrix(2, 2);
            }
        }
    }
}
