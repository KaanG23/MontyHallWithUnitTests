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
