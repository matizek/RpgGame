using System.Collections.Generic;
using System.Text;

namespace RpgGame
{
    class Team
    {
        private string _name;
        private List<Hero> _list;

        public Team(string name)
        {
            _name = name;
            _list = new List<Hero>();
        }

        public void AddNewHero(Hero hero)
        {
            _list.Add(hero);
        }

        public double SumTeamAttackPower()
        {
            double sum=0;
            foreach(var hero in _list)
            {
                sum += hero.AttackPower();
            }
            return sum;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Team name: {_name}");
            stringBuilder.AppendLine($"Team attack points: {SumTeamAttackPower()}");
            foreach (var hero in _list)
            {
                stringBuilder.AppendLine(hero.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}