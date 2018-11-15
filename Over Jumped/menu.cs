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

    public partial class menu : Form
    {
        public static bool pause = true;
        public menu()
        {
            InitializeComponent();
            if (Application.OpenForms.OfType<menu>().Count() == 1)
            { 
                //SaveGame.Visible = true;
                resumeGame.Visible = true;
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Over_Jumped>().Count() == 1)
                Application.OpenForms.OfType<Over_Jumped>().First().Close();
            Over_Jumped game = new Over_Jumped();
            game.Show();
            menu.pause = false;
            this.Hide();
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
            //save
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            //load
        }

        private void resumeGame_Click(object sender, EventArgs e)
        {
            menu.pause = false;
            this.Hide();

        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

    }
}
