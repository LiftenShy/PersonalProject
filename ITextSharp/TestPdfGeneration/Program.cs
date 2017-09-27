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
        /*IWarriorWeapons ww = new Fist();
        IFist fist = new WarriorWeapons();
        Warrior warrion = new Warrior("Name", 100, 2, , new List<IWarriorSpells>() {new Rage()}, new List<IWarriorArmors>());*/

        static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(
                                    "              ( || )\n" +
                                    "    ___(O_O)___ ||\n" +
                                    "        (|)     || \n" +
                                    "        / \\       \n" +
                                    "       /   \\      \n");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(
                                    "          ( \\\\ ) \n" +
                                    "             \\\\  \n" +
                                    "             /\\\\ \n" +
                                    "    ___(O_O)/      \n" +
                                    "        (|)        \n" +
                                    "        / \\       \n" +
                                    "       /   \\      \n");
                Console.ReadKey();
                Console.Clear();
                /*Console.WriteLine("--------------------");
                Console.WriteLine("1)Create new hero");
                Console.WriteLine("2)Load save");
                Console.WriteLine("--------------------");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine(
                                    "              ( || )\n" +
                                    "    ___(O_O)___ ||\n" +
                                    "        (|)     || \n" +
                                    "        / \\       \n" +
                                    "       /   \\      \n");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine(
                                    "          ( \\\\ ) \n" +
                                    "             \\\\  \n" +
                                    "             /\\\\ \n" +
                                    "    ___(O_O)/      \n" +
                                    "        (|)        \n" +
                                    "        / \\       \n" +
                                    "       /   \\      \n");
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
            }
                Console.ReadKey();
                Console.Clear();*/
            }
        }
    }
}