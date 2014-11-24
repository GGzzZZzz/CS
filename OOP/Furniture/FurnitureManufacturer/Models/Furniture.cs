namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;

        private readonly MaterialType materialType;

        private decimal price;

        private decimal height;

        protected Furniture(
            string model,
            MaterialType materialType,
            decimal price,
            decimal height)
        {
            this.Model = model;
            this.materialType = materialType;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Model should be at least 3 symbols long!");
                }

                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.materialType.ToString();
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
                if (value <= 0.00m)
                {
                    throw new ArgumentException("Price can not be negative!");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("Height can not be negative!");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}