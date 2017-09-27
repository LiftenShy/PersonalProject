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
            BaseDamage = 2;
        }

        public int PhysicalPower { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BaseDamage { get; set; }
    }
}
