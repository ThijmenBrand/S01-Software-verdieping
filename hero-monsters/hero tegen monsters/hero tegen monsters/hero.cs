using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero_tegen_monsters
{
    internal class hero
    {
        public int numberOfDefeatedMonsters;

        public hero()
        {

        }

        public void Attack(monster Monster, int damage)
        {
            Monster.loseHealth(damage);
        }
    }
}
