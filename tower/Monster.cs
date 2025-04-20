using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Game_Project
{
    internal class Monster : Creature
    {
        static public uint MaxHealth = 25;


        public Monster(uint health) : base(health)
        {
            // this == self

            

        }

        public bool DamageToMonster(uint damage)
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
