using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        char o = 'O';
        int movement = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o = 'o';
            movement = 0;
            b1.Enabled = true; b1.Text = "";
            b2.Enabled = true; b2.Text = "";
            b3.Enabled = true; b3.Text = "";
            b4.Enabled = true; b4.Text = "";
            b5.Enabled = true; b5.Text = "";
            b6.Enabled = true; b6.Text = "";
            b7.Enabled = true; b7.Text = "";
            b8.Enabled = true; b8.Text = "";
            b9.Enabled = true; b9.Text = "";
            tableLayoutPanel1.Enabled = true;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.White;
            if(o == 'O')
            {
                bt.Text = "O";
                if((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                        (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                        (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                        (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                        (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                        (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                        (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                        (b3.Text == b5.Text) && (b5.Text == b7.Text) && (b5.Text != ""))
                {
                    MessageBox.Show($"The winner is {o.ToString().ToUpper() }!");
                    tableLayoutPanel1.Enabled = false;
                }
                else if(movement == 8)
                {
                    MessageBox.Show("Draw!");
                }

                o = 'X';
            }
            else if(o == 'X')
            {
                bt.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                        (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                        (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                        (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                        (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                        (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                        (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                        (b3.Text == b5.Text) && (b5.Text == b7.Text) && (b5.Text != ""))
                {
                    MessageBox.Show($"The winner is {o.ToString().ToUpper() }!");
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw!");
                }

                o = 'O';
            }
            movement++;
        }      
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Tic Tac Toe game, made on Visual Studio 2019 with C$ language by Anton (Peshp).");
        }
    }
}
