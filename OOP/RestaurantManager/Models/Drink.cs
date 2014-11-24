namespace RestaurantManager.Interfaces
{
    using System;
    using System.Text;

    using RestaurantManager.Models;

    public class Drink : Recipe, IDrink
    {
        private bool isCarbonated;

        public Drink(
            string name,
            decimal price,
            int calories,
            int quantityPerServing,
            int timeToPrepare,
            bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
        }

        public override int Calories
        {
            get
            {
                return this.calories;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(
                        "Calories can not be negative or greater than 100.");
                }

                this.calories = value;
            }
        }

        public override int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }

            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentException(
                        "Time can not be negative or greater than 20.");
                }

                this.timeToPrepare = value;
            }
        }

        public bool IsCarbonated
        {
            get
            {
                return this.isCarbonated;
            }

            set
            {
                this.isCarbonated = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(string.Format(
                "Carbonated: {0}", this.IsCarbonated ? "yes" : "no"));

            return result.ToString().Trim();
        }
    }
}