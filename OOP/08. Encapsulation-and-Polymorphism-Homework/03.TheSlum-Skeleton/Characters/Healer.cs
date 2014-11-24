namespace TheSlum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    public class Healer : Character, IHeal
    {
        public Healer(
            string id,
            int x,
            int y,
            Team team,
            int healthPoints = 0,
            int defensePoints = 0,
            int range = 0,
            int healingPoints = 0)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealthPoints = 75;
            this.DefensePoints = 50;
            this.HealingPoints = 60;
            this.Range = 6;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets =
                from target in targetsList
                where target.IsAlive && this.Team == target.Team && target != this
                orderby target.HealthPoints ascending
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
                ", Healing: {0}",
                this.HealingPoints);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.HealingPoints += item.HealthEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.HealingPoints -= item.HealthEffect;
        }
    }
}