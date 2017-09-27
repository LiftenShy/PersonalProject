using System;
using System.Collections.Generic;
using TestPdfGeneration.Character.Classes;
using TestPdfGeneration.Character.Classes.Warrior;
using TestPdfGeneration.Character.Spells.Physical;
using TestPdfGeneration.Character.Weapons;
using TestPdfGeneration.Model.Classes.Armor;
using TestPdfGeneration.Model.Classes.Spell;
using TestPdfGeneration.Model.Classes.Weapon;
using TestPdfGeneration.Model.Items.Weapons.Base;

namespace TestPdfGeneration
{
    public class Program
    {
        IWarriorWeapons ww = new Fist();
        IFist fist = new WarriorWeapons();
        Warrior warrion = new Warrior("Name", 100, 2, , new List<IWarriorSpells>() {new Rage()}, new List<IWarriorArmors>());
        static void Main()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("1)Create new hero");
            Console.WriteLine("2)Load save");
            Console.WriteLine("--------------------");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        //create
                        break;
                    }
                case "2":
                    {
                        //load
                        break;
                    }
                default:
                    {

                        break;
                    }
            }
        }
    }
}