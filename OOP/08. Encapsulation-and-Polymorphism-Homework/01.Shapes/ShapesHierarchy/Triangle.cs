using System;

public class Triangle : BasicShape
{
    private double angleInDegrees;

    public Triangle(double width, double height, double angleInDegrees)
        : base(width, height)
    {
        this.AngleInDegrees = angleInDegrees;
    }

    public double AngleInDegrees
    {
        get
        {
            return this.angleInDegrees;
        }

        set
        {
            if (value < 0 || value > 360)
            {
                throw new ArgumentOutOfRangeException("angle", "Included angle should be in range [0..360] deg ");
            }

            this.angleInDegrees = value;
        }
    }

    public override double CalculateArea()
    {
        double area = (this.Width * this.Height) / 2 * Math.Sin(this.AngleInDegrees);

        return area;
    }

    public override double CalculatePerimeter()
    {
        double perimeter = this.Width + this.Height + Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) - (2 * this.Height * this.Width * Math.Cos(this.AngleInDegrees * Math.PI / 180)));

        return perimeter;
    }
}