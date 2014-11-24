namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Dessert : Meal, IDessert
    {
        private bool withSugar = true;

        public Dessert(
            string name,
            decimal price,
            int calories,
            int quantityPerServing,
            int timeToPrepare,
            bool isVegan)
            : base(
            name,
            price,
            calories,
            quantityPerServing,
            timeToPrepare)
        {
            this.IsVegan = isVegan;
        }

        public bool WithSugar
        {
            get
            {
                return this.withSugar;
            }

            set
            {
                this.withSugar = value;
            }
        }

        public void ToggleSugar()
        {
            if (WithSugar)
            {
                this.WithSugar = false;
            }
            else
            {
                this.WithSugar = true;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0}", this.WithSugar ? "" : "[NO SUGAR] "));
            result.AppendLine(base.ToString());

            return result.ToString().Trim();
        }
    }
}