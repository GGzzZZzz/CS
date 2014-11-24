package Shapes2D;

import Vertices.Vertex2D;

public class Triangle extends PlaneShape {
    public Triangle(Vertex2D[] vertices) {
        super(vertices);
    }

    @Override
    public void setVertices(Vertex2D[] vertices) {
        this.vertices = new Vertex2D[]{vertices[0], vertices[1], vertices[2]};
    }

    @Override
    public double getPerimeter() {
        if (isTriangle()) {
            double perimeter = this.calculateSideA() +
                    this.calculateSideB() +
                    this.calculateSideC();

            return perimeter;
        } else {
            throw new IllegalArgumentException("This is not a valid triangle!");
        }
    }

    @Override
    public double getArea() {
        double halfPerimeter = this.getPerimeter() / 2;
        double a = this.calculateSideA();
        double b = this.calculateSideB();
        double c = this.calculateSideC();
        // Hero's formula
        double area = Math.sqrt(
                halfPerimeter *
                        (halfPerimeter - a) *
                        (halfPerimeter - b) *
                        (halfPerimeter - c));

        return area;
    }

    private boolean isTriangle() {
        double sideA = calculateSideA();
        double sideB = calculateSideB();
        double sideC = calculateSideC();

        boolean abc = sideA + sideB > sideC;
        boolean acb = sideA + sideC > sideB;
        boolean bca = sideB + sideC > sideA;

        boolean isTriangle = abc && acb && bca;

        return isTriangle;
    }

    private double calculateSideA() {
        double sideA = Vertex2D.calculateDistance(
                this.getVertices()[0],
                this.getVertices()[1]);

        return sideA;
    }

    private double calculateSideB() {
        double sideB = Vertex2D.calculateDistance(
                this.getVertices()[1],
                this.getVertices()[2]);

        return sideB;
    }

    private double calculateSideC() {
        double sideC = Vertex2D.calculateDistance(
                this.getVertices()[2],
                this.getVertices()[0]);

        return sideC;
    }

    @Override
    public String toString() {

        return super.toString() +
                String.format("Perimeter: %.2f, Area: %.2f}",
                        this.getPerimeter(),
                        this.getArea());
    }
}