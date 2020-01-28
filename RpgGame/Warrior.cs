using System;
using System.Runtime.InteropServices;

namespace RpgGame
{
    class Warrior : Hero
    {
        private string Name { get; set; }
        private int _realVitality;
        private int MaxVitality { get; set; }
        private int Force { get; set; }

        public int RealVitality
        {
            get => _realVitality;
            set => _realVitality = value;
        }


        public Warrior(string name, int vitality, int force, int maxVitality)
        {
            Name = name;
            RealVitality = vitality;
            Force = force;
            MaxVitality = maxVitality;
        }
        public Warrior()
        {
            Name = "Gerald";
            RealVitality = 150;
            MaxVitality = 150;
            Random rdn = new Random();
            Force = rdn.Next(3, 18);
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
            if (RealVitality > MaxVitality)
            {
                RealVitality = MaxVitality;
            }

            return RealVitality;
        }

        public override void AttackPower()
        {
            double Attack =0;
            if (RealVitality < 0.1 * MaxVitality)
            {
                Attack = Force * MaxVitality * 1.5;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------------------------------");
                Console.WriteLine("LOW HP: SPECIAL BONUS - Attack Power");
                Console.WriteLine($"Attack Power: {Attack}");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Attack = Force * MaxVitality;
                Console.WriteLine($"Attack Power: {Attack}");
            }

      
        }

        public override string ToString()
        {
            AttackPower();
            return $"{nameof(Name)}: {Name}, {nameof(RealVitality)}: {RealVitality}, {nameof(MaxVitality)}: {MaxVitality}, {nameof(Force)}: {Force}";
        }
    }
}