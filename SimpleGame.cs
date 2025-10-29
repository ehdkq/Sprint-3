using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3
{
    internal class SimpleGame : BaseGame
    {
        public SimpleGame(int boardSize) : base(boardSize) { }

        public override void MakeMove(int row, int col, Cell move)
        {
            if (State != GameState.InProgress || GameBoard[row, col] != Cell.Empty)
            {
                return;
            }

            GameBoard[row, col] = move;
            MovesLeft--;
            CheckForWin(row, col);

            if (State == GameState.InProgress)
            {
                CurrentTurn = (CurrentTurn == Player.Blue) ? Player.Red : Player.Blue;
            }
        }

        protected override void CheckForWin(int r, int c)
        {
            int newSOSCount = FindSOS(r, c);

            if (newSOSCount > 0)
            {
                State = (CurrentTurn == Player.Blue) ? GameState.BlueWin : GameState.RedWin;
                return;
            }

            if (MovesLeft == 0 && State == GameState.InProgress)
            {
                State = GameState.Draw;
            }
        }

        private int FindSOS(int r, int c)
        {
            return 0;
        }
    }
}
