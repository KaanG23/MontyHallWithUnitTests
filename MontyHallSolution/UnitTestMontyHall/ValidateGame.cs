using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHall;
using MontyHall.Model;

namespace UnitTestMontyHall
{
    [TestClass]
    public class ValidateGame
    {
        [TestMethod]
        public void Game_UserSelectOneDoor()
        {
            var game = new Game();
            var gameModel = game.CreateAndRandomizeDoors();

            var selectedDoor = game.UserSelectOneDoor(gameModel);

            Assert.IsTrue(selectedDoor >= 0 && selectedDoor < gameModel.Doors.Count);
        }

        [TestMethod]
        public void Game_IsPrizeCar()
        {
            var game = new Game();
            var gameModel = game.CreateAndRandomizeDoors();

            var prizeDoor = game.GetPrizeDoor(gameModel);

            Assert.AreEqual(gameModel.Doors.FindIndex(prize => prize == Prizes.Car), prizeDoor);
        }

        [TestMethod]
        public void Game_OpenDifferentDoor()
        {
            var game = new Game();
            var gameModel = game.CreateAndRandomizeDoors();
            var prizeDoor = game.GetPrizeDoor(gameModel);
            var selectedDoor = game.UserSelectOneDoor(gameModel);

            game.OpenOneDoor(gameModel, prizeDoor, selectedDoor);

            Assert.AreNotEqual(gameModel.PresenterOpensDoor, selectedDoor);
            Assert.AreNotEqual(gameModel.PresenterOpensDoor, prizeDoor);
        }
    }
}
