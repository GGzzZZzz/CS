package Shapes2D;

import Vertices.Vertex2D;

public class Rectangle extends PlaneShape {
    private double width;
    private double height;

    public Rectangle(Vertex2D[] vertices, double width, double height) {
        super(vertices);
        this.setWidth(width);
        this.setHeight(height);
    }

    @Override
    public void setVertices(Vertex2D[] vertices) {
        this.vertices = new Vertex2D[]{vertices[0]};
    }

    public double getWidth() {
        return this.width;
    }

    public void setWidth(double width) {
        if (width < 0) {
            throw new IllegalArgumentException("Width can not be negative!");
        }

        this.width = width;
    }

    public double getHeight() {
        return this.height;
    }

    public void setHeight(double height) {
        if (height < 0) {
            throw new IllegalArgumentException("Height can not be negative!");
        }

        this.height = height;
    }

    @Override
    public double getPerimeter() {
        double perimeter = (this.getWidth() + this.getHeight()) * 2;

        return perimeter;
    }

    @Override
    public double getArea() {
        return this.getWidth() * this.getHeight();
    }

    @Override
    public String toString() {
       return super.toString() +
               String.format("Width: %.2f, Height: %.2f, Perimeter: %.2f, Area: %.2f}",
                       this.getWidth(),
                       this.getHeight(),
                       this.getPerimeter(),
                       this.getArea());
    }
}