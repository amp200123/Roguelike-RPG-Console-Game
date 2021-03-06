﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_RPG_Console_Game
{
    public class StatusHealer : GameItem
    {
        StatusEffect status;

        public StatusHealer(StatusEffect status)
            : base("", 60)
        {
            this.status = status;

            if (status == StatusEffect.burned)
            {
                name = "Burn Heal";
                info = "Heals a burn";
            }
            else if (status == StatusEffect.cursed)
            {
                name = "Holy Water";
                info = "Purifies you from a curse";
            }
        }

        public StatusHealer(StatusEffect status, int x, int y)
            : base("", 60)
        {
            this.status = status;
            this.x = x;
            this.y = y;

            if (status == StatusEffect.burned)
            {
                name = "Burn Heal";
                info = "Heals a burn";
            }
            else if (status == StatusEffect.cursed)
            {
                name = "Holy Water";
                info = "Purifies you from a curse";
            }
        }

        public override bool UseItem(Player player)
        {
            if (status == player.status)
            {
                player.status = StatusEffect.none;
                Console.WriteLine("You were healed!");
                return true;
            }
            else
            {
                Console.WriteLine("You cannot use this item right now!");
                return false;
            }
        }

        public override string SaveDataAsString()
        {
            string saveData = "";
            saveData += "statusHealer:";
            saveData += "status:" + status + ":\n";
            saveData += "x:" + (x.ToString() ?? "null") + ":";
            saveData += "y:" + (y.ToString() ?? "null") + ":";
            saveData += "end:";
            return saveData;
        }
    }
}
