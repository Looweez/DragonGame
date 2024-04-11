using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonGame
{
    public partial class frmGameStart : Form
    {
        public frmGameStart()
        {
            InitializeComponent();
        }

        private void radFire1_Click(object sender, EventArgs e)
        {

            if (radFire1.Checked == true)
            {
                pbxFireDragon.BringToFront();
                this.BackColor = Color.Firebrick;
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void frmGameStart_Load(object sender, EventArgs e)
        {
            /* string src = @"C:\Users\27810\Downloads\fire_dragon.png";

            if (radFire1.Checked == true)
            {
                this.BackColor = Color.Firebrick;
                pbxPlayer1.BackgroundImage = Image.FromFile(src);
            }*/
        }

        private void radIce1_Click(object sender, EventArgs e)
        {

            if (radIce1.Checked == true)
            {
                this.BackColor = Color.LightCyan;
                pbxIceDragon.BringToFront();
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radWind1_Click(object sender, EventArgs e)
        {

            if (radWind1.Checked == true)
            {
                this.BackColor = Color.PaleGoldenrod;
                pbxWindDragon.BringToFront();
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radEarth1_Click(object sender, EventArgs e)
        {

            if (radEarth1.Checked == true)
            {
                this.BackColor = Color.OliveDrab;
                pbxEarthDragon.BringToFront();
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radFire2_Click(object sender, EventArgs e)
        {

            if (radFire2.Checked == true)
            {
                this.BackColor = Color.Firebrick;
                pbxFireDragon2.BringToFront();
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radIce2_Click(object sender, EventArgs e)
        {

            if (radIce2.Checked == true)
            {
                this.BackColor = Color.LightCyan;
                pbxIceDragon2.BringToFront();
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radWind2_Click(object sender, EventArgs e)
        {

            if (radWind2.Checked == true)
            {
                this.BackColor = Color.PaleGoldenrod;
                pbxWindDragon2.BringToFront();
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radEarth2_Click(object sender, EventArgs e)
        {

            if (radEarth2.Checked == true)
            {
                this.BackColor = Color.OliveDrab;
                pbxEarthDragon2.BringToFront();
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }
    }
}
