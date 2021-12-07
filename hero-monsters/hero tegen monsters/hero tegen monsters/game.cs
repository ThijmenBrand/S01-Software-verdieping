using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero_tegen_monsters
{
    internal class game
    {
        private static Random Random = new Random();
        int Death;

        public int runGame()
        {
            int turn = 0;
            bool death = false;
            creature Hero = new creature("Richard", 100, Random.Next(10, 20));
            creature Monster = new creature("Horld", Random.Next(100, 200), 10);

            do
            {
                if(turn % 2 == 0)
                {
                    if(Hero.playCreature(Monster) == false)
                    {
                        death = true;
                        Death = 0;
                    }
                    
                } else
                {
                    if(!Monster.playCreature(Hero))
                    {
                        death = true;
                        Death = 1;
                    }
                    
                }
                turn++;

            } while (!death);

            return Death;
        }
    }
}
