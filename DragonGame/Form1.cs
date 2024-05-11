using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DragonGame
{
    //group name: CeilingLouse
    //team members: Ceili Rain Abrahams and Louise Lee
    //student numbers: Ceili - ST10438681   Louise - ST10438795
    public partial class frmGameStart : Form
    {

        //player data arrays
        public string[] P1data;
        public string[] P2data;
        public int[] P1values;
        public int[] P2values;

        //dragon stats and types
        public const string FIRE_DRAG_NAME = "Fire Dragon";
        public const string ICE_DRAG_NAME = "Ice Dragon";
        public const string WIND_DRAG_NAME = "Wind Dragon";
        public const string EARTH_DRAG_NAME = "Earth Dragon";

        public const int FIRE_DRAG_HP = 20;
        public const int ICE_DRAG_HP = 30;
        public const int WIND_DRAG_HP = 40;
        public const int EARTH_DRAG_HP = 50;

        public const int FIRE_DRAG_ATK = 5;
        public const int ICE_DRAG_ATK = 4;
        public const int WIND_DRAG_ATK = 3;
        public const int EARTH_DRAG_ATK = 2;

        public const int FIRE_DRAG_SPATK = 12;
        public const int ICE_DRAG_SPATK = 9;
        public const int WIND_DRAG_SPATK = 7;
        public const int EARTH_DRAG_SPATK = 5;

        public const int FIRE_DRAG_BLOCK = 4;
        public const int ICE_DRAG_BLOCK = 5;
        public const int WIND_DRAG_BLOCK = 5;
        public const int EARTH_DRAG_BLOCK = 6;

        public frmGameStart()
        {
            InitializeComponent();
        }

        private void frmGameStart_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;  //disables the start game button when the form loads
            btnSave1.Click += btnSave1_Click;
        }

        if (btnSave1.click == true) AND (btnSave2.click == true)
        {
            btnSave1.Enabled = false;
            btnSave2.Enabled = false;

            if saveValues() called for both then //not a proper condition yet
            {
                btnStart.enabled = true;
            }

        }

        private void saveValues(string playerName, string dragonName, string dragonType)
        {

            //player 1 saving
            if (btnSave1.click == true)

                switch (dragonType)
                {
                    case "Fire Dragon":
                        P1data[0] = playerName;
                        P1data[1] = dragonName;
                        P1data[2] = dragonType;
                        P1values[0] = FIRE_DRAG_HP;
                        P1values[1] = FIRE_DRAG_ATK;
                        P1values[2] = FIRE_DRAG_SPATK;
                        P1values[3] = FIRE_DRAG_BLOCK;
                        break;

                    case "Ice Dragon":
                        P1data[0] = playerName;
                        P1data[1] = dragonName;
                        P1data[2] = dragonType;
                        P1values[0] = ICE_DRAG_HP;
                        P1values[1] = ICE_DRAG_ATK;
                        P1values[2] = ICE_DRAG_SPATK;
                        P1values[3] = ICE_DRAG_BLOCK;
                        break;

                    case "Wind Dragon":
                        P1data[0] = playerName;
                        P1data[1] = dragonName;
                        P1data[2] = dragonType;
                        P1values[0] = WIND_DRAG_HP;
                        P1values[1] = WIND_DRAG_ATK;
                        P1values[2] = WIND_DRAG_SPATK;
                        P1values[3] = WIND_DRAG_BLOCK;
                        break;

                    case "Earth Dragon":
                        P1data[0] = playerName;
                        P1data[1] = dragonName;
                        P1data[2] = dragonType;
                        P1values[0] = EARTH_DRAG_HP;
                        P1values[1] = EARTH_DRAG_ATK;
                        P1values[2] = EARTH_DRAG_SPATK;
                        P1values[3] = EARTH_DRAG_BLOCK;
                        break;
                }


            //player 2 saving
            else if (btnSave2.click == true)
          
                switch (dragonType)
                {
                    case "Fire Dragon":
                        P2data[0] = playerName;
                        P2data[1] = dragonName;
                        P2data[2] = dragonType;
                        P2values[0] = FIRE_DRAG_HP;
                        P2values[1] = FIRE_DRAG_ATK;
                        P2values[2] = FIRE_DRAG_SPATK;
                        P2values[3] = FIRE_DRAG_BLOCK;
                        break;

                    case "Ice Dragon":
                  P2data[0] = playerName;
                        P2data[1] = dragonName;
                        P2data[2] = dragonType;
                        P2values[0] = ICE_DRAG_HP;
                        P2values[1] = ICE_DRAG_ATK;
                        P2values[2] = ICE_DRAG_SPATK;
                        P2values[3] = ICE_DRAG_BLOCK;
                        break;

                    case "Wind Dragon":
                  P2data[0] = playerName;
                        P2data[1] = dragonName;
                        P2data[2] = dragonType;
                        P2values[0] = WIND_DRAG_HP;
                        P2values[1] = WIND_DRAG_ATK;
                        P2values[2] = WIND_DRAG_SPATK;
                        P2values[3] = WIND_DRAG_BLOCK;
                        break;

                    case "Earth Dragon":
                  P2data[0] = playerName;
                        P2data[1] = dragonName;
                        P2data[2] = dragonType;
                        P2values[0] = EARTH_DRAG_HP;
                        P2values[1] = EARTH_DRAG_ATK;
                        P2values[2] = EARTH_DRAG_SPATK;
                        P2values[3] = EARTH_DRAG_BLOCK;
                        break;
                }

          
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

        private void btnStart_Click(object sender, EventArgs e)
        {

            frmBattle frmBattle = new frmBattle();
            frmBattle.Show();
            this.Hide();

        }
    }
}
