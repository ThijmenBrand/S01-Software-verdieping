using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero_tegen_monsters
{
    internal class dice
    {
        private static int maxDamage;

        public dice(int maxdamage)
        {
            maxDamage = maxdamage;
        }

        public int rollDice()
        {
            int attackValue;
            Random random = new Random();
            attackValue = random.Next(0, maxDamage);

            return attackValue;
        }
    }
}
