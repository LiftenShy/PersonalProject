using System.Collections.Generic;
using TestPdfGeneration.Model.Classes;
using TestPdfGeneration.Model.Classes.Armor;
using TestPdfGeneration.Model.Classes.Spell;
using TestPdfGeneration.Model.Classes.Weapon;

namespace TestPdfGeneration.Character.Classes.Warrior
{
    class Warrior : IWarrior
    {
        public List<IWarriorWeapons> Weapons = new List<IWarriorWeapons>();

        private IWarriorWeapons _currentWeapon;

        public List<IWarriorSpells> Spells;

        public List<IWarriorArmors> Armors;

        public Warrior(string name, int health, int physicalPower, IWarriorWeapons currentWeapon, List<IWarriorSpells> spells, List<IWarriorArmors> armors)
        {
            PhysicalPower = physicalPower;
            Name = name;
            Health = health;
            _currentWeapon = currentWeapon;
            Spells = spells;
            Armors = armors;
        }

        public int PhysicalPower { get; set; }

        public string Name { get; set; }

        public int Health { get; set; }

        public IWarriorWeapons ChangeWeapon(IWarriorWeapons weapon)
        {
            Weapons.Add(_currentWeapon);
            _currentWeapon = weapon;
            Weapons.Remove(weapon);
            return _currentWeapon;
        }

        public int Hit()
        {
            return _currentWeapon.BasicDamage + PhysicalPower;
        }
    }
}
