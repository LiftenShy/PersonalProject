using TestPdfGeneration.Model.Base;

namespace TestPdfGeneration.Model.Spells
{
    public interface IInstantSpell : ISpell
    {
        double Cooldown { get; set; }
    }
}
