namespace TheSlum
{
    public class Pill : Bonus
    {
        public Pill(string id, int healthEffect = 0, int defenseEffect = 0, int attackEffect = 0)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.AttackEffect = 100;
            this.Countdown = 3;
            this.Timeout = 3;
            this.HasTimedOut = false;
        }
    }
}