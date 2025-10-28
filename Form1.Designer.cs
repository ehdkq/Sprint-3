namespace Sprint_3
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
            this.simpleGameButton = new System.Windows.Forms.RadioButton();
            this.generalGameButton = new System.Windows.Forms.RadioButton();
            this.gameModeLabel = new System.Windows.Forms.Label();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.numBoardSize = new System.Windows.Forms.NumericUpDown();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblTurn = new System.Windows.Forms.Label();
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
            this.textBox1.Location = new System.Drawing.Point(-2, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 66);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "SOS Game!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(7, 7);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Blue Player";
            // 
            // blueSButton
            // 
            this.blueSButton.AutoSize = true;
            this.blueSButton.Checked = true;
            this.blueSButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueSButton.Location = new System.Drawing.Point(21, 75);
            this.blueSButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.blueOButton.Location = new System.Drawing.Point(21, 130);
            this.blueOButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.label1.Location = new System.Drawing.Point(6, 22);
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
            this.redSButton.Location = new System.Drawing.Point(10, 72);
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
            this.redOButton.Location = new System.Drawing.Point(10, 130);
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
            this.bluePlayer.Location = new System.Drawing.Point(12, 257);
            this.bluePlayer.Name = "bluePlayer";
            this.bluePlayer.Size = new System.Drawing.Size(200, 199);
            this.bluePlayer.TabIndex = 7;
            this.bluePlayer.TabStop = false;
            // 
            // redPlayer
            // 
            this.redPlayer.Controls.Add(this.label1);
            this.redPlayer.Controls.Add(this.redOButton);
            this.redPlayer.Controls.Add(this.redSButton);
            this.redPlayer.Location = new System.Drawing.Point(1123, 257);
            this.redPlayer.Name = "redPlayer";
            this.redPlayer.Size = new System.Drawing.Size(200, 183);
            this.redPlayer.TabIndex = 8;
            this.redPlayer.TabStop = false;
            // 
            // simpleGameLabel
            // 
            this.simpleGameLabel.AutoSize = true;
            this.simpleGameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleGameLabel.Location = new System.Drawing.Point(17, 68);
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
            this.generalGameLabel.Location = new System.Drawing.Point(456, 68);
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
            this.groupBox1.Location = new System.Drawing.Point(416, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // simpleGameButton
            // 
            this.simpleGameButton.AutoSize = true;
            this.simpleGameButton.Checked = true;
            this.simpleGameButton.Location = new System.Drawing.Point(258, 76);
            this.simpleGameButton.Name = "simpleGameButton";
            this.simpleGameButton.Size = new System.Drawing.Size(14, 13);
            this.simpleGameButton.TabIndex = 11;
            this.simpleGameButton.TabStop = true;
            this.simpleGameButton.UseVisualStyleBackColor = true;
            // 
            // generalGameButton
            // 
            this.generalGameButton.AutoSize = true;
            this.generalGameButton.Location = new System.Drawing.Point(707, 76);
            this.generalGameButton.Name = "generalGameButton";
            this.generalGameButton.Size = new System.Drawing.Size(14, 13);
            this.generalGameButton.TabIndex = 12;
            this.generalGameButton.TabStop = true;
            this.generalGameButton.UseVisualStyleBackColor = true;
            // 
            // gameModeLabel
            // 
            this.gameModeLabel.AutoSize = true;
            this.gameModeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeLabel.Location = new System.Drawing.Point(17, 22);
            this.gameModeLabel.Name = "gameModeLabel";
            this.gameModeLabel.Size = new System.Drawing.Size(161, 28);
            this.gameModeLabel.TabIndex = 12;
            this.gameModeLabel.Text = "Game Mode";
            this.gameModeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSizeLabel.Location = new System.Drawing.Point(1158, 117);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(113, 28);
            this.gridSizeLabel.TabIndex = 12;
            this.gridSizeLabel.Text = "Grid Size";
            // 
            // numBoardSize
            // 
            this.numBoardSize.Location = new System.Drawing.Point(1163, 168);
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
            this.numBoardSize.Size = new System.Drawing.Size(120, 26);
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
            this.btnNewGame.Location = new System.Drawing.Point(1163, 200);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 51);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "New Game!";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(456, 146);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(500, 500);
            this.pnlBoard.TabIndex = 15;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(14, 648);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(190, 25);
            this.lblTurn.TabIndex = 16;
            this.lblTurn.Text = "Current Turn: Blue";
            this.lblTurn.Click += new System.EventHandler(this.lblTurn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1347, 743);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.numBoardSize);
            this.Controls.Add(this.gridSizeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.redPlayer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bluePlayer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

