using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine(warrior.ToString());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("HP = "+ warrior.RealVitality);
            warrior.Injury(50);
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.Injury(90); ;
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.AttackPower();
            warrior.Treatment(62);
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.Treatment(200);
            Console.WriteLine("HP = " + warrior.RealVitality);
            warrior.Injury(300);
            Console.WriteLine("HP = " + warrior.RealVitality);


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------");
            Mag mag = new Mag();
            Console.WriteLine(mag.ToString());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Injury(50);
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Injury(90); ;
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.AttackPower();
            mag.Treatment(62);
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Treatment(200);
            Console.WriteLine("HP = " + mag.RealVitality);
            mag.Injury(300);
            Console.WriteLine("HP = " + mag.RealVitality);


            Console.ReadKey();
        }
        
    }
}
