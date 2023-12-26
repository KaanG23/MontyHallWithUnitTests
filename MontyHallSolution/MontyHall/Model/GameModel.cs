using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
