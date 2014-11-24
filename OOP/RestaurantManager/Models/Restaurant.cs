namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using RestaurantManager.Interfaces;

    public class Restaurant : IRestaurant
    {
        private string name;

        private string location;

        private IList<IRecipe> recipes = new List<IRecipe>();

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
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

        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The location is required.");
                }

                this.location = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get
            {
                return this.recipes;
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            if (this.recipes != null)
            {
                this.Recipes.Add(recipe);
            }
            else
            {
                throw new ArgumentNullException("Recipes can not be null!");
            }
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            if (this.recipes != null)
            {
                this.Recipes.Remove(recipe);
            }
            else
            {
                throw new ArgumentNullException("Recipes can not be null!");
            }
        }

        public string PrintMenu()
        {
            bool hasDrinks = false;
            bool hasSalads = false;
            bool hasMainCourses = false;
            bool hasDesserts = false;

            foreach (var recipe in this.recipes)
            {
                if (recipe is Drink)
                {
                    hasDrinks = true;
                }

                if (recipe is Salad)
                {
                    hasSalads = true;
                }

                if (recipe is MainCourse)
                {
                    hasMainCourses = true;
                }

                if (recipe is Dessert)
                {
                    hasDesserts = true;
                }
            }

            var ordered = from recipe in this.Recipes orderby recipe.Name select recipe;

            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("***** {0} - {1} *****", this.Name, this.Location));
            if (this.recipes.Count == 0)
            {
                result.Append("No recipes... yet");
            }
            else
            {
                if (hasDrinks)
                {
                    result.AppendLine("~~~~~ DRINKS ~~~~~");
                    foreach (var recipe in ordered)
                    {
                        if (recipe is Drink)
                        {
                            result.AppendLine(recipe.ToString());
                        }
                    }
                }

                if (hasSalads)
                {
                    result.AppendLine("~~~~~ SALADS ~~~~~");
                    foreach (var recipe in ordered)
                    {
                        if (recipe is Salad)
                        {
                            result.AppendLine(recipe.ToString());
                        }
                    }
                }

                if (hasMainCourses)
                {
                    result.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                    foreach (var recipe in ordered)
                    {
                        if (recipe is MainCourse)
                        {
                            result.AppendLine(recipe.ToString());
                        }
                    }
                }

                if (hasDesserts)
                {
                    result.AppendLine("~~~~~ DESSERTS ~~~~~");
                    foreach (var recipe in ordered)
                    {
                        if (recipe is Dessert)
                        {
                            result.AppendLine(recipe.ToString());
                        }
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}