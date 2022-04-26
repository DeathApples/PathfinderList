namespace DiceRoll.Model
{
    public class HealthPoints
    {
        public int Total { get; set; }
        public int Current { get; set; }
        public int Temporary { get; set; }

        public HealthPoints()
        {
            Total = 0;
            Current = 0;
            Temporary = 0;
        }
    }
}
