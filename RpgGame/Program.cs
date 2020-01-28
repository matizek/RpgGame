using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RpgGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Console.WriteLine(warrior.HeroInfo());
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = "+ warrior.RealVitality);
            warrior.Injury(50);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.Injury(90); ;
            Console.WriteLine("LOW HP SPECIAL ATTACK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.AttackPower();
            warrior.Treatment(62);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.Treatment(200);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.Injury(300);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + warrior.RealVitality);


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------");
            Mag mag = new Mag();
            Console.WriteLine(mag.HeroInfo());
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Injury(50);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Injury(90); ;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + mag.RealVitality);

            mag.AttackPower();
            mag.Treatment(62);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Treatment(200);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Injury(300);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HP = " + mag.RealVitality);
            Console.WriteLine("------------------------------");
            Team team = new Team("Best Team");
            team.AddNewHero(mag);
            team.AddNewHero(warrior);
            Console.WriteLine(team.ToString());

            Console.WriteLine("Now clone Gerald:");



            Console.ReadKey();
        }
        
    }
}
