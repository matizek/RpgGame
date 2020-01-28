using System;

namespace RpgGame
{
    class Mag : Hero
    {

        private string Name { get; set; }
        private int _realVitality;
        private int MaxVitality { get; set; }
        private int Force { get; set; }
        private int MagicPoints { get; set; }

        public int RealVitality
        {
            get => _realVitality;
            set => _realVitality = value;
        }


        public Mag(string name, int vitality, int force, int magicPoints, int maxVitality)
        {
            Name = name;
            RealVitality = vitality;
            Force = force;
            MagicPoints = magicPoints;
            MaxVitality = maxVitality;
        }

        public Mag()
        {
            Name = "Xardas";
            RealVitality = 100;
            MaxVitality = 100;
            Random rdn = new Random();
            Force = rdn.Next(1, 6);
            MagicPoints = rdn.Next(2, 12);
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
            if (RealVitality > MaxVitality)
            {
                RealVitality = MaxVitality;
            }

            return RealVitality;
        }

        public override void AttackPower()
        {
            double Attack = 0;

            Attack = (MagicPoints + Force) * MaxVitality;
            Console.WriteLine($"Attack Power: {Attack}");
        }

        public override string ToString()
        {
            AttackPower();
            return $"{nameof(Name)}: {Name}, '/n'{nameof(RealVitality)}: {RealVitality}, {nameof(MaxVitality)}: {MaxVitality}, {nameof(Force)}: {Force}, {nameof(MagicPoints)}: {MagicPoints}";
        }
    }
}