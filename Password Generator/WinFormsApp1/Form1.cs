using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int currPassLenght = 0;
        Random character = new Random();
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 5;
            trackBar1.Maximum = 20;
            passwordGenerate(5);
        }

        private void passwordGenerate(int passLenght)
        {
            String allChars = "ABCDIFGHIJKLMNOPQRSTUVWXYZ0123456789abcdifghijklmnopqrstuvwxyz" +
                "!@#$%^&*()[]{}";
            String randomPass = "";
            for (int i = 0; i < passLenght; i++)
            {
                int randomNum = character.Next(0, allChars.Length);
                randomPass += allChars[randomNum];
            }
            label1.Text = randomPass;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Pasword Lenght: " + trackBar1.Value.ToString();
            currPassLenght = trackBar1.Value;
            passwordGenerate(currPassLenght);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordGenerate(currPassLenght);
        }
    }
}
