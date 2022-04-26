namespace DiceRoll.Model
{
    public class Money
    {
        public int CopperCoins { get; set; }
        public int SilverCoins { get; set; }
        public int GoldCoins { get; set; }
        public int PlatinumCoins { get; set; }

        public Money()
        {
            CopperCoins = 0;
            SilverCoins = 0;
            GoldCoins = 0;
            PlatinumCoins = 0;
        }
    }
}
