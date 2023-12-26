using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHall;
using MontyHall.Model;

namespace UnitTestMontyHall
{
    [TestClass]
    public class ValidateConsole
    {
        [TestMethod]
        public void ValidateUserInputNumberOfGames_ValidateInput()
        {
            GameSettingsModel settings = new GameSettingsModel();

            string userInput = "100";

            var consoleValidation = new ConsoleValidation();

            var result = consoleValidation.ValidateUserInputNumberOfGames(settings, userInput);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateUserInputNumberOfGames_ValidateGameSettingsModel()
        {
            GameSettingsModel settings = new GameSettingsModel();

            string userInput = "100";

            var consoleValidation = new ConsoleValidation();

            var result = consoleValidation.ValidateUserInputNumberOfGames(settings, userInput);

            Assert.AreEqual(100, settings.UserInputNumberOfGames);
        }

        [TestMethod]
        public void ValidateUserInputChangeDoor_YesInput()
        {
            GameSettingsModel settings = new GameSettingsModel();

            string userInput = "yes";

            var consoleValidation = new ConsoleValidation();

            var result = consoleValidation.ValidateUserInputChangeDoor(settings, userInput);

            Assert.IsTrue(result);
            Assert.IsTrue(settings.UserInputChangeDoor);
        }
    }
}
