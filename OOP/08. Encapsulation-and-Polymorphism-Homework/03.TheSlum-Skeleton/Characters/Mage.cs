namespace TheSlum
{
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    public class Mage : Character, IAttack
    {
        public Mage(
            string id,
            int x,
            int y,
            Team team,
            int healthPoints = 0,
            int defensePoints = 0,
            int range = 0,
            int attackPoints = 0)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealthPoints = 150;
            this.DefensePoints = 50;
            this.AttackPoints = 300;
            this.Range = 5;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets =
                from target in targetsList
                where target.IsAlive && this.Team != target.Team
                select target;

            return targets.LastOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() +
                string.Format(
                ", Attack: {0}",
                this.AttackPoints);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }
    }
}