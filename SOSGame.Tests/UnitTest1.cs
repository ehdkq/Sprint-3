using NUnit.Framework;
using Sprint_3;
using System;

namespace Sprint_3.Tests
{
    [TestFixture]
    public class SOSGameTests
    {
        [Test]
        //user story 5, simple game test
        public void SimpleGame_FirstSOS_WinsTheGame()
        {
            BaseGame game = new SimpleGame(5);

            //moves to create sos
            game.MakeMove(0, 0, Cell.S); //blue turn
            game.MakeMove(1, 1, Cell.S); //red turn
            game.MakeMove(0, 1, Cell.O); //blue turn
            game.MakeMove(1, 2, Cell.S); //red turn
            game.MakeMove(0, 2, Cell.S); //blue final turn

            //sets the game state to blue winning
            Assert.That(game.State, Is.EqualTo(GameState.BlueWin));
        }

        [Test]
        //user story 5, simple game draw
        public void SimpleGame_FullBoard_NoSOS_IsDraw()
        {
            BaseGame game = new SimpleGame(3);

            //set the whole board to just s
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    //switch turn after move
                    game.MakeMove(r, c, Cell.S);
                }
            }

            Assert.That(game.MovesLeft, Is.EqualTo(0));
            Assert.That(game.State, Is.EqualTo(GameState.Draw));
        }

        [Test]
        //user story 6, making an sos gives extra turn in general game
        public void GeneralGame_SOS_GivesPointAndExtraTurn()
        {
            BaseGame game = new GeneralGame(5);

            //make an sos
            game.MakeMove(0, 0, Cell.S); //blue turn
            game.MakeMove(0, 1, Cell.O); //blue turn
            game.MakeMove(0, 2, Cell.S); //blue turn, should score

            Assert.That(game.BlueScore, Is.EqualTo(1));
            Assert.That(game.CurrentTurn, Is.EqualTo(Player.Blue)); //blue gets another turn
        }

        [Test]
        //user story 6, switches turn due to no sos
        public void GeneralGame_NoSOS_SwitchesTurn()
        {
            BaseGame game = new GeneralGame(5);

            game.MakeMove(0, 0, Cell.S); //blue turn

            Assert.That(game.BlueScore, Is.EqualTo(0));
            Assert.That(game.CurrentTurn, Is.EqualTo(Player.Red)); //switches to red turn
        }

        [Test]
        //user story 7, general game has a winner
        public void GeneralGame_FullBoard_HighestScoreWins()
        {
            BaseGame game = new GeneralGame(3);

            //make an sos
            game.MakeMove(0, 0, Cell.S); //blue turn
            game.MakeMove(0, 1, Cell.O); //blue turn
            game.MakeMove(0, 2, Cell.S); //blue turn, blue scores 1 point and gets another turn

            //fills board, no other scores
            game.MakeMove(1, 0, Cell.S); //blue turn
            game.MakeMove(1, 1, Cell.S); //red turn
            game.MakeMove(1, 2, Cell.S); //blue turn
            game.MakeMove(2, 0, Cell.S); //red turn
            game.MakeMove(2, 1, Cell.S); //blue turn
            game.MakeMove(2, 2, Cell.S); //red turn

            Assert.That(game.MovesLeft, Is.EqualTo(0));
            Assert.That(game.BlueScore, Is.EqualTo(1));
            Assert.That(game.RedScore, Is.EqualTo(0));
            Assert.That(game.State, Is.EqualTo(GameState.BlueWin)); //blue wins
        }

        [Test]
        //user story 7, general game draw
        public void GeneralGame_FullBoard_EqualScore_IsDraw()
        {
            BaseGame game = new GeneralGame(3);

            //fills board with just s, so no score
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    game.MakeMove(r, c, Cell.S);
                }
            }

            Assert.That(game.MovesLeft, Is.EqualTo(0));
            Assert.That(game.BlueScore, Is.EqualTo(0));
            Assert.That(game.RedScore, Is.EqualTo(0));
            Assert.That(game.State, Is.EqualTo(GameState.Draw)); //draw game
        }
    }
}