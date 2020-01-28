using System;

namespace RpgGame
{
    class Mag : Hero
    {

        private string _name { get; set; }
        private int _realVitality;
        private int _maxVitality { get; set; }
        private int _force { get; set; }
        private int _magicPoints { get; set; }

        public int RealVitality
        {
            get => _realVitality;
            set => _realVitality = value;
        }


        public Mag(string name, int vitality, int force, int magicPoints, int maxVitality)
        {
            _name = name;
            RealVitality = vitality;
            _force = force;
            _magicPoints = magicPoints;
            _maxVitality = maxVitality;
        }

        public Mag()
        {
            _name = "Xardas";
            RealVitality = 100;
            _maxVitality = 100;
            Random rdn = new Random();
            _force = rdn.Next(1, 6);
            _magicPoints = rdn.Next(2, 12);
        }



        public override int Injury(int lostHp)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("INFJURY: -" + lostHp);
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
            double attack = 0;

            attack = (_magicPoints + _force) * _maxVitality;
          //  Console.WriteLine($"attack Power: {attack}");
            return attack;
        }

        public override string ToString()
        {
            return $"{nameof(_name)}: {_name}, {nameof(RealVitality)}: {RealVitality}, {nameof(_maxVitality)}: {_maxVitality}, {nameof(_force)}: {_force}, {nameof(_magicPoints)}: {_magicPoints}";
        }
        public string HeroInfo()
        {
            Console.WriteLine("Attack Power: " + AttackPower());
            return $"{nameof(_name)}: {_name}, {nameof(RealVitality)}: {RealVitality}, {nameof(_maxVitality)}: {_maxVitality}, {nameof(_force)}: {_force}, {nameof(_magicPoints)}: {_magicPoints}";
        }
    }
}