package Shapes2D;

import Vertices.Vertex2D;

public class Circle extends PlaneShape {
    private double radius;

    public Circle(Vertex2D[] vertices, double radius) {
        super(vertices);
        this.setRadius(radius);
    }

    @Override
    public void setVertices(Vertex2D[] vertices) {
        this.vertices = new Vertex2D[]{vertices[0]};
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
    public double getPerimeter() {
        return 2 * Math.PI * this.getRadius();
    }

    @Override
    public double getArea() {
        return Math.PI * Math.pow(this.getRadius(), 2);
    }

    @Override
    public String toString() {
        return super.toString() +
                String.format(
                        "Radius: %.2f, Perimeter: %.2f, Area: %.2f}",
                        this.getRadius(),
                        this.getPerimeter(),
                        this.getArea());

    }
}