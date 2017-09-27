using TestPdfGeneration.Model.Classes.Weapon;

namespace TestPdfGeneration.Character.Classes
{
    class WarriorWeapons : IWarriorWeapons
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BasicDamage { get; set; }

        public int PhysicalAttack()
        {
            return 1;
        }
    }
}
