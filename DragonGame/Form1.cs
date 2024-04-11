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
            string src = @"C:\Users\27810\Downloads\fire_dragon.png";

            if (radFire1.Checked == true)
            {
                this.BackColor = Color.Firebrick;
                pbxPlayer1.BackgroundImage = Image.FromFile(src);
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
            string src = @"C:\Users\27810\Downloads\ice_dragon.png";

            if (radIce1.Checked == true)
            {
                this.BackColor = Color.LightCyan;
                pbxPlayer1.BackgroundImage = Image.FromFile(src);
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radWind1_Click(object sender, EventArgs e)
        {
            string src = @"C:\Users\27810\Downloads\wind_dragon.png";

            if (radWind1.Checked == true)
            {
                this.BackColor = Color.PaleGoldenrod;
                pbxPlayer1.BackgroundImage = Image.FromFile(src);
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radEarth1_Click(object sender, EventArgs e)
        {
            string src = @"C:\Users\27810\Downloads\earth_dragon.png";

            if (radEarth1.Checked == true)
            {
                this.BackColor = Color.OliveDrab;
                pbxPlayer1.BackgroundImage = Image.FromFile(src);
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radFire2_Click(object sender, EventArgs e)
        {
            string src = @"C:\Users\27810\Downloads\fire_dragon.png";

            if (radFire2.Checked == true)
            {
                this.BackColor = Color.Firebrick;
                pbxPlayer2.BackgroundImage = Image.FromFile(src);
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radIce2_Click(object sender, EventArgs e)
        {
            string src = @"C:\Users\27810\Downloads\ice_dragon.png";

            if (radIce2.Checked == true)
            {
                this.BackColor = Color.LightCyan;
                pbxPlayer2.BackgroundImage = Image.FromFile(src);
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radWind2_Click(object sender, EventArgs e)
        {
            string src = @"C:\Users\27810\Downloads\wind_dragon.png";

            if (radWind2.Checked == true)
            {
                this.BackColor = Color.PaleGoldenrod;
                pbxPlayer2.BackgroundImage = Image.FromFile(src);
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }

        private void radEarth2_Click(object sender, EventArgs e)
        {
            string src = @"C:\Users\27810\Downloads\earth_dragon.png";

            if (radEarth2.Checked == true)
            {
                this.BackColor = Color.Firebrick;
                pbxPlayer2.BackgroundImage = Image.FromFile(src);
            }
            else
            {
                this.BackColor = Color.LavenderBlush;
            }
        }
    }
}
