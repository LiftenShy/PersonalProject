
namespace TestPdfGeneration.Model.Base
{
    public interface ISpell
    {
        string Name { get; set; }

        string Description { get; set; }

        int BaseDamage { get; set; }
    }
}
