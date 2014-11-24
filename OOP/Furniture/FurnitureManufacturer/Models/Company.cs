namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures = new List<IFurniture>();

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name should be at least 5 symbols long!");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException(
                        "Registration number should contains exactly 10 digits!");
                }

                long num;
                if (!long.TryParse(value, out num))
                {
                    throw new ArgumentException(
                        "Registration number should contains only digits!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture can not be null!");
            }

            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture can not be null!");
            }

            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            foreach (IFurniture furniture in this.Furnitures)
            {
                if (furniture.Model.ToLower().Equals(model.ToLower()))
                {
                    return furniture;
                }
            }

            return null;
        }

        public string Catalog()
        {
            var ordered = 
                from furniture in this.Furnitures
                orderby furniture.Price, furniture.Model
                select furniture;

            StringBuilder result = new StringBuilder();
            result.AppendLine(
                string.Format(
                    "{0} - {1} - {2} {3}",
                    this.Name,
                    this.RegistrationNumber,
                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                    this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            foreach (IFurniture furniture in ordered)
            {
                result.AppendLine(furniture.ToString());
            }

            return result.ToString().Trim();
        }
    }
}