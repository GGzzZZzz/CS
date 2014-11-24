package Shapes3D;

import Vertices.Vertex3D;

public class Sphere extends SpaceShape {
    private double radius;

    public Sphere(Vertex3D[] vertices, double radius) {
        super(vertices);
        this.setRadius(radius);
    }

    public double getRadius() {
        return this.radius;
    }

    public void setRadius(double radius) {
        if (radius < 0) {
            throw new IllegalArgumentException("Radius can not be negative!");
        }

        this.radius = radius;
    }

    @Override
    public double getArea() {
        return 4 * Math.PI * Math.pow(this.getRadius(), 2);
    }

    @Override
    public double getVolume() {
        return (4 / 3) * Math.PI * Math.pow(this.getRadius(), 2);
    }

    @Override
    public String toString() {
        return super.toString() +
                String.format(
                        ", Radius: %.2f, Area: %.2f, Volume: %.2f}",
                        this.getRadius(), this.getArea(), this.getVolume());
    }
}