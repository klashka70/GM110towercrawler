using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Game_Project
{
    internal class Player : Creature
    {
        static public uint MaxHealth = 15;
        public uint PlayerArmor = 5;
        public int Rounds = 50;
        public int Knife;
        public int Revolver;
        public string Survivor;
        public Player() : base(Player.MaxHealth)
        {
            // this == self

            Console.WriteLine($"Player health set to {this.health}");

        }

        public bool DamageToSurvivor(uint damage)
        {

            if (damage >= health)
            {
                health = 0;
                return true;
            }
            else
            {
                damage -= health;
                return false;
            }




        }

    }
}


