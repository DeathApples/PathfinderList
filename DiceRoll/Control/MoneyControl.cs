using DiceRoll.Model;

namespace DiceRoll.Control
{
    public static class MoneyControl
    {
        public static int CopperCoins => Money.CopperCoins;
        public static int SilverCoins => Money.SilverCoins;
        public static int GoldCoins => Money.GoldCoins;
        public static int PlatinumCoins => Money.PlatinumCoins;

        private static Money Money;

        static MoneyControl()
        {
            Money = new Money();
        }

        public static void Change(CoinsType coins, int value)
        {
            switch (coins)
            {
                case CoinsType.Copper:
                    Money.CopperCoins = value;
                    break;

                case CoinsType.Silver:
                    Money.SilverCoins = value;
                    break;

                case CoinsType.Gold:
                    Money.GoldCoins = value;
                    break;

                case CoinsType.Platinum:
                    Money.PlatinumCoins = value;
                    break;
            }
        }

        public enum CoinsType
        {
            Copper,
            Silver,
            Gold,
            Platinum
        }
    }
}
