namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(
            string model,
            MaterialType materialType,
            decimal price,
            decimal height,
            int numberOfLegs)
            : base(
            model,
            materialType,
            price,
            height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Legs can not be negative!");
                }

                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}", this.NumberOfLegs);
        }
    }
}