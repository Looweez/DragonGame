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

        bool btnSave1Clicked;  //boolean variables for the two save buttons
        bool btnSave2Clicked;

        bool saveValuesCalled1;  //boolean variable that tracks when the saveValues method was called
        bool saveValuesCalled2;

        string chosenDragon1;
        string chosenDragon2;

        public frmGameStart()
        {
            InitializeComponent();
        }

        private void frmGameStart_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;  //disables the start game button when the form loads
            btnStart.BackColor = Color.Gray;
            if (btnSave1Clicked == true && btnSave2Clicked == true)
            {
                btnSave1.Enabled = false;
                btnSave2.Enabled = false;

                if (saveValuesCalled1 == true && saveValuesCalled2 == true)
                {
                    btnStart.Enabled = true;
                }

            }
        }

        public void saveValues(string playerName, string dragonName, string dragonType)  //method with parameters made public so both forms can access it
        {

            //player 1 saving
            if (btnSave1Clicked == true)

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
            else if (btnSave2Clicked == true)
          
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon1 = FIRE_DRAG_NAME;
                }
                else
                {
                    chosenDragon1 = null;
                }
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon1 = ICE_DRAG_NAME;
                }
                else
                {
                    chosenDragon1 = null;
                }
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon1 = WIND_DRAG_NAME;
                }
                else
                {
                    chosenDragon1 = null;
                }
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon1 = EARTH_DRAG_NAME;
                }
                else
                {
                    chosenDragon1 = null;
                }
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon2 = FIRE_DRAG_NAME;
                }
                else
                {
                    chosenDragon2 = null;
                }
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon2 = ICE_DRAG_NAME;
                }
                else
                {
                    chosenDragon2 = null;
                }
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon2 = WIND_DRAG_NAME;
                }
                else
                {
                    chosenDragon2 = null;
                }
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
                if (MessageBox.Show("Are you sure about your dragon?", "Dragon Type Confirmation", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chosenDragon2 = EARTH_DRAG_NAME;
                }
                else
                {
                    chosenDragon2 = null;
                }
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

        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (txtDragonName1.Text != "" || txtPlayerName1.Text != "" || chosenDragon1 != null)
            {
                saveValues(txtPlayerName1.Text, txtDragonName1.Text, chosenDragon1);
                saveValuesCalled1 = true;
            }
            else
            {
                MessageBox.Show("Please fill in your name, dragon name and/or dragon type.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (txtDragonName2.Text != "" || txtPlayerName2.Text != "" || chosenDragon2 != null)
            {
                saveValues(txtPlayerName2.Text, txtDragonName2.Text, chosenDragon2);
                saveValuesCalled2 = true;
            }
            else
            {
                MessageBox.Show("Please fill in your name, dragon name and/or dragon type.", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
