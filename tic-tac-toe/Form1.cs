using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        #region initial
        Settings settings = new Settings();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}
        #endregion
        #region buttons
        private void button1_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b1 = settings.b1;
            if (b1 != 1 && b1 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button1.Text = "O";
                    click = 0;
                    b1 = 1;
                }
                else if(click == 0)
                {
                    button1.Text = "X";
                    click = 1;
                    b1 = 2;
                }
                Help help = new Help(b1, settings.b2, settings.b3, settings.b4, settings.b5, settings.b6, settings.b7, settings.b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b1 = b1;
            settings.click = click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b2 = settings.b2;
            if (b2 != 1 && b2 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button2.Text = "O";
                    click = 0;
                    b2 = 1;
                }
                else if (click == 0)
                {
                    button2.Text = "X";
                    click = 1;
                    b2 = 2;
                }
                Help help = new Help(settings.b1, b2, settings.b3, settings.b4, settings.b5, settings.b6, settings.b7, settings.b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b2 = b2;
            settings.click = click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b3 = settings.b3;
            if (b3 != 1 && b3 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button3.Text = "O";
                    click = 0;
                    b3 = 1;
                }
                else if (click == 0)
                {
                    button3.Text = "X";
                    click = 1;
                    b3 = 2;
                }
                Help help = new Help(settings.b1, settings.b2, b3, settings.b4, settings.b5, settings.b6, settings.b7, settings.b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b3 = b3;
            settings.click = click;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b4 = settings.b4;
            if (b4 != 1 && b4 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button4.Text = "O";
                    click = 0;
                    b4 = 1;
                }
                else if (click == 0)
                {
                    button4.Text = "X";
                    click = 1;
                    b4 = 2;
                }
                Help help = new Help(settings.b1, settings.b2, settings.b3, b4, settings.b5, settings.b6, settings.b7, settings.b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b4 = b4;
            settings.click = click;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b5 = settings.b5;
            if (b5 != 1 && b5 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button5.Text = "O";
                    click = 0;
                    b5 = 1;
                }
                else if (click == 0)
                {
                    button5.Text = "X";
                    click = 1;
                    b5 = 2;
                }
                Help help = new Help(settings.b1, settings.b2, settings.b3, settings.b4, b5, settings.b6, settings.b7, settings.b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b5 = b5;
            settings.click = click;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b6 = settings.b6;
            if (b6 != 1 && b6 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button6.Text = "O";
                    click = 0;
                    b6 = 1;
                }
                else if (click == 0)
                {
                    button6.Text = "X";
                    click = 1;
                    b6 = 2;
                }
                Help help = new Help(settings.b1, settings.b2, settings.b3, settings.b4, settings.b5, b6, settings.b7, settings.b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b6 = b6;
            settings.click = click;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b7 = settings.b7;
            if (b7 != 1 && b7 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button7.Text = "O";
                    click = 0;
                    b7 = 1;
                }
                else if (click == 0)
                {
                    button7.Text = "X";
                    click = 1;
                    b7 = 2;
                }
                Help help = new Help(settings.b1, settings.b2, settings.b3, settings.b4, settings.b5, settings.b6, b7, settings.b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b7 = b7;
            settings.click = click;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b8 = settings.b8;
            if (b8 != 1 && b8 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button8.Text = "O";
                    click = 0;
                    b8 = 1;
                }
                else if (click == 0)
                {
                    button8.Text = "X";
                    click = 1;
                    b8 = 2;
                }
                Help help = new Help(settings.b1, settings.b2, settings.b3, settings.b4, settings.b5, settings.b6, settings.b7, b8, settings.b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b8 = b8;
            settings.click = click;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int click = settings.click;
            int b9 = settings.b9;
            if (b9 != 1 && b9 != 2 && settings.stop != true)
            {
                if (click == 1)
                {
                    button9.Text = "O";
                    click = 0;
                    b9 = 1;
                }
                else if (click == 0)
                {
                    button9.Text = "X";
                    click = 1;
                    b9 = 2;
                }
                Help help = new Help(settings.b1, settings.b2, settings.b3, settings.b4, settings.b5, settings.b6, settings.b7, settings.b8, b9, settings.stop);
                _winner.Text = help.Winning();
                if (_winner.Text == "The winner is O")
                {
                    settings.SO++;
                    labelSO.Text = settings.SO.ToString();
                    settings.stop = help.StopGame();
                }
                else if (_winner.Text == "The winner is X")
                {
                    settings.SX++;
                    labelSX.Text = settings.SX.ToString();
                    settings.stop = help.StopGame();
                }
            }
            settings.b9 = b9;
            settings.click = click;
        }
        #endregion

        private void Reset_Click(object sender, EventArgs e)
        {
            button1.Text = ""; button2.Text = ""; button3.Text = "";
            button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";
            _winner.Text = "...";

            settings.b1 = 0; settings.b2 = 0; settings.b3 = 0;
            settings.b4 = 0; settings.b5 = 0; settings.b6 = 0;
            settings.b7 = 0; settings.b8 = 0; settings.b9 = 0;
            settings.click = 0;
            settings.stop = false;
        }

        private void _winner_Click(object sender, EventArgs e){ }
        private void labelPX_Click(object sender, EventArgs e){ }
        private void labelPO_Click(object sender, EventArgs e){ }

        private void labelSX_Click(object sender, EventArgs e)
        {

        }
    }
}
