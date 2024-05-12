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
    public partial class frmBattle : Form
    {
        string playerName1;
        string playerName2;
        string dragonName1;
        string dragonName2;
        string dragonType1;
        string dragonType2;
        int dragonHP1;
        int dragonHP2;
        int dragonATK1;
        int dragonATK2;
        int dragonSPATK1;
        int dragonSPATK2;
        int dragonBLOCK1;
        int dragonBLOCK2;

        public frmBattle(int[] P1values, int[] P2values, string[] P1data, string[] P2data)
        {
            InitializeComponent();

            dragonName1 = P1data[1];
            dragonType1 = P1data[2];
            gbxPlayer1Dragon.Text = dragonName1 + " the " + dragonType1 + " Dragon's turn";

            dragonHP1 = P1values[0];
            lblPlayerHP.Text = "HP: " + dragonHP1; //hp shows up as 0,, idk why :(
            
        }


        public class randomRollGenerator //method for random number from 1 to 6
        {
            private Random random = new Random();
            
            public int randomRoll()
            {
                return random.Next(1, 7);
            }
        }

        

    }
}
