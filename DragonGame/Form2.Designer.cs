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
            this.gbxTurnPlayerDragon = new System.Windows.Forms.GroupBox();
            this.btnPlayerBlock = new System.Windows.Forms.Button();
            this.btnPlayerSp = new System.Windows.Forms.Button();
            this.btnPlayerAtk = new System.Windows.Forms.Button();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            this.gbxBattleLog = new System.Windows.Forms.GroupBox();
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.gbxOpponent = new System.Windows.Forms.GroupBox();
            this.lblOpponentDragon = new System.Windows.Forms.Label();
            this.lblOpponentHP = new System.Windows.Forms.Label();
            this.gbxTurnPlayerDragon.SuspendLayout();
            this.gbxBattleLog.SuspendLayout();
            this.gbxOpponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTurnPlayerDragon
            // 
            this.gbxTurnPlayerDragon.Controls.Add(this.btnRest);
            this.gbxTurnPlayerDragon.Controls.Add(this.btnPlayerBlock);
            this.gbxTurnPlayerDragon.Controls.Add(this.btnPlayerSp);
            this.gbxTurnPlayerDragon.Controls.Add(this.btnPlayerAtk);
            this.gbxTurnPlayerDragon.Controls.Add(this.lblPlayerHP);
            this.gbxTurnPlayerDragon.Location = new System.Drawing.Point(12, 12);
            this.gbxTurnPlayerDragon.Name = "gbxTurnPlayerDragon";
            this.gbxTurnPlayerDragon.Size = new System.Drawing.Size(362, 289);
            this.gbxTurnPlayerDragon.TabIndex = 0;
            this.gbxTurnPlayerDragon.TabStop = false;
            this.gbxTurnPlayerDragon.Text = "X the X Dragon\'s Turn";
            // 
            // btnPlayerBlock
            // 
            this.btnPlayerBlock.Location = new System.Drawing.Point(17, 212);
            this.btnPlayerBlock.Name = "btnPlayerBlock";
            this.btnPlayerBlock.Size = new System.Drawing.Size(329, 56);
            this.btnPlayerBlock.TabIndex = 3;
            this.btnPlayerBlock.Text = "Block";
            this.btnPlayerBlock.UseVisualStyleBackColor = true;
            this.btnPlayerBlock.Click += new System.EventHandler(this.btnPlayerBlock_Click);
            // 
            // btnPlayerSp
            // 
            this.btnPlayerSp.Location = new System.Drawing.Point(18, 150);
            this.btnPlayerSp.Name = "btnPlayerSp";
            this.btnPlayerSp.Size = new System.Drawing.Size(329, 56);
            this.btnPlayerSp.TabIndex = 2;
            this.btnPlayerSp.Text = "Special Attack";
            this.btnPlayerSp.UseVisualStyleBackColor = true;
            this.btnPlayerSp.Click += new System.EventHandler(this.btnPlayerSp_Click);
            // 
            // btnPlayerAtk
            // 
            this.btnPlayerAtk.Location = new System.Drawing.Point(18, 88);
            this.btnPlayerAtk.Name = "btnPlayerAtk";
            this.btnPlayerAtk.Size = new System.Drawing.Size(329, 56);
            this.btnPlayerAtk.TabIndex = 1;
            this.btnPlayerAtk.Text = "Attack";
            this.btnPlayerAtk.UseVisualStyleBackColor = true;
            this.btnPlayerAtk.Click += new System.EventHandler(this.btnPlayerAtk_Click);
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
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(18, 88);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(328, 183);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
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
            this.gbxOpponent.Controls.Add(this.lblOpponentDragon);
            this.gbxOpponent.Controls.Add(this.lblOpponentHP);
            this.gbxOpponent.Location = new System.Drawing.Point(420, 89);
            this.gbxOpponent.Name = "gbxOpponent";
            this.gbxOpponent.Size = new System.Drawing.Size(228, 148);
            this.gbxOpponent.TabIndex = 2;
            this.gbxOpponent.TabStop = false;
            this.gbxOpponent.Text = "Opponent X";
            // 
            // lblOpponentDragon
            // 
            this.lblOpponentDragon.AutoSize = true;
            this.lblOpponentDragon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentDragon.Location = new System.Drawing.Point(35, 43);
            this.lblOpponentDragon.Name = "lblOpponentDragon";
            this.lblOpponentDragon.Size = new System.Drawing.Size(161, 24);
            this.lblOpponentDragon.TabIndex = 2;
            this.lblOpponentDragon.Text = "X, the X Dragon";
            // 
            // lblOpponentHP
            // 
            this.lblOpponentHP.AutoSize = true;
            this.lblOpponentHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHP.Location = new System.Drawing.Point(63, 80);
            this.lblOpponentHP.Name = "lblOpponentHP";
            this.lblOpponentHP.Size = new System.Drawing.Size(90, 31);
            this.lblOpponentHP.TabIndex = 1;
            this.lblOpponentHP.Text = "HP: X";
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(685, 495);
            this.Controls.Add(this.gbxOpponent);
            this.Controls.Add(this.gbxBattleLog);
            this.Controls.Add(this.gbxTurnPlayerDragon);
            this.Name = "frmBattle";
            this.Text = "Battle Log";
            this.Load += new System.EventHandler(this.frmBattle_Load);
            this.gbxTurnPlayerDragon.ResumeLayout(false);
            this.gbxTurnPlayerDragon.PerformLayout();
            this.gbxBattleLog.ResumeLayout(false);
            this.gbxOpponent.ResumeLayout(false);
            this.gbxOpponent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTurnPlayerDragon;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Button btnPlayerBlock;
        private System.Windows.Forms.Button btnPlayerSp;
        private System.Windows.Forms.Button btnPlayerAtk;
        private System.Windows.Forms.GroupBox gbxBattleLog;
        private System.Windows.Forms.RichTextBox rtbBattleLog;
        private System.Windows.Forms.GroupBox gbxOpponent;
        private System.Windows.Forms.Label lblOpponentDragon;
        private System.Windows.Forms.Label lblOpponentHP;
        private System.Windows.Forms.Button btnRest;
    }
}