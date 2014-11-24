namespace TheSlum
{
    public class Axe : Item
    {
        public Axe(string id, int healthEffect = 0, int defenseEffect = 0, int attackEffect = 0)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.HealthEffect = healthEffect;
            this.DefenseEffect = defenseEffect;
            this.AttackEffect = 75;
        }
    }
}