using DiceRoll.Model;

namespace DiceRoll.Control
{
    public static class SkillControl
    {
        public static Skill Acrobatics { get; }
        public static Skill Arcana { get; }
        public static Skill Athletics { get; }
        public static Skill Crafting { get; }
        public static Skill Deception { get; }
        public static Skill Diplomacy { get; }
        public static Skill Intimidation { get; }
        public static Skill Lore { get; }
        public static Skill Medicine { get; }
        public static Skill Nature { get; }
        public static Skill Occultism { get; }
        public static Skill Performance { get; }
        public static Skill Religion { get; }
        public static Skill Society { get; }
        public static Skill Stealth { get; }
        public static Skill Survival { get; }
        public static Skill Thievery { get; }

        static SkillControl()
        {
            AbilityControl.ChangeAbility += Change;
            PersonControl.ChangeLevel += Change;

            Acrobatics = new Skill();
            Arcana = new Skill();
            Athletics = new Skill();
            Crafting = new Skill();
            Deception = new Skill();
            Diplomacy = new Skill();
            Intimidation = new Skill();
            Lore = new Skill();
            Medicine = new Skill();
            Nature = new Skill();
            Occultism = new Skill();
            Performance = new Skill();
            Religion = new Skill();
            Society = new Skill();
            Stealth = new Skill();
            Survival = new Skill();
            Thievery = new Skill();
        }

        public static void Change(SkillType type, SkillLevel skillLevel, int item)
        {
            switch (type)
            {
                case SkillType.Acrobatics:
                    Acrobatics.SkillLevel = skillLevel;
                    Acrobatics.Item = item;
                    Acrobatics.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Arcana:
                    Arcana.SkillLevel = skillLevel;
                    Arcana.Item = item;
                    Arcana.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Athletics:
                    Athletics.SkillLevel = skillLevel;
                    Athletics.Item = item;
                    Athletics.Score = PersonControl.Level + AbilityControl.Strength.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Crafting:
                    Crafting.SkillLevel = skillLevel;
                    Crafting.Item = item;
                    Crafting.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Deception:
                    Deception.SkillLevel = skillLevel;
                    Deception.Item = item;
                    Deception.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Diplomacy:
                    Diplomacy.SkillLevel = skillLevel;
                    Diplomacy.Item = item;
                    Diplomacy.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Intimidation:
                    Intimidation.SkillLevel = skillLevel;
                    Intimidation.Item = item;
                    Intimidation.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Lore:
                    Lore.SkillLevel = skillLevel;
                    Lore.Item = item;
                    Lore.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Medicine:
                    Medicine.SkillLevel = skillLevel;
                    Medicine.Item = item;
                    Medicine.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Nature:
                    Nature.SkillLevel = skillLevel;
                    Nature.Item = item;
                    Nature.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Occultism:
                    Occultism.SkillLevel = skillLevel;
                    Occultism.Item = item;
                    Occultism.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Performance:
                    Performance.SkillLevel = skillLevel;
                    Performance.Item = item;
                    Performance.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Religion:
                    Religion.SkillLevel = skillLevel;
                    Religion.Item = item;
                    Religion.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Society:
                    Society.SkillLevel = skillLevel;
                    Society.Item = item;
                    Society.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Stealth:
                    Stealth.SkillLevel = skillLevel;
                    Stealth.Item = item;
                    Stealth.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Survival:
                    Survival.SkillLevel = skillLevel;
                    Survival.Item = item;
                    Survival.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item;
                    break;

                case SkillType.Thievery:
                    Thievery.SkillLevel = skillLevel;
                    Thievery.Item = item;
                    Thievery.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)skillLevel + item;
                    break;
            }
        }

