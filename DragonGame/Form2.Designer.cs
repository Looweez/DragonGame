namespace DragonGame
{
    partial class frmBattle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxPlayer1Dragon = new System.Windows.Forms.GroupBox();
            this.btnPlayer1Block = new System.Windows.Forms.Button();
            this.btnPlayer1Sp = new System.Windows.Forms.Button();
            this.btnPlayer1Atk = new System.Windows.Forms.Button();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.gbxBattleLog = new System.Windows.Forms.GroupBox();
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.gbxOpponent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpponentDragon = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            this.gbxPlayer1Dragon.SuspendLayout();
            this.gbxBattleLog.SuspendLayout();
            this.gbxOpponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlayer1Dragon
            // 
            this.gbxPlayer1Dragon.Controls.Add(this.btnRest);
            this.gbxPlayer1Dragon.Controls.Add(this.btnPlayer1Block);
            this.gbxPlayer1Dragon.Controls.Add(this.btnPlayer1Sp);
            this.gbxPlayer1Dragon.Controls.Add(this.btnPlayer1Atk);
            this.gbxPlayer1Dragon.Controls.Add(this.lblPlayerHP);
            this.gbxPlayer1Dragon.Location = new System.Drawing.Point(12, 12);
            this.gbxPlayer1Dragon.Name = "gbxPlayer1Dragon";
            this.gbxPlayer1Dragon.Size = new System.Drawing.Size(362, 289);
            this.gbxPlayer1Dragon.TabIndex = 0;
            this.gbxPlayer1Dragon.TabStop = false;
            this.gbxPlayer1Dragon.Text = "X the X Dragon\'s Turn";
            // 
            // btnPlayer1Block
            // 
            this.btnPlayer1Block.Location = new System.Drawing.Point(17, 212);
            this.btnPlayer1Block.Name = "btnPlayer1Block";
            this.btnPlayer1Block.Size = new System.Drawing.Size(329, 56);
            this.btnPlayer1Block.TabIndex = 3;
            this.btnPlayer1Block.Text = "Block";
            this.btnPlayer1Block.UseVisualStyleBackColor = true;
            // 
            // btnPlayer1Sp
            // 
            this.btnPlayer1Sp.Location = new System.Drawing.Point(18, 150);
            this.btnPlayer1Sp.Name = "btnPlayer1Sp";
            this.btnPlayer1Sp.Size = new System.Drawing.Size(329, 56);
            this.btnPlayer1Sp.TabIndex = 2;
            this.btnPlayer1Sp.Text = "Special Attack";
            this.btnPlayer1Sp.UseVisualStyleBackColor = true;
            // 
            // btnPlayer1Atk
            // 
            this.btnPlayer1Atk.Location = new System.Drawing.Point(18, 88);
            this.btnPlayer1Atk.Name = "btnPlayer1Atk";
            this.btnPlayer1Atk.Size = new System.Drawing.Size(329, 56);
            this.btnPlayer1Atk.TabIndex = 1;
            this.btnPlayer1Atk.Text = "Attack";
            this.btnPlayer1Atk.UseVisualStyleBackColor = true;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.Location = new System.Drawing.Point(138, 37);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(90, 31);
            this.lblPlayerHP.TabIndex = 0;
            this.lblPlayerHP.Text = "HP: X";
            // 
            // gbxBattleLog
            // 
            this.gbxBattleLog.Controls.Add(this.rtbBattleLog);
            this.gbxBattleLog.Location = new System.Drawing.Point(12, 316);
            this.gbxBattleLog.Name = "gbxBattleLog";
            this.gbxBattleLog.Size = new System.Drawing.Size(636, 166);
            this.gbxBattleLog.TabIndex = 1;
            this.gbxBattleLog.TabStop = false;
            this.gbxBattleLog.Text = "Battle Log";
            // 
            // rtbBattleLog
            // 
            this.rtbBattleLog.Location = new System.Drawing.Point(6, 19);
            this.rtbBattleLog.Name = "rtbBattleLog";
            this.rtbBattleLog.Size = new System.Drawing.Size(621, 141);
            this.rtbBattleLog.TabIndex = 0;
            this.rtbBattleLog.Text = "";
            // 
            // gbxOpponent
            // 
            this.gbxOpponent.Controls.Add(this.label1);
            this.gbxOpponent.Controls.Add(this.lblOpponentDragon);
            this.gbxOpponent.Location = new System.Drawing.Point(420, 89);
            this.gbxOpponent.Name = "gbxOpponent";
            this.gbxOpponent.Size = new System.Drawing.Size(228, 148);
            this.gbxOpponent.TabIndex = 2;
            this.gbxOpponent.TabStop = false;
            this.gbxOpponent.Text = "Opponent X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "X, the X Dragon";
            // 
            // lblOpponentDragon
            // 
            this.lblOpponentDragon.AutoSize = true;
            this.lblOpponentDragon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentDragon.Location = new System.Drawing.Point(63, 80);
            this.lblOpponentDragon.Name = "lblOpponentDragon";
            this.lblOpponentDragon.Size = new System.Drawing.Size(90, 31);
            this.lblOpponentDragon.TabIndex = 1;
            this.lblOpponentDragon.Text = "HP: X";
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(19, 88);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(328, 180);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(671, 494);
            this.Controls.Add(this.gbxOpponent);
            this.Controls.Add(this.gbxBattleLog);
            this.Controls.Add(this.gbxPlayer1Dragon);
            this.Name = "frmBattle";
            this.Text = "Battle Log";
            this.gbxPlayer1Dragon.ResumeLayout(false);
            this.gbxPlayer1Dragon.PerformLayout();
            this.gbxBattleLog.ResumeLayout(false);
            this.gbxOpponent.ResumeLayout(false);
            this.gbxOpponent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlayer1Dragon;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Button btnPlayer1Block;
        private System.Windows.Forms.Button btnPlayer1Sp;
        private System.Windows.Forms.Button btnPlayer1Atk;
        private System.Windows.Forms.GroupBox gbxBattleLog;
        private System.Windows.Forms.RichTextBox rtbBattleLog;
        private System.Windows.Forms.GroupBox gbxOpponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpponentDragon;
        private System.Windows.Forms.Button btnRest;
    }
}