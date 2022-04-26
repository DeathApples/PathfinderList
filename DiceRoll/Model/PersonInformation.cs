namespace DiceRoll.Model
{
    public class PersonInformation
    {
        public int Level { get; set; }
        public int Heroism { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }

        public PersonInformation()
        {
            Level = 1;
            Heroism = 1;
            Name = "";
            Class = "";
            Race = "";
        }
    }
}
