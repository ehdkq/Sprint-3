using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3
{
    public class GeneralGame : BaseGame
    {
        public GeneralGame(int boardSize) : base(boardSize) { }

        public override void MakeMove(int row, int col, Cell move)
        {
            if (State != GameState.InProgress || GameBoard[row, col] != Cell.Empty)
            {
                return;
            }

            GameBoard[row, col] = move;
            MovesLeft--;
            CheckForWin(row, col);
        }

        protected override void CheckForWin(int r, int c)
        {
            int newSOSCount = FindSOS(r, c);

            if (newSOSCount > 0)
            {
                if (CurrentTurn == Player.Blue)
                {
                    BlueScore += newSOSCount;
                }
                else
                {
                    RedScore += newSOSCount;
                }
            }
            else
            {
                CurrentTurn = (CurrentTurn == Player.Blue) ? Player.Red : Player.Blue;
            }

            if (MovesLeft == 0)
            {
                if (BlueScore > RedScore)
                {
                    State = GameState.BlueWin;
                }
                else if(RedScore > BlueScore) {
                    State = GameState.RedWin;
                }
                else
                {
                    State = GameState.Draw;
                }
            }
        }
        private int FindSOS(int r, int c)
        {
            return 0;
        }
    }
}
