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
using System.Xml.Linq;

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


        bool block1 = false;
        bool block2 = false;

        bool player1Turn = false;
        bool player2Turn = false;

        bool player1Rest = false;
        bool player2Rest = false;

        int player1Roll;
        int player2Roll;

        int counter = 0;



        public frmBattle(int[] P1values, int[] P2values, string[] P1data, string[] P2data)
        {
            InitializeComponent();

            playerName1 = P1data[0];
            dragonName1 = P1data[1];
            dragonType1 = P1data[2];

            dragonHP1 = P1values[0];
            dragonATK1 = P1values[1];
            dragonSPATK1 = P1values[2];
            dragonBLOCK1 = P1values[3];

            playerName2 = P2data[0];
            dragonName2 = P2data[1];
            dragonType2 = P2data[2];

            dragonHP2 = P2values[0];
            dragonATK2 = P2values[1];
            dragonSPATK2 = P2values[2];
            dragonBLOCK2 = P2values[3];

        }

        private void frmBattle_Load(object sender, EventArgs e)
        {

            btnRest.Visible = false;

            takeInitiative();
            if (takeInitiative() == player1Roll)
            {
                MessageBox.Show("Player 1 starts. Their dice showed " + player1Roll, "Turn initiative", MessageBoxButtons.OK);
            }
            else if (takeInitiative() == player2Roll)
            {
                MessageBox.Show("Player 2 starts. Their dice showed " + player2Roll, "Turn initiative", MessageBoxButtons.OK);
            }

            counter++; //had to put this here because for some reason there were 3 turns at the start of the game.
        }

        private int randomRoll() //method for random number from 1 to 6
        {
            Random random = new Random();
            int randomRoll = random.Next(1, 7);
            return randomRoll;
        }

        public int takeInitiative() //method for the initiative rolls, determines who starts each turn
        {
            
            player1Roll = randomRoll();
            player2Roll = randomRoll();
            while (player1Roll == player2Roll) //if equal roll again
            {
                player1Roll = randomRoll();
                player2Roll = randomRoll();
            }

            if (player1Roll > player2Roll)  //if player 1's roll is higher, then they take the initiative
            {
               
                rtbBattleLog.Text += "\n NEW TURN \n-------------------------------------------------\n";

                rtbBattleLog.Text += "\n" + playerName1 + "'s dragon " + dragonName1 + " takes initiative"
                                                 + "\n---------------------------------------------------\n" + playerName1 + "'s turn:\n";

                gbxTurnPlayerDragon.Text = dragonName1 + " the " + dragonType1 + "'s turn";
                lblPlayerHP.Text = "HP: " + dragonHP1;
                gbxOpponent.Text = "Opponent: " + playerName2;
                lblOpponentDragon.Text = "\n" + dragonName2 + ", the " + dragonType2;
                lblOpponentHP.Text = "HP: " + dragonHP2;

                player1Turn = true;
                player2Turn = false;

                return player1Roll;
            }
            else if (player1Roll < player2Roll)  //if player 2's roll is higher, then they take the initiative
            {
                
                rtbBattleLog.Text += "\n NEW TURN \n-------------------------------------------------\n";

                rtbBattleLog.Text += "\n" + playerName2 + "'s dragon " + dragonName2 + " takes initiative!"
                                                 + "\n---------------------------------------------------\n" + playerName2 + "'s turn:\n";

                gbxTurnPlayerDragon.Text = "\n" + dragonName2 + " the " + dragonType2 + "'s turn";
                lblPlayerHP.Text = "HP: " + dragonHP2;
                gbxOpponent.Text = "Opponent: " + playerName1;
                lblOpponentDragon.Text = dragonName1 + ", the " + dragonType1;
                lblOpponentHP.Text = "HP: " + dragonHP1;

                player1Turn = false;
                player2Turn = true;

                return player2Roll;
            }
            else
            {
                return 0; //had to add due to "not all code paths return a value" error
            }

        }

        void playerTurn()
        {
            
            if (counter == 2) 
            {
                takeInitiative();
                counter = 0; // reset counter 
            }

            else if (player1Turn == true)
            {
                player1Turn = false;
                player2Turn = true;

                //update battle log
                rtbBattleLog.Text += "\n" + playerName2 + "'s turn:\n";
                gbxTurnPlayerDragon.Text = dragonName2 + " the " + dragonType2 + "'s turn";
                lblPlayerHP.Text = "HP: " + dragonHP2;

                gbxOpponent.Text = "Opponent: " + playerName1;
                lblOpponentDragon.Text = dragonName1 + ", the " + dragonType1;
                lblOpponentHP.Text = "HP: " + dragonHP1;


                rest();
            }
            else if (player2Turn == true)
            {
                player2Turn = false;
                player1Turn = true;

                //update battle log
                rtbBattleLog.Text += "\n" + playerName1 + "'s turn:\n";
                gbxTurnPlayerDragon.Text = dragonName1 + " the " + dragonType1 + "'s turn";
                lblPlayerHP.Text = "HP: " + dragonHP1;

                gbxOpponent.Text = "Opponent: " + playerName2;
                lblOpponentDragon.Text = dragonName2 + ", the " + dragonType2;
                lblOpponentHP.Text = "HP: " + dragonHP2;


                rest();
            }

        }
        //
        //dead check
        //
        private void checkDead()
        {
            //dragon 1 dies
            if (dragonHP1 <= 0)
            {
                rtbBattleLog.Text += "\n" + dragonName1 + " is unable to continue. " + dragonName2 + " wins!";

                //disable buttons
                btnPlayerAtk.Enabled = false;
                btnPlayerSp.Enabled = false;
                btnPlayerBlock.Enabled = false;
            }

            //dragon 2 dies
            if (dragonHP2 <= 0)
            {
                rtbBattleLog.Text += "\n" + dragonName2 + " is unable to continue. " + dragonName1 + " wins!";

                //disable buttons
                btnPlayerAtk.Enabled = false;
                btnPlayerSp.Enabled = false;
                btnPlayerBlock.Enabled = false;
            }

            //scrolling
            rtbBattleLog.SelectionStart = rtbBattleLog.Text.Length;
            rtbBattleLog.ScrollToCaret();
        }

        //
        //resting
        //
        private void rest()
        {
            if (player1Turn == true && player1Rest == true)
            {
                btnRest.Visible = true;
            }

            else if (player2Turn == true && player2Rest == true)
            {
                btnRest.Visible = true;
            }

            else 
            {
                btnRest.Visible = false;
            }
        }

        //
        //blocking
        //
        private void btnPlayerBlock_Click(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                block1 = true;
                block2 = false;
                rtbBattleLog.Text += "\n" + dragonName1 + " blocks for " + dragonBLOCK1 + " damage!";
                
            }
            else if (player2Turn == true)
            {
                block2 = true;
                block1 = false;
                rtbBattleLog.Text += "\n" + dragonName2 + " blocks for " + dragonBLOCK2 + " damage!";
                
            }

            playerTurn();
            counter++;

            //scrolling
            rtbBattleLog.SelectionStart = rtbBattleLog.Text.Length;
            rtbBattleLog.ScrollToCaret();

            
        }
        //
        //attacking
        //
        private void btnPlayerAtk_Click(object sender, EventArgs e)
        {
            int damage = 0;
            if (player1Turn == true && block2 == false) //player 1's turn and player 2 is not blocking
            {
                dragonHP2 -= dragonATK1;
                rtbBattleLog.Text += "\n" + dragonName1 + " attacks " + dragonName2 + "! " + dragonName2 + " takes " + dragonATK1 + " damage, and is now on " + dragonHP2 + "HP"
                                                 + "\n---------------------------------------------------\n";
            }
            else if (player1Turn == true && block2 == true) //players 1's turn and player 2 is blocking
            {
                damage = dragonATK1 - dragonBLOCK2;
                if (damage >= 0)
                {
                    dragonHP2 -= dragonATK1;
                }
                else 
                {
                    dragonHP2 -= 0;
                    damage = 0;
                }

                rtbBattleLog.Text += "\n" + dragonName1 + " attacks " + dragonName2 + "! " + dragonName2 + " takes " + damage + " damage, and is now on " + dragonHP2 + "HP"
                                                 + "\n---------------------------------------------------\n";

                block2 = false;
            }

            else if (player2Turn == true && block1 == false) //player 2's turn and player 1 is not blocking
            {
                dragonHP1 -= dragonATK2;
                rtbBattleLog.Text += "\n" + dragonName2 + " attacks " + dragonName1 + "! " + dragonName1 + " takes " + dragonATK2 + " damage, and is now on " + dragonHP1 + "HP"
                                 + "\n---------------------------------------------------\n";
            }
            else if (player2Turn == true && block1 == true) //player 2's turn and player 1 blocking
            {
                damage = dragonATK2 - dragonBLOCK1;
                if (damage >= 0)
                {
                    dragonHP1 -= dragonATK2;
                }
                else
                {
                    dragonHP1 -= 0;
                    damage = 0;
                }
                
                rtbBattleLog.Text += "\n" + dragonName2 + " attacks " + dragonName1 + "! " + dragonName1 + " takes " + damage + " damage, and is now on " + dragonHP1 + "HP"
                                                 + "\n---------------------------------------------------\n";
                block1 = false;
            }

            checkDead();

            playerTurn();
            counter++;

            //scrolling
            rtbBattleLog.SelectionStart = rtbBattleLog.Text.Length;
            rtbBattleLog.ScrollToCaret();

        }
        //
        //special attacking
        //
        private void btnPlayerSp_Click(object sender, EventArgs e)
        {
            int damage = 0;
            if (player1Turn == true && block2 == false)
            {
                dragonHP2 -= dragonSPATK1;
                rtbBattleLog.Text += "\n" + dragonName1 + " special attacks " + dragonName2 + "! " + dragonName2 + " takes " + dragonSPATK1 + " damage, and is now on " + dragonHP2 + "HP"
                                                 + "\n---------------------------------------------------\n";

                player1Rest = true;
                
            }
            else if (player1Turn == true)
            {
                if (block2 == true)
                {
                    dragonSPATK1 -= dragonBLOCK2;
                    if (damage >= 0)
                    {
                        dragonHP2 -= dragonSPATK1;
                    }
                }
                else
                {
                    dragonHP2 -= dragonSPATK1;
                }

                block2 = false;

                rtbBattleLog.Text += "\n" + dragonName1 + " special attacks " + dragonName2 + "! " + dragonName2 + " takes " + dragonSPATK1 + " damage, and is now on " + dragonHP2 + "HP"
                                                 + "\n---------------------------------------------------\n";

                player1Rest = true;
                
            }

            else if (player2Turn == true && block1 == false)
            {
                dragonHP1 -= dragonSPATK2;
                rtbBattleLog.Text += "\n" + dragonName2 + " special attacks " + dragonName1 + "! " + dragonName1 + " takes " + dragonSPATK2 + " damage, and is now on " + dragonHP1 + "HP"
                                 + "\n---------------------------------------------------\n";

                player2Rest = true;
                
            }
            else if (player2Turn == true)
            {
                if (block1 == true)
                {
                    dragonSPATK2 -= dragonBLOCK1;
                    if (dragonSPATK2 >= 0)
                    {
                        dragonHP1 -= dragonSPATK2;
                    }
                }
                else
                {
                    dragonHP1 -= dragonSPATK2;
                }

                block1 = false;

                rtbBattleLog.Text += "\n" + dragonName2 + " special attacks " + dragonName1 + "! " + dragonName1 + " takes " + dragonSPATK2 + " damage, and is now on " + dragonHP1 + "HP"
                                                 + "\n---------------------------------------------------\n";

                player2Rest = true;
                
            }

            
            checkDead();

            playerTurn();
            counter++;

            //scrolling
            rtbBattleLog.SelectionStart = rtbBattleLog.Text.Length;
            rtbBattleLog.ScrollToCaret();


        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (player1Rest == true)
            {
                rtbBattleLog.Text += dragonName1 + " is too tired to fight, and rests a while.";
                
                player1Rest = false;
            }
            if (player2Rest == true)
            {
                rtbBattleLog.Text += dragonName2 + " is too tired to fight, and rests a while.";
                
                player2Rest = false;
            }
            btnRest.Visible = false;

            playerTurn();
            counter++;

            //scrolling
            rtbBattleLog.SelectionStart = rtbBattleLog.Text.Length;
            rtbBattleLog.ScrollToCaret();
  
        }
    }
}
