namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class MainCourse : Meal, IMainCourse
    {
        private MainCourseType type;
        public MainCourse(
            string name,
            decimal price,
            int calories, 
            int quantityPerServing,
            int timeToPrepare,
            bool isVegan,
            MainCourseType type)
            : base(
            name,
            price,
            calories,
            quantityPerServing,
            timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Type = type;
        }

        public MainCourseType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.Append(string.Format("Type: {0}", this.Type));

            return result.ToString().Trim();
        }
    }
}