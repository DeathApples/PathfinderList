namespace DiceRoll.Model
{
    public class Ability
    {
        public int Score { get; set; }
        public int Modifier { get; set; }
        public int Bonus { get; set; }

        public Ability()
        {
            Score = 10;
            Modifier = 0;
            Bonus = 0;
        }
    }
}
