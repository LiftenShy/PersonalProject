using System.Drawing;

namespace TestPdfGeneration.Model.Spells.CastSpell
{
    public interface IPowerfulShoot : ICastSpell
    {
        Color ColorShoot { get; set; }
    }
}
