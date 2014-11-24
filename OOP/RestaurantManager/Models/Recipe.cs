namespace RestaurantManager.Interfaces
{
    using System;
    using System.Text;

    using RestaurantManager.Models;

    public abstract class Recipe : IRecipe
    {
        protected string name;

        protected decimal price;

        protected int calories;

        protected int quantityPerServing;

        private MetricUnit unit;

        protected int timeToPrepare;

        protected Recipe(
            string name,
            decimal price,
            int calories,
            int quantityPerServing,
            int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is required.");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be positive.");
                }

                this.price = value;
            }
        }

        public virtual int Calories
        {
            get
            {
                return this.calories;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The calories must be positive.");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The quantityPerServing must be positive.");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit
        {
            get
            {
                return this.unit;
            }

            set
            {
                this.unit = value;
            }
        }

        public virtual int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The timeToPrepare must be positive.");
                }

                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            string unitasString = string.Empty;
            if (this.Unit == MetricUnit.Grams)
            {
                unitasString = "g";
            }
            else
            {
                unitasString = "ml";
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("==  {0} == ${1:F2}", this.Name, this.Price));
            result.AppendLine(
                string.Format(
                "Per serving: {0} {1}, {2} kcal",
                this.QuantityPerServing,
                unitasString, 
                this.Calories));
            result.Append(string.Format("Ready in {0} minutes", this.TimeToPrepare));

            return result.ToString().Trim();
        }
    }
}