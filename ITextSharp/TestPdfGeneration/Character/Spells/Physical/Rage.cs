
using TestPdfGeneration.Model.Spells.InstantSpell;

namespace TestPdfGeneration.Character.Spells.Physical
{
    class Rage : IRage
    {
        public Rage()
        {
            Cooldown = 10;
            Name = nameof(Rage);
            Description = "Warrior stay furry and his attack give up";
            BaseDamage = 5;
        }

        public double Cooldown { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseDamage { get; set; }

        public int UpPhysicalPower()
        {
            return BaseDamage + 10;
        }
    }
}
