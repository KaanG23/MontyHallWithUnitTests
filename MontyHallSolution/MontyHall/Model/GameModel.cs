using System.Collections.Generic;

namespace MontyHall.Model
{
    public class GameModel
    {
        public List<Prizes> Doors { get; set; }
        public int UserSelectedDoor { get; set; }
        public int PresenterOpensDoor { get; set; }
    }

    public enum Prizes
    {
        Car,
        Goat
    }
}
