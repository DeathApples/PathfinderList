using System;

namespace DiceRoll.Control
{
    public static class Checks
    {
        private static Random random;

        static Checks()
        {
            random = new Random();
        }

        public static int Roll(DiceRollType type)
        {
            switch (type)
            {
                case DiceRollType.d4:
                    return random.Next(1, 4);

                case DiceRollType.d6:
                    return random.Next(1, 6);

                case DiceRollType.d8:
                    return random.Next(1, 8);

                case DiceRollType.d10:
                    return random.Next(1, 10);

                case DiceRollType.d12:
                    return random.Next(1, 12);

                case DiceRollType.d20:
                    return random.Next(1, 20);

                default:
                    return random.Next(1, 100);
            }
        }

        public enum DiceRollType
        {
            d4,
            d6,
            d8,
            d10,
            d12,
            d20,
            d100
        }
    }
}
