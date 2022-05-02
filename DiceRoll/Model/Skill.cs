namespace DiceRoll.Model
{
    public class Skill
    {
        public int Score { get; set; }
        public int Item { get; set; }
        public SkillLevel SkillLevel { get; set; }

        public Skill()
        {
            Score = 1;
            Item = 0;
            SkillLevel = SkillLevel.Uncoached;
        }
    }
}
