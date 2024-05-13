﻿using System;
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

        bool block = false;
        bool player1Turn = false;
        bool player2Turn = false;

        int player1Roll;
        int player2Roll;



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
            while (player1Roll == player2Roll) //if equal roll again
            {
                player1Roll = randomRoll();
                player2Roll = randomRoll();
            }

            if (player1Roll > player2Roll)  //if player 1's roll is higher, then they take the initiative
            {
                rtbBattleLog.Text = playerName1 + "'s dragon " + dragonName1 + " takes initiative!"
                                                 + "\n---------------------------------------------------\n" + playerName1 + "'s turn:";
                //current players turn gbx
                gbxTurnPlayerDragon.Text = dragonName1 + " the " + dragonType1 + "'s turn";
                lblPlayerHP.Text = "HP: " + dragonHP1;

                //opponent gbx
                gbxOpponent.Text = "Opponent: " + playerName2;
                lblOpponentDragon.Text = dragonName2 + ", the " + dragonType2;
                lblOpponentHP.Text = "HP: " + dragonHP2;

                player1Turn = true;
                player2Turn = false;

                return player1Roll;
            }
            else if (player1Roll < player2Roll)  //if player 2's roll is higher, then they take the initiative
            {
                rtbBattleLog.Text = playerName1 + "'s dragon " + dragonName1 + " takes initiative!"
                                                 + "\n---------------------------------------------------\n" + playerName1 + "'s turn:";
                //current players turn gbx
                gbxTurnPlayerDragon.Text = dragonName2 + " the " + dragonType2 + "'s turn";
                lblPlayerHP.Text = "HP: " + dragonHP2;

                //opponent gbx
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

        private void btnPlayerBlock_Click(object sender, EventArgs e) //blocking
        {
            if (player1Turn == true)
            {
                block = true;
                rtbBattleLog.Text = dragonName1 + " blocks for " + dragonBLOCK1 + " damage!";
            }
            else if (player2Turn == true)
            {
                block = true;
                rtbBattleLog.Text = dragonName1 + " blocks for " + dragonBLOCK1 + " damage!";
            }
        }

        private void btnPlayerAtk_Click(object sender, EventArgs e) //attacking
        {
            if (player1Turn == true && block == false)
            {
                dragonHP2 -= dragonATK1;
                rtbBattleLog.Text = dragonName1 + " attacks " + dragonName2 + "!" + dragonName2 + " takes " + dragonATK1 + " damage, and is now on " + dragonHP2 + "HP"
                                                 + "\n---------------------------------------------------\n";
            }
            else if (player1Turn == true && block == true)
            {
                dragonATK1 -= dragonBLOCK2;
                if (dragonATK1 <= 0)
                {
                    dragonATK1 = 0;
                }
                dragonATK1 -= dragonHP2;
                rtbBattleLog.Text = dragonName1 + " attacks " + dragonName2 + "!" + dragonName2 + " takes " + dragonATK1 + " damage, and is now on " + dragonHP2 + "HP"
                                                 + "\n---------------------------------------------------\n";
            }

            if (player2Turn == true && block == false)
            {
                dragonHP1 -= dragonATK2;
                rtbBattleLog.Text = dragonName2 + " attacks " + dragonName1 + "!" + dragonName1 + " takes " + dragonATK2 + " damage, and is now on " + dragonHP1 + "HP"
                                 + "\n---------------------------------------------------\n";
            }
            else if (player2Turn == true && block == true)
            {
                dragonATK2 -= dragonBLOCK1;
                if (dragonATK2 <= 0)
                {
                    dragonATK2 = 0;
                }
                dragonATK2 -= dragonHP1;
                rtbBattleLog.Text = dragonName2 + " attacks " + dragonName1 + "!" + dragonName1 + " takes " + dragonATK2 + " damage, and is now on " + dragonHP1 + "HP"
                                                 + "\n---------------------------------------------------\n";
            }
        }

        private void btnPlayerSp_Click(object sender, EventArgs e) //special attack
        {
            if (player1Turn == true && block == false)
            {
                dragonHP2 -= dragonSPATK1;
            }
        }
    }
}
