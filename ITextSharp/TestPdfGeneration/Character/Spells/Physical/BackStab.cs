

using TestPdfGeneration.Model.Spells.InstanceSpell;

namespace TestPdfGeneration.Character.Spells.Physical
{
    public class BackStab : IBackStab
    {
        public BackStab()
        {
            Cooldown = 2;
            Name = nameof(BackStab);
            Description = "Faster move behind enemy and attack";
            BaseDamage = 5;
        }

        public double Cooldown { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseDamage { get; set; }

        public int Attack(int PhysicalPowerWeapon)
        {
            return BaseDamage + PhysicalPowerWeapon;
        }
    }
}
