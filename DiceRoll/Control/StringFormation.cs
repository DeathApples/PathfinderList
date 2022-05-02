using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll.Control
{
    public static class StringFormation
    {
        public static Discord discord;

        static StringFormation()
        {
            discord = new Discord("", "", "");
        }

        public static (int, string) ParseFormula(string formula)
        {
            return (0, "");
        }

        public static void CreateMessage(Checks.RollType rollType, int bonus, string title)
        {
            (string roll, int result) = Checks.Roll(rollType);

            title += $" — {result + bonus}";
            string description = $"({result}) + {bonus} \n1{roll} + {bonus}";

            discord.SendMessage(title, description);
        }
    }
}
