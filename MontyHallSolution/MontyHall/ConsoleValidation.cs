using MontyHall.Model;
using System;

namespace MontyHall
{
    public class ConsoleValidation
    {
        public GameSettingsModel PrintUserView()
        {
            var gameSettings = new GameSettingsModel();
            Console.WriteLine("Welcome to Monty Hall simulator");

            Console.WriteLine("Enter the number of games you want to run: ");
            while (true)
            {
                var userInput = Console.ReadLine();
                bool isValid = ValidateUserInputNumberOfGames(gameSettings, userInput);
                if (isValid) break;

                Console.WriteLine("Invalid input type a number, 1 or greater");
            }

            Console.WriteLine("Do you want to change the door? Answer with either yes or no: ");
            while (true)
            {
                var userInput = Console.ReadLine();
                bool isValid = ValidateUserInputChangeDoor(gameSettings, userInput);
                if (isValid) break;

                Console.WriteLine("Invalid input, answer with either yes or no");
            }

            return gameSettings;
        }


        public bool ValidateUserInputNumberOfGames(GameSettingsModel gameSettings, string userInput)
        {
            if (int.TryParse(userInput, out int numberOfGames) && numberOfGames >= 1)
            {
                gameSettings.UserInputNumberOfGames = numberOfGames;
                return true;
            }

            return false;
        }

        public bool ValidateUserInputChangeDoor(GameSettingsModel gameSettings, string userInput)
        {
            if (userInput != null)
            {
                userInput = userInput.ToLower();

                if (userInput == "yes")
                {
                    gameSettings.UserInputChangeDoor = true;
                    return true;
                }

                if (userInput == "no")
                {
                    gameSettings.UserInputChangeDoor = false;
                    return true;
                }
            }

            return false;
        }
    }
}
