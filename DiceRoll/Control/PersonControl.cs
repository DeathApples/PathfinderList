using System;
using DiceRoll.Model;

namespace DiceRoll.Control
{
    public static class PersonControl
    {
        public static event Action ChangeLevel;

        public static int Level => Person.Level;
        public static int Heroism => Person.Heroism;
        public static int ArmorClass => Person.ArmorClass;
        public static string Name => Person.Name;
        public static string Class => Person.Class;
        public static string Race => Person.Race;

        private static PersonInformation Person;

        static PersonControl()
        {
            Person = new PersonInformation();
        }

        public static void Change(InformationType type, object value)
        {
            switch (type)
            {
                case InformationType.Level:
                    Person.Level = (int)value;
                    ChangeLevel?.Invoke();
                    break;

                case InformationType.Heroism:
                    Person.Heroism = (int)value;
                    break;

                case InformationType.ArmorClass:
                    Person.ArmorClass = (int)value;
                    break;

                case InformationType.Name:
                    Person.Name = (string)value;
                    break;

                case InformationType.Class:
                    Person.Class = (string)value;
                    break;

                case InformationType.Race:
                    Person.Race = (string)value;
                    break;
            }
        }

        public enum InformationType
        {
            Level,
            Heroism,
            ArmorClass,
            Name,
            Class,
            Race
        }
    }
}
