namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal Converted = 0.10m;
        private readonly decimal normal;
        private bool isConverted = false;

        public ConvertibleChair(
            string model,
            MaterialType materialType,
            decimal price,
            decimal height,
            int numberOfLegs)
            : base(
            model,
            materialType,
            price,
            height,
            numberOfLegs)
        {
            this.normal = height;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }

            set
            {
                this.isConverted = value;
            }
        }

        public void Convert()
        {
            if (this.IsConverted == false)
            {
                this.Height = Converted;
                this.IsConverted = true;
            }
            else
            {
                this.Height = this.normal;
                this.IsConverted = false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + 
                string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}