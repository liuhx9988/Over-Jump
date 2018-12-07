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
        //bool playerGound = false;
        //int JumpCounter = 0;
        //int grvaityCounter = 0;
        //bool Vbottom = false;
        //bool Vtop = false;
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
        //bool alreadyJump = false;
        public Boolean collisionBottom(PictureBox tar)
        {
            foreach (PictureBox box in boxs)
            {
                if (box != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = box.Bounds;
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean collisionTop(PictureBox tar)
        {

            foreach (PictureBox box in boxs)
            {
                if (box != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = box.Bounds;
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean collisionLeft(PictureBox tar)
        {
            foreach (PictureBox box in boxs)
            {
                if (box != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = box.Bounds;
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean collisionRight(PictureBox tar)
        {
            foreach (PictureBox box in boxs)
            {
                if (box != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = box.Bounds;
                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        }
        private void Ver_Tick(object sender, EventArgs e)
        {
            score++;
            ScoreNum.Text = score.ToString();
            //Vspeed++;
            if (Vspeed > 0)
            {   //If any force still exists
                if (collisionBottom(Player))
                {   //Unless players head is banging in a wall
                    Vspeed = 0;
                }
                else
                {   //Move player up, lower force each "move"
                    Vspeed--;
                    Player.Top -= Vspeed;
                }
            }
            else
            {   //If no force, player is not jumping.
                playerUp = false;
            }

            if (!playerUp && Player.Location.Y + Player.Height < this.Height - 2 && !collisionTop(Player))
            {   //If Player doesnt jump, Location is above the floor or is standing on object
                Player.Top += 10; //Player falls
            }

            if (!playerUp && Player.Location.Y + Player.Height > this.Height - 1)
            {   //If player would for some reason be under the floor, move him up
                Player.Top--;
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
                //if (Player.Bounds.IntersectsWith(box.Bounds))
                //{
                    if (collisionLeft(Player))
                    {
                        Hleft = true;
                        Test.Text = " left";
                     }
                    else
                    {
                        Hleft = false;
                    }
                    if (collisionRight(Player))
                    {
                        Hright = true;
                        Test.Text = "right";
                }
                    else
                    {
                        Hright = false;
                    }
                //}
                //else
                //{
                //    Hleft = false;
                //    Hright = false;
                //}
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
                    //playerUp = true;


                        if (!playerUp /*&& !InAirNoCollision(pb_Player)*/)
                        {  
                            Player.Top -= 20;     
                            Vspeed = 20;       
                        playerUp = true;    
                        }
                    
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
