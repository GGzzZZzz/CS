namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(
            string model,
            MaterialType materialType,
            decimal price,
            decimal height,
            decimal length,
            decimal width)
            : base(
            model,
            materialType,
            price,
            height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if (value < 0.00m)
                {
                    throw new ArgumentException("Length can not be negative!");
                }

                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0.00m)
                {
                    throw new ArgumentException("Width can not be negative!");
                }

                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Width * this.Length;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(
                ", Length: {0}, Width: {1}, Area: {2}",
                this.Length, this.Width, this.Area);
        }
    }
}