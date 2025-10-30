﻿namespace Sprint_3
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.blueSButton = new System.Windows.Forms.RadioButton();
            this.blueOButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.redSButton = new System.Windows.Forms.RadioButton();
            this.redOButton = new System.Windows.Forms.RadioButton();
            this.bluePlayer = new System.Windows.Forms.GroupBox();
            this.redPlayer = new System.Windows.Forms.GroupBox();
            this.simpleGameLabel = new System.Windows.Forms.Label();
            this.generalGameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameModeLabel = new System.Windows.Forms.Label();
            this.generalGameButton = new System.Windows.Forms.RadioButton();
            this.simpleGameButton = new System.Windows.Forms.RadioButton();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.numBoardSize = new System.Windows.Forms.NumericUpDown();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblBlueScore = new System.Windows.Forms.Label();
            this.lblRedScore = new System.Windows.Forms.Label();
            this.bluePlayer.SuspendLayout();
            this.redPlayer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoardSize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-1, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 66);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "SOS Game!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Blue Player";
            // 
            // blueSButton
            // 
            this.blueSButton.AutoSize = true;
            this.blueSButton.Checked = true;
            this.blueSButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueSButton.Location = new System.Drawing.Point(14, 49);
            this.blueSButton.Name = "blueSButton";
            this.blueSButton.Size = new System.Drawing.Size(32, 20);
            this.blueSButton.TabIndex = 2;
            this.blueSButton.TabStop = true;
            this.blueSButton.Text = "S";
            this.blueSButton.UseVisualStyleBackColor = true;
            // 
            // blueOButton
            // 
            this.blueOButton.AutoSize = true;
            this.blueOButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueOButton.Location = new System.Drawing.Point(14, 84);
            this.blueOButton.Name = "blueOButton";
            this.blueOButton.Size = new System.Drawing.Size(36, 20);
            this.blueOButton.TabIndex = 3;
            this.blueOButton.TabStop = true;
            this.blueOButton.Text = "O";
            this.blueOButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // redSButton
            // 
            this.redSButton.AutoSize = true;
            this.redSButton.Checked = true;
            this.redSButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redSButton.Location = new System.Drawing.Point(7, 47);
            this.redSButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redSButton.Name = "redSButton";
            this.redSButton.Size = new System.Drawing.Size(35, 23);
            this.redSButton.TabIndex = 5;
            this.redSButton.TabStop = true;
            this.redSButton.Text = "S";
            this.redSButton.UseVisualStyleBackColor = true;
            this.redSButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // redOButton
            // 
            this.redOButton.AutoSize = true;
            this.redOButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redOButton.Location = new System.Drawing.Point(7, 84);
            this.redOButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redOButton.Name = "redOButton";
            this.redOButton.Size = new System.Drawing.Size(40, 23);
            this.redOButton.TabIndex = 6;
            this.redOButton.TabStop = true;
            this.redOButton.Text = "O";
            this.redOButton.UseVisualStyleBackColor = true;
            this.redOButton.CheckedChanged += new System.EventHandler(this.redOButton_CheckedChanged);
            // 
            // bluePlayer
            // 
            this.bluePlayer.Controls.Add(this.blueOButton);
            this.bluePlayer.Controls.Add(this.blueSButton);
            this.bluePlayer.Controls.Add(this.textBox2);
            this.bluePlayer.Location = new System.Drawing.Point(8, 167);
            this.bluePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bluePlayer.Name = "bluePlayer";
            this.bluePlayer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bluePlayer.Size = new System.Drawing.Size(133, 129);
            this.bluePlayer.TabIndex = 7;
            this.bluePlayer.TabStop = false;
            // 
            // redPlayer
            // 
            this.redPlayer.Controls.Add(this.label1);
            this.redPlayer.Controls.Add(this.redOButton);
            this.redPlayer.Controls.Add(this.redSButton);
            this.redPlayer.Location = new System.Drawing.Point(749, 167);
            this.redPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redPlayer.Name = "redPlayer";
            this.redPlayer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redPlayer.Size = new System.Drawing.Size(133, 119);
            this.redPlayer.TabIndex = 8;
            this.redPlayer.TabStop = false;
            // 
            // simpleGameLabel
            // 
            this.simpleGameLabel.AutoSize = true;
            this.simpleGameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleGameLabel.Location = new System.Drawing.Point(11, 44);
            this.simpleGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.simpleGameLabel.Name = "simpleGameLabel";
            this.simpleGameLabel.Size = new System.Drawing.Size(151, 25);
            this.simpleGameLabel.TabIndex = 9;
            this.simpleGameLabel.Text = "Simple Game";
            // 
            // generalGameLabel
            // 
            this.generalGameLabel.AutoSize = true;
            this.generalGameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalGameLabel.Location = new System.Drawing.Point(304, 44);
            this.generalGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generalGameLabel.Name = "generalGameLabel";
            this.generalGameLabel.Size = new System.Drawing.Size(166, 25);
            this.generalGameLabel.TabIndex = 10;
            this.generalGameLabel.Text = "General Game";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameModeLabel);
            this.groupBox1.Controls.Add(this.generalGameButton);
            this.groupBox1.Controls.Add(this.simpleGameButton);
            this.groupBox1.Controls.Add(this.simpleGameLabel);
            this.groupBox1.Controls.Add(this.generalGameLabel);
            this.groupBox1.Location = new System.Drawing.Point(277, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(501, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // gameModeLabel
            // 
            this.gameModeLabel.AutoSize = true;
            this.gameModeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeLabel.Location = new System.Drawing.Point(11, 14);
            this.gameModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameModeLabel.Name = "gameModeLabel";
            this.gameModeLabel.Size = new System.Drawing.Size(161, 28);
            this.gameModeLabel.TabIndex = 12;
            this.gameModeLabel.Text = "Game Mode";
            this.gameModeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // generalGameButton
            // 
            this.generalGameButton.AutoSize = true;
            this.generalGameButton.Location = new System.Drawing.Point(471, 49);
            this.generalGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generalGameButton.Name = "generalGameButton";
            this.generalGameButton.Size = new System.Drawing.Size(14, 13);
            this.generalGameButton.TabIndex = 12;
            this.generalGameButton.TabStop = true;
            this.generalGameButton.UseVisualStyleBackColor = true;
            // 
            // simpleGameButton
            // 
            this.simpleGameButton.AutoSize = true;
            this.simpleGameButton.Checked = true;
            this.simpleGameButton.Location = new System.Drawing.Point(172, 49);
            this.simpleGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleGameButton.Name = "simpleGameButton";
            this.simpleGameButton.Size = new System.Drawing.Size(14, 13);
            this.simpleGameButton.TabIndex = 11;
            this.simpleGameButton.TabStop = true;
            this.simpleGameButton.UseVisualStyleBackColor = true;
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSizeLabel.Location = new System.Drawing.Point(772, 76);
            this.gridSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(113, 28);
            this.gridSizeLabel.TabIndex = 12;
            this.gridSizeLabel.Text = "Grid Size";
            // 
            // numBoardSize
            // 
            this.numBoardSize.Location = new System.Drawing.Point(775, 109);
            this.numBoardSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numBoardSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBoardSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numBoardSize.Name = "numBoardSize";
            this.numBoardSize.Size = new System.Drawing.Size(80, 20);
            this.numBoardSize.TabIndex = 13;
            this.numBoardSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numBoardSize.ValueChanged += new System.EventHandler(this.numBoardSize_ValueChanged);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(775, 130);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(80, 33);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "New Game!";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(304, 95);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(333, 325);
            this.pnlBoard.TabIndex = 15;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(9, 421);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(190, 25);
            this.lblTurn.TabIndex = 16;
            this.lblTurn.Text = "Current Turn: Blue";
            this.lblTurn.Click += new System.EventHandler(this.lblTurn_Click);
            // 
            // lblBlueScore
            // 
            this.lblBlueScore.AutoSize = true;
            this.lblBlueScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueScore.Location = new System.Drawing.Point(203, 296);
            this.lblBlueScore.Name = "lblBlueScore";
            this.lblBlueScore.Size = new System.Drawing.Size(59, 21);
            this.lblBlueScore.TabIndex = 17;
            this.lblBlueScore.Text = "Blue: 0";
            this.lblBlueScore.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblRedScore
            // 
            this.lblRedScore.AutoSize = true;
            this.lblRedScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedScore.Location = new System.Drawing.Point(204, 327);
            this.lblRedScore.Name = "lblRedScore";
            this.lblRedScore.Size = new System.Drawing.Size(58, 21);
            this.lblRedScore.TabIndex = 18;
            this.lblRedScore.Text = "Red: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(898, 483);
            this.Controls.Add(this.lblRedScore);
            this.Controls.Add(this.lblBlueScore);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.numBoardSize);
            this.Controls.Add(this.gridSizeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.redPlayer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bluePlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bluePlayer.ResumeLayout(false);
            this.bluePlayer.PerformLayout();
            this.redPlayer.ResumeLayout(false);
            this.redPlayer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoardSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton blueSButton;
        private System.Windows.Forms.RadioButton blueOButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton redSButton;
        private System.Windows.Forms.RadioButton redOButton;
        private System.Windows.Forms.GroupBox bluePlayer;
        private System.Windows.Forms.GroupBox redPlayer;
        private System.Windows.Forms.Label simpleGameLabel;
        private System.Windows.Forms.Label generalGameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gameModeLabel;
        private System.Windows.Forms.RadioButton generalGameButton;
        private System.Windows.Forms.RadioButton simpleGameButton;
        private System.Windows.Forms.Label gridSizeLabel;
        private System.Windows.Forms.NumericUpDown numBoardSize;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblBlueScore;
        private System.Windows.Forms.Label lblRedScore;
    }
}

