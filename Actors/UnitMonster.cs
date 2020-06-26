using System;
using System.Collections.Generic;
using System.Text;

namespace OOPgame1.Actors
{
    internal class UnitMonster
    {
        MainHero mainYou;

        public UnitMonster(int h, int d)
        {
            _health = h;
            _damage = d;
            CounterBorn++;
        }


        private int _health;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }
        public static int CounterBorn { get; set; }
        public static int CounterDied { get; private set; }


        private void Behaviour()
        {
            if (Health <= 0)
            {
                CreatureDied();
            }

            if (mainYou.Health < Health / 2)
            {
                CreatureOverconfident();
            }

            if (mainYou.Health / 2 > Health)
            {
                CreatureScared();
            }
        }

        private void CreatureDied()
        {
            CounterDied++;
        }

        private void CreatureOverconfident()
        {
            Damage = Damage * 2;
        }

        private void CreatureScared()
        {
            Damage = Damage / 3;
        }
    }
}
