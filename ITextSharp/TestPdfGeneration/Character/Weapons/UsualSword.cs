using TestPdfGeneration.Model.Items.Weapons.Base;

namespace TestPdfGeneration.Character.Weapons
{
    class UsualSword : ISword
    {
        public UsualSword()
        {
            PhysicalPower = 0;
            Name = nameof(UsualSword);
            Description = "Training sword for beginer";
            BasicDamage = 2;
        }

        public int PhysicalPower { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BasicDamage { get; set; }

        public int PhysicalAttack()
        {
            throw new System.NotImplementedException();
        }
    }
}
