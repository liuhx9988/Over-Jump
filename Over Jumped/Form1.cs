using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Over_Jumped
{
    public partial class Over_Jumped : Form
    {
        bool playerL = false;
        bool playerR = false;
        bool playerUp = false;
        bool playerGound = false;
        int JumpCounter = 0;

        public Over_Jumped()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int Vspeed = 0;
        bool alreadyJump = false;
        private void Ver_Tick(object sender, EventArgs e)
        {
            if (Player.Top >= this.Size.Height - Player.Height - 30)
            {
                Vspeed = 0;
                playerGound =true;

            }
            //else if(playerGound)
            //{
            //    Vspeed = 0;
            //}
            else
            {
                Vspeed += 1;
                playerGound = false;
            }


            if (!alreadyJump && playerUp && (JumpCounter <20|| playerGound))
            {
                Vspeed = -10;
                JumpCounter++;
                if (JumpCounter >= 20)
                {
                    alreadyJump = true;
                }
            }

            else if (playerGound)
            {
                JumpCounter = 0;
                if(!playerUp)
                {
                    alreadyJump = false;
                }
            }else if(!playerUp)
            {
                JumpCounter+=5;
            }

            if (Player.Top + Vspeed > this.Size.Height - Player.Height - 30)
            {
                Player.Top = this.Size.Height - Player.Height - 30;
            }
            else
            {
                Player.Top += Vspeed;
            }


        }


        private void Hor_Tick(object sender, EventArgs e)
        {
            const int Hspeed = -5;
            if (playerL)
            {
                Player.Left += Hspeed;
                Test.Text = "Move left";
            }

            if (playerR)
            {
                Player.Left -= Hspeed;
                Test.Text = "Move Right";
            }

        }

        private void Over_Jumped_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerL = true;
                    break;
                case Keys.Right:
                    playerR = true;
                    break;
                case Keys.Up:
                    playerUp = true;
                    break;
            }
        }

        private void Over_Jumped_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerL = false;
                    break;
                case Keys.Right:
                    playerR = false;
                    break;
                case Keys.Up:
                    playerUp = false;
                    break;
            }
        }
    }
}
