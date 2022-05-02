using DiceRoll.Model;

namespace DiceRoll.Control
{
    public static class SavingThrowsControl
    {
        public static SavingThrows Perception { get; }
        public static SavingThrows Fortitude { get; }
        public static SavingThrows Reflex { get; }
        public static SavingThrows Will { get; }

        static SavingThrowsControl()
        {
            AbilityControl.ChangeAbility += Change;
            PersonControl.ChangeLevel += Change;

            Perception = new SavingThrows();
            Fortitude = new SavingThrows();
            Reflex = new SavingThrows();
            Will = new SavingThrows();
        }

        public static void Change(ThrowType type, SkillLevel skillLevel, int item)
        {
            switch (type)
            {
                case ThrowType.Perception:
                    Perception.SkillLevel = skillLevel;
                    Perception.Item = item;
                    Perception.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item;
                    break;

                case ThrowType.Fortitude:
                    Fortitude.SkillLevel = skillLevel;
                    Fortitude.Item = item;
                    Fortitude.Score = PersonControl.Level + AbilityControl.Constitution.Modifier + (int)skillLevel + item;
                    break;

                case ThrowType.Reflex:
                    Reflex.SkillLevel = skillLevel;
                    Reflex.Item = item;
                    Reflex.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)skillLevel + item;
                    break;

                case ThrowType.Will:
                    Will.SkillLevel = skillLevel;
                    Will.Item = item;
                    Will.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item;
                    break;
            }
        }

        public static void Change()
        {
            Perception.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Perception.SkillLevel + Perception.Item;
            Fortitude.Score = PersonControl.Level + AbilityControl.Constitution.Modifier + (int)Fortitude.SkillLevel + Fortitude.Item;
            Reflex.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)Reflex.SkillLevel + Reflex.Item;
            Will.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Will.SkillLevel + Will.Item;
        }

        public static void Check(ThrowType type)
        {
            switch (type)
            {
                case ThrowType.Perception:
                    StringFormation.CreateMessage(Checks.RollType.d20, Perception.Score, "Проверка Восприятия");
                    break;

                case ThrowType.Fortitude:
                    StringFormation.CreateMessage(Checks.RollType.d20, Fortitude.Score, "Спасбросок Стойкости");
                    break;

                case ThrowType.Reflex:
                    StringFormation.CreateMessage(Checks.RollType.d20, Reflex.Score, "Спасбросок Рефлекса");
                    break;

                case ThrowType.Will:
                    StringFormation.CreateMessage(Checks.RollType.d20, Will.Score, "Спасбросок Мудрости");
                    break;
            }
        }

        public enum ThrowType
        {
            Perception,
            Fortitude,
            Reflex,
            Will
        }
    }
}
