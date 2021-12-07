using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero_tegen_monsters
{
    internal class creature : Ilivable
    {
        public static string heroName { get; private set; }
        private int heroHealth;
        private int heroMaxDamage;

        public creature(string heroname, int herohealth, int heromaxdamage)
        {
            heroName = heroname;
            this.heroHealth = herohealth;
            this.heroMaxDamage = heromaxdamage;
        }

        public void loseHealth(int damage)
        {
            heroHealth -= damage;
        }

        public void Attack(creature Monster)
        {
            dice Dice = new dice(heroMaxDamage);
            int damage = Dice.rollDice();
            Monster.loseHealth(damage);
        }

        public bool playCreature(creature Monster)
        {
            if (heroHealth <= 0)
            {
                return false;
            }
            else
            {
                Attack(Monster);
                return true;
            }
        }
    }
}
