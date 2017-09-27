using TestPdfGeneration.Model.Classes.Weapon;

namespace TestPdfGeneration.Model.Classes
{
    public interface IWarrior : IHero
    {
        int Hit();
        IWarriorWeapons ChangeWeapon(IWarriorWeapons weapon);
    }
}
