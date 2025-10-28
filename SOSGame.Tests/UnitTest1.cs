using NUnit.Framework;
using Sprint_2; // Your project's namespace
using System;

namespace SOSGame.Tests
{
    [TestFixture]
    public class SOSGameTests
    {
        private Sprint_2.SOSGame game; // Using the full name to prevent conflicts

        [SetUp]
        public void Setup()
        {
            game = new Sprint_2.SOSGame();
        }

        [Test]
        // Tests AC 1.1: The system accepts a valid board size
        public void NewGame_AcceptsValidBoardSize_AC_1_1()
        {
            game.NewGame(5, GameMode.Simple);

            // Replaced Assert.AreEqual(5, game.BoardSize);
            Assert.That(game.BoardSize, Is.EqualTo(5));
        }

        [Test]
        // Tests AC 1.2: The system rejects an invalid board size (too small)
        public void NewGame_RejectsInvalidBoardSize_AC_1_2()
        {
            // Replaced Assert.Throws<...>(() => ...);
            Assert.That(() => game.NewGame(2, GameMode.Simple), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        // Tests AC 2.1: The player selects the "simple game" mode
        public void NewGame_SetsSimpleMode_AC_2_1()
        {
            game.NewGame(8, GameMode.Simple);

            // Replaced Assert.AreEqual(GameMode.Simple, game.Mode);
            Assert.That(game.Mode, Is.EqualTo(GameMode.Simple));
        }

        [Test]
        // Tests AC 2.2: The player selects the 'general game' mode
        public void NewGame_SetsGeneralMode_AC_2_2()
        {
            game.NewGame(8, GameMode.General);

            // Replaced Assert.AreEqual(GameMode.General, game.Mode);
            Assert.That(game.Mode, Is.EqualTo(GameMode.General));
        }

        [Test]
        // Tests AC 3.1: Displays blank board and says whose turn it is
        public void NewGame_InitializesBoardAndTurn_AC_3_1()
        {
            game.NewGame(8, GameMode.Simple);

            Assert.That(game.CurrentTurn, Is.EqualTo(Player.Blue));
            Assert.That(game.GameBoard[0, 0], Is.EqualTo(Cell.Empty));
            Assert.That(game.GameBoard[7, 7], Is.EqualTo(Cell.Empty));
        }

        [Test]
        // Tests AC 3.3: Needing to restart during a game
        public void NewGame_ResetsExistingGame_AC_3_3()
        {
            game.NewGame(8, GameMode.Simple);
            game.MakeMove(3, 3, Cell.S);

            game.NewGame(8, GameMode.Simple);

            Assert.That(game.CurrentTurn, Is.EqualTo(Player.Blue));
            Assert.That(game.GameBoard[3, 3], Is.EqualTo(Cell.Empty));
        }

        [Test]
        // Tests AC 4.1 & 6.1: A player makes a move
        public void MakeMove_PlacesTokenAndSwitchesTurn_AC_4_1_and_6_1()
        {
            game.NewGame(8, GameMode.Simple);

            bool result = game.MakeMove(4, 4, Cell.O);

            // Replaced Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(game.GameBoard[4, 4], Is.EqualTo(Cell.O));
            Assert.That(game.CurrentTurn, Is.EqualTo(Player.Red));
        }

        [Test]
        // Tests AC 4.2 & 6.3: A player makes a move in an already occupied square
        public void MakeMove_OnOccupiedCell_ReturnsFalse_AC_4_2_and_6_3()
        {
            game.NewGame(8, GameMode.Simple);
            game.MakeMove(1, 1, Cell.S);

            bool result = game.MakeMove(1, 1, Cell.O);

            // Replaced Assert.IsFalse(result);
            Assert.That(result, Is.False);
            Assert.That(game.CurrentTurn, Is.EqualTo(Player.Red));
            Assert.That(game.GameBoard[1, 1], Is.EqualTo(Cell.S));
        }
    }
}