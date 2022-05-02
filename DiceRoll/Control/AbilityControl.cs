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

        public static void Change(AbilityType type, int score)
        {
            switch (type)
            {
                case AbilityType.Strength:
                    Strength.Score = score;
                    Strength.Modifier = score / 2 - 5;
                    break;

                case AbilityType.Dexterity:
                    Dexterity.Score = score;
                    Dexterity.Modifier = score / 2 - 5;
                    break;

                case AbilityType.Constitution:
                    Constitution.Score = score;
                    Constitution.Modifier = score / 2 - 5;
                    break;

                case AbilityType.Intelligence:
                    Intelligence.Score = score;
                    Intelligence.Modifier = score / 2 - 5;
                    break;

                case AbilityType.Wisdom:
                    Wisdom.Score = score;
                    Wisdom.Modifier = score / 2 - 5;
                    break;

                case AbilityType.Charisma:
                    Charisma.Score = score;
                    Charisma.Modifier = score / 2 - 5;
                    break;
            }

            ChangeAbility?.Invoke();
        }

        public static void Check(AbilityType type)
        {
            switch (type)
            {
                case AbilityType.Strength:
                    StringFormation.CreateMessage(Checks.RollType.d20, Strength.Modifier, "Проверка Силы");
                    break;

                case AbilityType.Dexterity:
                    StringFormation.CreateMessage(Checks.RollType.d20, Dexterity.Modifier, "Проверка Ловкости");
                    break;

                case AbilityType.Constitution:
                    StringFormation.CreateMessage(Checks.RollType.d20, Constitution.Modifier, "Проверка Телосложения");
                    break;

                case AbilityType.Intelligence:
                    StringFormation.CreateMessage(Checks.RollType.d20, Intelligence.Modifier, "Проверка Интеллекта");
                    break;

                case AbilityType.Wisdom:
                    StringFormation.CreateMessage(Checks.RollType.d20, Wisdom.Modifier, "Проверка Мудрости");
                    break;

                case AbilityType.Charisma:
                    StringFormation.CreateMessage(Checks.RollType.d20, Charisma.Modifier, "Проверка Харизмы");
                    break;
            }
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
