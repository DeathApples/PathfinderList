namespace DiceRoll.Model
{
    public class SavingThrows
    {
        public int Score { get; set; }
        public int Item { get; set; }
        public SkillLevel SkillLevel { get; set; }

        public SavingThrows()
        {
            Score = 0;
            Item = 0;
            SkillLevel = SkillLevel.Learned;
        }
    }
}
