using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Game_Project
{

    // Creature class represents all beings that have health
    internal class Creature
    {
        public uint health;

        public Creature(uint health)

        {
            this.health = health;
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





