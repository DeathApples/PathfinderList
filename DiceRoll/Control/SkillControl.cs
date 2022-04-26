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

        public static void Change(SkillType type, SkillLevel skillLevel, int item, int armor)
        {
            switch (type)
            {
                case SkillType.Acrobatics:
                    Acrobatics.SkillLevel = skillLevel;
                    Acrobatics.Item = item;
                    Acrobatics.Armor = armor;
                    Acrobatics.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Arcana:
                    Arcana.SkillLevel = skillLevel;
                    Arcana.Item = item;
                    Arcana.Armor = armor;
                    Arcana.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Athletics:
                    Athletics.SkillLevel = skillLevel;
                    Athletics.Item = item;
                    Athletics.Armor = armor;
                    Athletics.Score = PersonControl.Level + AbilityControl.Strength.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Crafting:
                    Crafting.SkillLevel = skillLevel;
                    Crafting.Item = item;
                    Crafting.Armor = armor;
                    Crafting.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Deception:
                    Deception.SkillLevel = skillLevel;
                    Deception.Item = item;
                    Deception.Armor = armor;
                    Deception.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Diplomacy:
                    Diplomacy.SkillLevel = skillLevel;
                    Diplomacy.Item = item;
                    Diplomacy.Armor = armor;
                    Diplomacy.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Intimidation:
                    Intimidation.SkillLevel = skillLevel;
                    Intimidation.Item = item;
                    Intimidation.Armor = armor;
                    Intimidation.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Lore:
                    Lore.SkillLevel = skillLevel;
                    Lore.Item = item;
                    Lore.Armor = armor;
                    Lore.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Medicine:
                    Medicine.SkillLevel = skillLevel;
                    Medicine.Item = item;
                    Medicine.Armor = armor;
                    Medicine.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Nature:
                    Nature.SkillLevel = skillLevel;
                    Nature.Item = item;
                    Nature.Armor = armor;
                    Nature.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Occultism:
                    Occultism.SkillLevel = skillLevel;
                    Occultism.Item = item;
                    Occultism.Armor = armor;
                    Occultism.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Performance:
                    Performance.SkillLevel = skillLevel;
                    Performance.Item = item;
                    Performance.Armor = armor;
                    Performance.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Religion:
                    Religion.SkillLevel = skillLevel;
                    Religion.Item = item;
                    Religion.Armor = armor;
                    Religion.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Society:
                    Society.SkillLevel = skillLevel;
                    Society.Item = item;
                    Society.Armor = armor;
                    Society.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Stealth:
                    Stealth.SkillLevel = skillLevel;
                    Stealth.Item = item;
                    Stealth.Armor = armor;
                    Stealth.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Survival:
                    Survival.SkillLevel = skillLevel;
                    Survival.Item = item;
                    Survival.Armor = armor;
                    Survival.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)skillLevel + item - armor;
                    break;

                case SkillType.Thievery:
                    Thievery.SkillLevel = skillLevel;
                    Thievery.Item = item;
                    Thievery.Armor = armor;
                    Thievery.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)skillLevel + item - armor;
                    break;
            }
        }

        public static void Change()
        {
            Acrobatics.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)Acrobatics.SkillLevel + Acrobatics.Item - Acrobatics.Armor;
            Arcana.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Arcana.SkillLevel + Arcana.Item - Arcana.Armor;
            Athletics.Score = PersonControl.Level + AbilityControl.Strength.Modifier + (int)Athletics.SkillLevel + Athletics.Item - Athletics.Armor;
            Crafting.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Crafting.SkillLevel + Crafting.Item - Crafting.Armor;
            Deception.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Deception.SkillLevel + Deception.Item - Deception.Armor;
            Diplomacy.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Diplomacy.SkillLevel + Diplomacy.Item - Diplomacy.Armor;
            Intimidation.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Intimidation.SkillLevel + Intimidation.Item - Intimidation.Armor;
            Lore.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Lore.SkillLevel + Lore.Item - Lore.Armor;
            Medicine.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Medicine.SkillLevel + Medicine.Item - Medicine.Armor;
            Nature.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Nature.SkillLevel + Nature.Item - Nature.Armor;
            Occultism.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Occultism.SkillLevel + Occultism.Item - Occultism.Armor;
            Performance.Score = PersonControl.Level + AbilityControl.Charisma.Modifier + (int)Performance.SkillLevel + Performance.Item - Performance.Armor;
            Religion.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Religion.SkillLevel + Religion.Item - Religion.Armor;
            Society.Score = PersonControl.Level + AbilityControl.Intelligence.Modifier + (int)Society.SkillLevel + Society.Item - Society.Armor;
            Stealth.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)Stealth.SkillLevel + Stealth.Item - Stealth.Armor;
            Survival.Score = PersonControl.Level + AbilityControl.Wisdom.Modifier + (int)Survival.SkillLevel + Survival.Item - Survival.Armor;
            Thievery.Score = PersonControl.Level + AbilityControl.Dexterity.Modifier + (int)Thievery.SkillLevel + Thievery.Item - Thievery.Armor;
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
