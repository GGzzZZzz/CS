namespace TheSlum
{
    public class Injection : Bonus
    {
        public Injection(string id, int healthEffect = 0, int defenseEffect = 0, int attackEffect = 0)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.HealthEffect = 200;
            this.Countdown = 3;
            this.Timeout = 3;
            this.HasTimedOut = false;
        }
    }
}