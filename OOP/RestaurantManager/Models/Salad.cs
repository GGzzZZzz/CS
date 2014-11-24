namespace RestaurantManager.Interfaces
{
    using System.Text;

    public class Salad : Meal, ISalad
    {
        private bool containsPasta;

        public Salad(
            string name,
            decimal price,
            int calories,
            int quantityPerServing,
            int timeToPrepare,
            bool containsPasta)
            : base(
            name,
            price,
            calories,
            quantityPerServing,
            timeToPrepare)
        {
            this.ContainsPasta = containsPasta;
            this.IsVegan = true;
        }

        public bool ContainsPasta
        {
            get
            {
                return this.containsPasta;
            }

            set
            {
                this.containsPasta = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.Append(string.Format(
                "Contains pasta: {0}", this.ContainsPasta ? "yes" : "no"));

            return result.ToString().Trim();
        }
    }
}