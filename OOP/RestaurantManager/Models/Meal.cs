namespace RestaurantManager.Interfaces
{
    using System;
    using System.Text;

    using RestaurantManager.Models;

    public abstract class Meal : Recipe, IMeal
    {
        private bool isVegan = true;
        public Meal(
            string name,
            decimal price,
            int calories,
            int quantityPerServing,
            int timeToPrepare)
            : base(
            name,
            price,
            calories,
            quantityPerServing,
            timeToPrepare)
        {
            this.Unit = MetricUnit.Grams;
        }

        public bool IsVegan
        {
            get
            {
                return this.isVegan;
            }

            set
            {
                this.isVegan = value;
            }
        }

        public void ToggleVegan()
        {
            if (IsVegan)
            {
                if (this is Salad)
                {
                    throw new InvalidOperationException("Salad must always be vegan!");
                }

                this.IsVegan = false;
            }
            else
            {
                this.IsVegan = true;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0}", this.IsVegan ? "[VEGAN] " : string.Empty));
            result.Append(base.ToString());

            return result.ToString().Trim();
        }
    }
}