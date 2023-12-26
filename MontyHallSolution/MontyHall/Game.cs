using MontyHall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class Game
    {
        private readonly Random _random = new();
        private GameModel _gameModel;

        public void Play()
        {
            _gameModel = CreateAndRandomizeDoors();

            var prizeDoor = GetPrizeDoor(_gameModel);

            var userSelectDoor = UserSelectOneDoor(_gameModel);

            OpenOneDoor(_gameModel, prizeDoor, userSelectDoor);
        }

        public void OpenOneDoor(GameModel gameModel, int prizeDoor, int userSelectDoor)
        {
            do
            {
                gameModel.PresenterOpensDoor = _random.Next(gameModel.Doors.Count);

            } while (gameModel.PresenterOpensDoor == userSelectDoor || gameModel.PresenterOpensDoor == prizeDoor);
        }

        public int UserSelectOneDoor(GameModel gameModel)
        {
            return gameModel.UserSelectedDoor = _random.Next(gameModel.Doors.Count);
        }

        public int GetPrizeDoor(GameModel gameModel)
        {
            return gameModel.Doors.FindIndex(prize => prize == Prizes.Car);
        }

        public GameModel CreateAndRandomizeDoors()
        {
            var gameModel = new GameModel
            {
                Doors = new List<Prizes>
                {   
                    Prizes.Car,
                    Prizes.Goat,
                    Prizes.Goat
                }
            };

            gameModel.Doors = gameModel.Doors.OrderBy(randomPrize => _random.Next()).ToList();

            return gameModel;
        }

        public bool ChangeSelectedDoor()
        {
            for (int i = 0; i < _gameModel.Doors.Count; i++)
            {
                if (i != _gameModel.UserSelectedDoor && i != _gameModel.PresenterOpensDoor)
                {
                    _gameModel.UserSelectedDoor = i;
                    break;
                }
            }

            return _gameModel.Doors[_gameModel.UserSelectedDoor] == Prizes.Car;
        }

        public void CalculateAndPrintResult(ResultModel result, GameSettingsModel gameSettings)
        {
            if (gameSettings.UserInputChangeDoor)
            {
                result.WinsChangingDoorPercent = (decimal)result.WinsChangingDoor / gameSettings.UserInputNumberOfGames * 100;
                Console.WriteLine($"Win percentage when changing door: {result.WinsChangingDoorPercent:F}%");
                Console.WriteLine($"Wins when changing door: {result.WinsChangingDoor}");
            }
            else
            {
                result.WinsChangingDoorPercent = (decimal)result.WinsNotChangingDoor / gameSettings.UserInputNumberOfGames * 100;
                Console.WriteLine($"Win percentage when not changing door: {result.WinsNotChangingDoorPercent:F}%");
                Console.WriteLine($"Wins when not changing door: {result.WinsNotChangingDoor}");
            }
        }
    }
}
