using DiceRoll.Model;

namespace DiceRoll.Control
{
    public static class HealthPointsControl
    {
        public static int Total => Health.Total;
        public static int Current => Health.Current;
        public static int Temporary => Health.Temporary;

        private static HealthPoints Health;

        static HealthPointsControl()
        {
            Health = new HealthPoints();
        }

        public static void Change(HealthType type, int value)
        {
            switch (type)
            {
                case HealthType.Total:
                    Health.Total = value;
                    break;

                case HealthType.Current:
                    Health.Current = value;
                    break;

                case HealthType.Temporary:
                    Health.Temporary = value;
                    break;
            }
        }

        public enum HealthType
        {
            Total,
            Current,
            Temporary
        }
    }
}
