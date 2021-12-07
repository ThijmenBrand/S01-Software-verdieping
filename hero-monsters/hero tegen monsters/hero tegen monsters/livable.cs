using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero_tegen_monsters
{
    internal interface Ilivable
    {
        void loseHealth(int damage);
        public void Attack(creature obj);
        public bool playCreature(creature Monster);
    }
}
