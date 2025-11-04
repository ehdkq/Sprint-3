using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3
{
    public enum Cell { Empty, S, O}
    public enum Player { Blue, Red}
    public enum GameMode { Simple, General }
    public enum GameState { InProgress, BlueWin, RedWin, Draw }

    public abstract class BaseGame
    {
        public int BoardSize { get; protected set; }
        public Cell[,] GameBoard { get; protected set; }
        public Player CurrentTurn { get; protected set; }
        public GameState State { get; protected set; }
        public int BlueScore { get; protected set; }
        public int RedScore { get; protected set;}
        public int MovesLeft { get; protected set; }

        public BaseGame(int boardSize)
        {
            BoardSize = boardSize;
            GameBoard = new Cell[BoardSize, BoardSize];
            CurrentTurn = Player.Blue;
            State = GameState.InProgress;
            BlueScore = 0;
            RedScore = 0;
            MovesLeft = boardSize * boardSize;

            for (int r = 0; r < BoardSize; r++)
            {
                for (int c = 0; c < BoardSize; c++)
                {
                    GameBoard[r, c] = Cell.Empty;
                }
            }
        }

        public abstract void MakeMove(int row, int col, Cell move);

        protected abstract void CheckForWin(int r, int c);
    }
}