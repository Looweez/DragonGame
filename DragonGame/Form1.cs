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
    //group name: CeilingLouse
    //team members: Ceili Rain Abrahams and Louise Lee
    //student numbers: Ceili - ST10438681   Louise - ST10438795
    
    //hallo zack binspin
    public partial class frmGameStart : Form
    {
        public frmGameStart()
        {
            InitializeComponent();
        }

        private void radFire1_Click(object sender, EventArgs e) //changes appearance of form and dragon picturebox if 'fire' radio button selected
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

        private void radIce1_Click(object sender, EventArgs e) //changes appearance for ice
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

        private void radWind1_Click(object sender, EventArgs e) //changes appearance for wind
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

        private void radEarth1_Click(object sender, EventArgs e) //changes appearance for earth
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

        private void radFire2_Click(object sender, EventArgs e) //appearance change
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

        private void radIce2_Click(object sender, EventArgs e) //appearance change
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

        private void radWind2_Click(object sender, EventArgs e) //appearance change
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

        private void radEarth2_Click(object sender, EventArgs e) //appearance change
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
