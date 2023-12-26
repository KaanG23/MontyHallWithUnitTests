using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MontyHall.Model;

namespace MontyHall
{
    public class GameSimulator
    {
        private readonly ResultModel _result;

        public GameSimulator()
        {
            _result = new ResultModel();
        }

        public void SimulateGame()
        {
            var consoleValidation = new ConsoleValidation();
            var gameSettings = consoleValidation.PrintUserView();
            var game = new Game();

            for (int i = 0; i < gameSettings.UserInputNumberOfGames; i++)
            {
                game.Play();

                if (gameSettings.UserInputChangeDoor && game.ChangeSelectedDoor()) _result.WinsChangingDoor++;

                if (!gameSettings.UserInputChangeDoor && !game.ChangeSelectedDoor()) _result.WinsNotChangingDoor++;
            }

            game.CalculateAndPrintResult(_result, gameSettings);
        }
    }
}
