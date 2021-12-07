using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero_tegen_monsters
{
    internal class monster
    {
        public int health;

        public monster(int initialHealth)
        {
            this.health = initialHealth;
        }

        public void loseHealth(int damage)
        {
            health -= damage;
        }
    }
}
