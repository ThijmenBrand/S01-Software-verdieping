using System;
using hero_tegen_monsters;

namespace hero_tegen_monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            hero Hero = new hero();
            monster Monster = new monster(100);
            monster Monster2 = new monster(125);

            Hero.Attack(Monster, 50);

            Console.WriteLine(Monster.health);
        }
    }
}