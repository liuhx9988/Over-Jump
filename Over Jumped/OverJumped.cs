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
        bool Vbottom = false;
        bool Vtop = false;
        bool Hleft = false;
        bool Hright = false;
        int score = 0;
        PictureBox[] boxs = new PictureBox[2];

        public Over_Jumped()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxs[0] = Box0;
            boxs[1] = Box1;
        }
        int Vspeed = 0;
        bool alreadyJump = false;
        private void Ver_Tick(object sender, EventArgs e)
        {
            score++;
            ScoreNum.Text = score.ToString();
            if (Player.Top >= this.Size.Height - Player.Height - 30)
            {
                Vspeed = 0;
                playerGound = true;

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


            if (!alreadyJump && playerUp && (JumpCounter < 20 || playerGound))
            {
                if(!Vtop)
                {
                    Vspeed = -10;
                    JumpCounter++;
                }
                else
                {
                    JumpCounter += 20;
                    Vspeed = 10;
                }
                
                if (JumpCounter >= 20)
                {
                    alreadyJump = true;
                }
            }
            else if(Vbottom)
            {
                Vspeed = 0;
                JumpCounter = 0;
                if (!playerUp)
                {
                    alreadyJump = false;
                }
                
            }
            else if (playerGound)
            {
                JumpCounter = 0;
                if (!playerUp)
                {
                    alreadyJump = false;
                }
            } else if (!playerUp)
            {
                JumpCounter += 5;
            }

            if (Player.Top + Vspeed > this.Size.Height - Player.Height - 30)
            {
                Player.Top = this.Size.Height - Player.Height - 30;
            }
            else
            {
                Player.Top += Vspeed;
            }
            foreach (PictureBox box in boxs)
            {
                if (Player.Bounds.IntersectsWith(box.Bounds))
                {
                    if (Player.Bottom >= box.Top && Player.Bottom < box.Bottom)
                    {
                        Vbottom = true;
                        Player.Top = box.Top - Player.Height + 1;
                        //Test.Text = "BoxGround";
                    }
                    else if (Player.Top <= box.Bottom && Player.Bottom > box.Top)
                    {
                        Vtop = true;
                        Player.Top = box.Bottom + 1;
                        //Test.Text = "BoxTOP";
                    }
                }
                else
                {
                    Vbottom = false;
                    Vtop = false;
                    //Test.Text = "NOTBoxTOP";
                }
            }
        }


        private void Hor_Tick(object sender, EventArgs e)
        {
            const int Hspeed = -5;
            if (playerL && !Hright)
            {
                Player.Left += Hspeed;
                //Test.Text = "Move left";
            }

            if (playerR&& !Hleft)
            {
                Player.Left -= Hspeed;
                //Test.Text = "Move Right";
            }


            foreach (PictureBox box in boxs)
            {
                if (Player.Left + Player.Width >= box.Left && Player.Top > box.Top && Player.Left < box.Left)
                {
                    Hleft = true;
                }
                else
                {
                    Hleft = false;
                }
                if (Player.Right - Player.Width <= box.Right && Player.Right > box.Right && Player.Top > box.Top)
                {
                    Hright = true;
                }
                else
                {
                    Hright = false;
                }
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
