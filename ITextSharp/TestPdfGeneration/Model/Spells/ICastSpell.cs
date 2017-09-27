using TestPdfGeneration.Model.Base;

namespace TestPdfGeneration.Model.Spells
{
    public interface ICastSpell : ISpell
    {
        double Cooldown { get; set; }

        double TimeCast { get; set; }
    }
}
