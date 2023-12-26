using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall.Model
{
    public class ResultModel
    {
        public int WinsChangingDoor { get; set; }
        public int WinsNotChangingDoor { get; set; }

        public decimal WinsChangingDoorPercent { get; set; }
        public decimal WinsNotChangingDoorPercent { get; set; }

    }
}
