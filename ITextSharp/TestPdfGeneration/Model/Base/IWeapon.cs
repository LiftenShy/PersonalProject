
namespace TestPdfGeneration.Model.Base
{
    public interface IWeapon
    {
        string Name { get; set; }

        string Description { get; set; }

        int BasicDamage { get; set; }
    }
}
