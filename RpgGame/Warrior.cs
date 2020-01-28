using System;
using System.Runtime.InteropServices;

namespace RpgGame
{
    class Warrior : Hero
    {
        private string _name { get; set; }
        private int _realVitality;
        private int _maxVitality { get; set; }
        private int _force { get; set; }

        public int RealVitality
        {
            get => _realVitality;
            set => _realVitality = value;
        }


        public Warrior(string name, int vitality, int force, int maxVitality)
        {
            _name = name;
            RealVitality = vitality;
            _force = force;
            _maxVitality = maxVitality;
        }
        public Warrior()
        {
            _name = "Gerald";
            RealVitality = 150;
            _maxVitality = 150;
            Random rdn = new Random();
            _force = rdn.Next(3, 18);
        }

        public override int Injury(int lostHp)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("INFJURY: -" +lostHp );
            RealVitality = RealVitality - lostHp;
            if (RealVitality < 0)
            {
                RealVitality = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You Died");
            }
            return RealVitality;

        }

        public override int Treatment(int healedHp)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Healed: +" + healedHp);
            RealVitality += healedHp;
            if (RealVitality > _maxVitality)
            {
                RealVitality = _maxVitality;
            }

            return RealVitality;
        }

        public override double AttackPower()
        {
            double attack =0;
            if (RealVitality < 0.1 * _maxVitality)
            {
                attack = _force * _maxVitality * 1.5;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                attack = _force * _maxVitality;
            }

            return attack;

        }

        public override string ToString()
        {
            
            return $"{nameof(_name)}: {_name}, {nameof(RealVitality)}: {RealVitality}, {nameof(_maxVitality)}: {_maxVitality}, {nameof(_force)}: {_force}";
        }
        public string HeroInfo()
        {
            Console.WriteLine("Attack Power: " + AttackPower());
            return $"{nameof(_name)}: {_name}, {nameof(RealVitality)}: {RealVitality}, {nameof(_maxVitality)}: {_maxVitality}, {nameof(_force)}: {_force}";
        }
    }
}