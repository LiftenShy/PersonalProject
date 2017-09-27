using System.Drawing;
using TestPdfGeneration.Model.Spells.CastSpell;

namespace TestPdfGeneration.Character.Spells.Magical
{
    class PowerfullShoot : IPowerfulShoot
    {
        public int BaseDamage { get; set; }
        public Color ColorShoot { get; set; }
        public double Cooldown { get; set; }
        public double TimeCast { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public PowerfullShoot()
        {
            BaseDamage = 5;
            ColorShoot = Color.Green;
            Cooldown = 2;
            TimeCast = 0.5;
            Name = nameof(PowerfullShoot);
            Description = "A lot time archer training how make powerful shoot, and him succeeded";
        }
    }
}
