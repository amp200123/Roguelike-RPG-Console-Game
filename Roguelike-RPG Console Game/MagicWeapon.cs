﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_RPG_Console_Game
{
    public class MagicWeapon : GameItem
    {
        public int magicDamage { get; protected set; }
        public WeaponEffect effect = WeaponEffect.none;

        public MagicWeapon(int magicDamage, string name, int cost) 
            : base(name, cost)
        {
            this.magicDamage = magicDamage;
            info = "A magical weapon that does " + magicDamage + " magic damage";
        }

        public MagicWeapon(int magicDamage, string name, int cost, int x, int y, WeaponEffect effect)
            : base(name, cost, x, y)
        {
            this.magicDamage = magicDamage;
            this.name = name;
            this.x = x;
            this.y = y;
            this.cost = cost;
            this.effect = effect;
        }

        public override string SaveDataAsString()
        {
            string saveData = "";
            saveData += "type:magicWeapon:";
            saveData += "name:" + name + ":";
            saveData += "magicDamage:" + magicDamage + ":";
            saveData += "effect:" + effect + ":";
            saveData += "cost:" + cost + ":";
            saveData += "x:" + x + ":";
            saveData += "y:" + y + ":";
            saveData += "end:";
            return saveData;
        }
    }
}
