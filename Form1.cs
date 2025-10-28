using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint_3
{
    public partial class Form1 : Form
    {
        private SOSGame game;
        private Button[,] gridButtons;

        public Form1()
        {
            InitializeComponent();
            game = new SOSGame(); //sets game variable to SOSGame
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e) //what happens when you click the new game button
        {
            int boardSize = (int)numBoardSize.Value; //declares the boardSize the user inputs from the field

            var mode = simpleGameButton.Checked ? GameMode.Simple : GameMode.General; //checks which game mode is selected

            game.NewGame(boardSize, mode); //starts the game

            CreateBoardGrid(boardSize); //creates the grid based on the boardSize

            UpdateTurnLabel(); //updates the turn (red or blue)
        }
        
        private void CreateBoardGrid(int size)
        {
            pnlBoard.Controls.Clear(); //clears board
            gridButtons = new Button[size, size]; //sets the buttons on the grid
            int buttonSize = pnlBoard.Width / size; //sets the size for the buttons

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    var button = new Button
                    {
                        //sets all the button parameters
                        Width = buttonSize,
                        Height = buttonSize,
                        Left = col * buttonSize,
                        Top = row * buttonSize,
                        Tag = new Point(row, col)
                    };

                    button.Click += GridButton_Click;
                    pnlBoard.Controls.Add(button);
                    gridButtons[row, col] = button;
                }
            }
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Point position = (Point)clickedButton.Tag;

            Cell move; 

            if (game.CurrentTurn == Player.Blue) //if the turn is the blue player, put the s or o down
            {
                move = blueSButton.Checked ? Cell.S : Cell.O;
            }
            else
            {
                move = redSButton.Checked ? Cell.S : Cell.O; //if not, put it for the red player
            }
            if (game.MakeMove(position.X, position.Y, move)) //function for the moves
            {
                clickedButton.Text = move.ToString();
                clickedButton.Enabled = false;
                UpdateTurnLabel();
            }
        }

        private void UpdateTurnLabel() //updates turn label from red to blue and vice versa
        {
            lblTurn.Text = $"Current Turn: {game.CurrentTurn}";

            if (game.CurrentTurn == Player.Blue)
            {
                bluePlayer.Enabled = true ; //switches from blue to red
                redPlayer.Enabled = false;
            }
            else
            {
                bluePlayer.Enabled = false; //switches from red to blue
                redPlayer.Enabled = true ; 
            }
        }
        private void numBoardSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTurn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void redOButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
