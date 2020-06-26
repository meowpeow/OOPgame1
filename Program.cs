using OOPgame1.Actors;
using System;

namespace OOPgame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Playground playgroung = new Playground();
        }
    }

    internal class Playground
    {
        public Playground()
        {
            MainHero mainhero = MainHero.getInstance(100, 15);
            UnitMonster monster = new UnitMonster(100, 10);

            BattleMechanicSimplistic fight = new BattleMechanicSimplistic();

            fight.Fight1vs1(mainhero, monster);

            
        }
    }

    internal class BattleMechanicSimplistic
    {
        static int round;
        public void Fight1vs1(MainHero mh, UnitMonster monster)
        {

            /*for (int i = 0; i < 10; i++)
            {
                mh.Health = mh.Health - monster.Damage;
                monster.Health -= mh.Damage;
                Console.WriteLine(mh.Health);
                Console.WriteLine(monster.Health);
            }*/

            

            while (mh.Health >= 0 && monster.Health >= 0)
            {
                mh.Health = mh.Health - monster.Damage;
                monster.Health -= mh.Damage;
                round++;
                Console.WriteLine("round" + round);
                Console.WriteLine(mh.Health);
                Console.WriteLine(monster.Health);
            }
        }
    }


}
