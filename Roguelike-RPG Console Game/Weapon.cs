﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_RPG_Console_Game
{
    public class Weapon : GameItem
    {
        public int damage { get; private set; }
        public WeaponEffect effect;

        public Weapon(string name, int damage, int cost, WeaponEffect effect = WeaponEffect.none)
            : base(name, cost)
        {
            this.damage = damage;
            info = "A weapon that deals " + damage + " damage.";
            this.effect = effect;
        }

        public override bool UseItem(Player player)
        {
            if (player.weapon == this)
            {
                player.weapon = new Weapon("Fist", 0, 0);
                Console.WriteLine("You unequiped your " + name + ".");
            }
            else
            {
                player.weapon = this;
                Console.WriteLine("You equiped your " + name + ".");
            }

            return false;
        }

        public override string SaveDataAsString()
        {
            string saveData = "";
            saveData += "type:weapon:\n";
            saveData += "name:" + name + "\n";
            saveData += "cost:" + cost + "\n";
            saveData += "damage:" + damage + "\n";
            saveData += "effect:" + effect + "\n";
            saveData += "x:" + x + "\n";
            saveData += "y:" + y + "\n";
            return saveData;
        }
    }
}
