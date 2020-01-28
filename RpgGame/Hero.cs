namespace RpgGame
{
    abstract class Hero
    {
        public abstract int Injury(int lostHp);
        public abstract int Treatment(int healedHp);
        public abstract void AttackPower();

    }
}