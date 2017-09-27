
using TestPdfGeneration.Model.Spells.CastSpell;

namespace TestPdfGeneration.Character.Spells.Magical
{
    class FireBoll : IFireBoll
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseDamage { get; set; }

        public double Cooldown { get; set; }
        public double TimeCast { get; set; }
        
        public FireBoll()
        {
            Name = nameof(FireBoll);
            Description = "Powerfull fire attack";
            Cooldown = 2;
            TimeCast = 0.5;
            BaseDamage = 5;
        }

        public int CastFireBoll(int spellPowerWeapon)
        {
            return BaseDamage + spellPowerWeapon;
        }
    }
}
