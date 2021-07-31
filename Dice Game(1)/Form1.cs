using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int Turn = 0, Score = 0;
            int Dice1 = 0, Dice2 = 0;
            while (Score != 20)
            {
                Random rnd = new Random();
                Dice1 = rnd.Next(1,20 );
                Dice2 = rnd.Next(1, 20);
                Score = Dice1 + Dice2;
                if (Turn == 0)
                {
                    textCurrentScore.Text += "Player One Score :" + Score + Environment.NewLine;
                    Turn = 1;
                }
                else
                {
                    textCurrentScore.Text += "Player Two Score :" + Score + Environment.NewLine;
                    Turn = 0;
                }
            }

            if (Turn == 0)
                MessageBox.Show("Player One Wins!");
            else
                MessageBox.Show("Player Two Wins!");

           
        }
    }
}
