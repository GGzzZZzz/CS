namespace TheSlum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    public class Warrior : Character, IAttack
    {
        public Warrior(
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
            this.HealthPoints = 200;
            this.DefensePoints = 100;
            this.AttackPoints = 150;
            this.Range = 2;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets =
                from target in targetsList
                where target.IsAlive && this.Team != target.Team
                select target;

            return targets.FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.ApplyItemEffects(item);
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