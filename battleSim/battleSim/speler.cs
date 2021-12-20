using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleSim
{
    internal class speler
    {
        public string naam { get; private set; }
        public int hitpoints { get; private set; }
        Random random = new Random();
        private bool died = false;
        public bool Died { get { return died; } private set { died = value;  } }

        public speler(string naam, int hitpoints)
        {
            this.naam = naam;
            this.hitpoints = hitpoints;
        }

        public string dealDamage(speler Speler)
        {
            string message;
            int schade = random.Next(0, 30);
            if(schade == 0)
            {
                message = "Misser!";
            } else if(schade >= 25)
            {
                message = "Critical hit!";
            } else
            {
                message = $"{schade} damage dealt!";
            }
            Speler.getDamage(schade);
            return message;
        }

        //true is dood, false is levend
        public void getDamage(int schade)
        {
            hitpoints -= schade;
            if(hitpoints <= 0)
            {
               Died = true;
            }
        }

        public void revive()
        {
            hitpoints = 100;
            Died = false;
        }
    }
}
