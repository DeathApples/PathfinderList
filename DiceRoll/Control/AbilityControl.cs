using DiceRoll.Model;
using System;

namespace DiceRoll.Control
{
    public static class AbilityControl
    {
        public static event Action ChangeAbility;

        public static Ability Strength { get; }
        public static Ability Dexterity { get; }
        public static Ability Constitution { get; }
        public static Ability Intelligence { get; }
        public static Ability Wisdom { get; }
        public static Ability Charisma { get; }

        static AbilityControl()
        {
            Strength = new Ability();
            Dexterity = new Ability();
            Constitution = new Ability();
            Intelligence = new Ability();
            Wisdom = new Ability();
            Charisma = new Ability();
        }

        public static void Change(AbilityType type, int score, int modifier, int bonus = 0)
        {
            switch (type)
            {
                case AbilityType.Strength:
                    Strength.Score = score;
                    Strength.Modifier = modifier;
                    Strength.Bonus = bonus;
                    break;

                case AbilityType.Dexterity:
                    Dexterity.Score = score;
                    Dexterity.Modifier = modifier;
                    Dexterity.Bonus = bonus;
                    break;

                case AbilityType.Constitution:
                    Constitution.Score = score;
                    Constitution.Modifier = modifier;
                    Constitution.Bonus = bonus;
                    break;

                case AbilityType.Intelligence:
                    Intelligence.Score = score;
                    Intelligence.Modifier = modifier;
                    Intelligence.Bonus = bonus;
                    break;

                case AbilityType.Wisdom:
                    Wisdom.Score = score;
                    Wisdom.Modifier = modifier;
                    Wisdom.Bonus = bonus;
                    break;

                case AbilityType.Charisma:
                    Charisma.Score = score;
                    Charisma.Modifier = modifier;
                    Charisma.Bonus = bonus;
                    break;
            }

            ChangeAbility.Invoke();
        }

        public enum AbilityType
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma,
        }
    }
}
