namespace TheSlum
{
    public class Shield : Item
    {
        public Shield(string id, int healthEffect = 0, int defenseEffect = 0, int attackEffect = 0)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.HealthEffect = healthEffect;
            this.DefenseEffect = 50;
            this.AttackEffect = attackEffect;
        }
    }
}