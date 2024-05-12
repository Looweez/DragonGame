using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        int player1Roll;
        int player2Roll;

        public frmBattle(int[] P1values, int[] P2values, string[] P1data, string[] P2data)
        {
            InitializeComponent();

            //frmGameStart.saveValues(frmGameStart.txtPlayerName.text);

            dragonName1 = P1data[1];
            dragonType1 = P1data[2];
            gbxPlayer1Dragon.Text = dragonName1 + " the " + dragonType1 + " Dragon's turn";

            dragonHP1 = P1values[0];
            lblPlayerHP.Text = "HP: " + dragonHP1; //hp shows up as 0,, idk why :(
            
        }

        private int randomRoll() //method for random number from 1 to 6
        {
            Random random = new Random();
            int randomRoll = random.Next(1, 7);
            return randomRoll;
        }

        public int takeInitiative() //method for the initiative rolls
        {
            player1Roll = randomRoll();
            player2Roll = randomRoll();
            while (player1Roll == player2Roll)
            {
                player1Roll = randomRoll();
                player2Roll = randomRoll();
            }

            if (player1Roll > player2Roll)  //if player 1's roll is higher, then they take the initiative
            {
                return player1Roll;
            }
            else if (player1Roll < player2Roll)  //if player 1's roll is higher, then they take the initiative
            {
                return player2Roll;
            }
            else
            {
                return 0; //had to add due to "not all code paths return a value" error
            }

        }

        private void updateTurn()  //updates the form depending on who has the current turn
        {

        }

        private void frmBattle_Load(object sender, EventArgs e)
        {
            btnRest.Visible = false;
            takeInitiative();
            if (takeInitiative() == player1Roll) 
            {
                MessageBox.Show("Player 1 starts. Their dice showed" + player1Roll, "Turn initiative", MessageBoxButtons.OK);
            }
            else if (takeInitiative() == player2Roll)
            {
                MessageBox.Show("Player 2 starts. Their dice showed" + player2Roll, "Turn initiative", MessageBoxButtons.OK);
            }

            while (dragonHP1 > 0 && dragonHP2 > 0)  //while both dragons are alive
            {
                
            }

        }
    }
}
