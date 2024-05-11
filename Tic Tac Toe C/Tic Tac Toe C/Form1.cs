using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private System.Windows.Forms.Label[] _sq;
        public string playerturn;
        public int turn_num;
        private bool _isGameOver;

       
        public void startgame()
        {
            turn_num = 0;
            if (xplayer.Checked == true)
            {
                playerturn = "x";
            }
            else
            {
                playerturn = "o";
            }

            for (int i = 0; i < 9; i++)
            {

                _sq[i].Text = "";

                _sq[i].ForeColor = Color.Black;

                _sq[i].BackColor = Color.Transparent;

                _sq[i].Enabled = true;
            }
        }
        
        private void MouseLeaveHandler(object sender, EventArgs e)
        {
            Label tempButton = (Label)sender;

            if (tempButton.Text != "")
            {
                return; 
            }
            else
            {
               tempButton.BackColor = Color.Transparent;  
            }
          
        }

       
        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            Label tempButton = (Label)sender;

            if (tempButton.Text != "")
            {
                return;
            }

            if (playerturn == "x")
            {
                tempButton.BackColor = Color.SkyBlue;
            }
            else
            {
                tempButton.BackColor = Color.Coral;
            }
        }

        
        private void ClickHandler(object sender, System.EventArgs e)
        {
            Label tempButton = (Label)sender;

            turn_num += 1;

            if (tempButton.Text != "")
            {
                return;
            }

            if (playerturn == "x")
            {
                tempButton.ForeColor = Color.Red;
                tempButton.Text = "X";
                playerturn = "o";
                lblturn.Text = "Turn O";
                lblturn.ForeColor = Color.Blue;
            }
            else
            {
                tempButton.ForeColor = Color.Blue;
                tempButton.Text = "O";
                playerturn = "x";
                lblturn.Text = "Turn X";
                lblturn.ForeColor = Color.Red;
            }

            tempButton.BackColor = Color.Transparent; 
 
            this._isGameOver = CheckWinner(_sq);

            if (_isGameOver == true)
            {
                startgame();
            }
            if (turn_num == 9 & _isGameOver == false)
            {
                MessageBox.Show("Draaaw", "Game Over", MessageBoxButtons.OK);
                startgame();
            }
        }
        
        private void btnnew_Click(object sender, EventArgs e)
        {
            startgame();
            for (int i = 0; i < 9; i++)
            {
                this._sq[i].Click += new System.EventHandler(this.ClickHandler);
                this._sq[i].MouseMove += new MouseEventHandler (this.MouseMoveHandler);
                this._sq[i].MouseLeave += new System.EventHandler(this.MouseLeaveHandler);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this._isGameOver = false;
            turn_num = 0;
            _sq = new Label[9] { sq1, sq2, sq3, sq4, sq5, sq6, sq7, sq8, sq9 };
        }

        static private int[,] Winners = new int[,]{{0,1,2},{3,4,5},{6,7,8},{0,3,6},{1,4,7},{2,5,8},{0,4,8},{2,4,6}};
        static public bool CheckWinner(Label[] myControls)
        {
            bool gameOver = false;
            for (int i = 0; i < 8; i++)
            {
                int a = Winners[i, 0], b = Winners[i, 1], c = Winners[i, 2];
                Label b1 = myControls[a], b2 = myControls[b], b3 = myControls[c];
                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                { continue; }
                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.Lime;
                    gameOver = true;
                    MessageBox.Show(b1.Text + " Win Go To ", "GG", MessageBoxButtons.OK);
                    break;
                }
            }
            return gameOver;
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sq3_MouseHover(object sender, EventArgs e)
        {
         
        }
    }
}
