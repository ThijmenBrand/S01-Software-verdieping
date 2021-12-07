using System;
using hero_tegen_monsters;

namespace hero_tegen_monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            game Game = new game();

            for(int i = 0; i < 10; i++)
            {
                if (Game.runGame() == 1)
                {
                    Console.WriteLine($"{creature.heroName} has won the game!");
                }
                else
                {
                    Console.WriteLine($"{creature.heroName} has been defeaten!");
                }
            }
        }
    }
}