using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall.Model
{
    public class GameModel
    {
        public List<Prizes> DoorList { get; set; }
        public int SelectedDoor { get; set; }
        public int PresenterOpenedDoor { get; set; }
    }

    public enum Prizes
    {
        Car,
        Goat
    }
}
