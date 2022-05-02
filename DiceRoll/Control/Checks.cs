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

        public static (string, int) Roll(RollType type)
        {
            switch (type)
            {
                case RollType.d4:
                    return ("d4", random.Next(1, 4));

                case RollType.d6:
                    return ("d6", random.Next(1, 6));

                case RollType.d8:
                    return ("d8", random.Next(1, 8));

                case RollType.d10:
                    return ("d10", random.Next(1, 10));

                case RollType.d12:
                    return ("d12", random.Next(1, 12));

                case RollType.d20:
                    return ("d20", random.Next(1, 20));

                default:
                    return ("d100", random.Next(1, 100));
            }
        }

        public enum RollType
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
