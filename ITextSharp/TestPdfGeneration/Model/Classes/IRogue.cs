using TestPdfGeneration.Model.Classes.Armor;
using TestPdfGeneration.Model.Classes.Spell;
using TestPdfGeneration.Model.Classes.Weapon;

namespace TestPdfGeneration.Model.Classes
{
    public interface IRogue : IHero
    {
        int PhysicalPower { get; set; }
    }
}
