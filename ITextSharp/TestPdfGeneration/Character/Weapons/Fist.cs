using TestPdfGeneration.Model.Items.Weapons.Base;

namespace TestPdfGeneration.Character.Weapons
{
    public class Fist : IFist
    {
        public Fist()
        {
            PhysicalPower = 0;
            Name = nameof(Fist);
            Description = "Fist is fist";
            BasicDamage = 1;
        }

        public int PhysicalPower { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BasicDamage { get; set; }
    }
}