        public static void Change()
        {
            Acrobatics.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)Acrobatics.SkillLevel + Acrobatics.Item;
            Arcana.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Arcana.SkillLevel + Arcana.Item;
            Athletics.Score = PersonControl.Level + AbilityControl.Strength.Modifier + (int)Athletics.SkillLevel + Athletics.Item;
            Crafting.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Crafting.SkillLevel + Crafting.Item;
            Deception.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Deception.SkillLevel + Deception.Item;
            Diplomacy.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Diplomacy.SkillLevel + Diplomacy.Item;
            Intimidation.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Intimidation.SkillLevel + Intimidation.Item;
            Lore.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Lore.SkillLevel + Lore.Item;
            Medicine.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Medicine.SkillLevel + Medicine.Item;
            Nature.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Nature.SkillLevel + Nature.Item;
            Occultism.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Occultism.SkillLevel + Occultism.Item;
            Performance.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Performance.SkillLevel + Performance.Item;
            Religion.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Religion.SkillLevel + Religion.Item;
            Society.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Society.SkillLevel + Society.Item;
            Stealth.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)Stealth.SkillLevel + Stealth.Item;
            Survival.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Survival.SkillLevel + Survival.Item;
            Thievery.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)Thievery.SkillLevel + Thievery.Item;
        }

        public static void Check(SkillType type)
        {
            switch (type)
            {
                case SkillType.Acrobatics:
                    StringFormation.CreateMessage(Checks.RollType.d20, Acrobatics.Score, "Проверка Акробатики");
                    break;

                case SkillType.Arcana:
                    StringFormation.CreateMessage(Checks.RollType.d20, Arcana.Score, "Проверка Акраны");
                    break;

                case SkillType.Athletics:
                    StringFormation.CreateMessage(Checks.RollType.d20, Athletics.Score, "Проверка Атлетики");
                    break;

                case SkillType.Crafting:
                    StringFormation.CreateMessage(Checks.RollType.d20, Crafting.Score, "Проверка Ремесла");
                    break;

                case SkillType.Deception:
                    StringFormation.CreateMessage(Checks.RollType.d20, Deception.Score, "Проверка Обмана");
                    break;

                case SkillType.Diplomacy:
                    StringFormation.CreateMessage(Checks.RollType.d20, Diplomacy.Score, "Проверка Дипломатии");
                    break;

                case SkillType.Intimidation:
                    StringFormation.CreateMessage(Checks.RollType.d20, Intimidation.Score, "Проверка Запугивания");
                    break;

                case SkillType.Lore:
                    StringFormation.CreateMessage(Checks.RollType.d20, Lore.Score, "Проверка Знаний");
                    break;

                case SkillType.Medicine:
                    StringFormation.CreateMessage(Checks.RollType.d20, Medicine.Score, "Проверка Медицины");
                    break;

                case SkillType.Nature:
                    StringFormation.CreateMessage(Checks.RollType.d20, Nature.Score, "Проверка Природы");
                    break;

                case SkillType.Occultism:
                    StringFormation.CreateMessage(Checks.RollType.d20, Occultism.Score, "Проверка Оккультизма");
                    break;

                case SkillType.Performance:
                    StringFormation.CreateMessage(Checks.RollType.d20, Performance.Score, "Проверка Выступления");
                    break;

                case SkillType.Religion:
                    StringFormation.CreateMessage(Checks.RollType.d20, Religion.Score, "Проверка Религии");
                    break;

                case SkillType.Society:
                    StringFormation.CreateMessage(Checks.RollType.d20, Society.Score, "Проверка Общества");
                    break;

                case SkillType.Stealth:
                    StringFormation.CreateMessage(Checks.RollType.d20, Stealth.Score, "Проверка Скрытности");
                    break;

                case SkillType.Survival:
                    StringFormation.CreateMessage(Checks.RollType.d20, Survival.Score, "Проверка Выживания");
                    break;

                case SkillType.Thievery:
                    StringFormation.CreateMessage(Checks.RollType.d20, Thievery.Score, "Проверка воровства");
                    break;
            }
        }

        public enum SkillType
        {
            Acrobatics,
            Arcana,
            Athletics,
            Crafting,
            Deception,
            Diplomacy,
            Intimidation,
            Lore,
            Medicine,
            Nature,
            Occultism,
            Performance,
            Religion,
            Society,
            Stealth,
            Survival,
            Thievery,
        }
    }
}
