package Shapes3D;

import Vertices.Vertex3D;

public class Cuboid extends SpaceShape {
    private double width;
    private double height;
    private double depth;

    public Cuboid(Vertex3D[] vertices, double width, double height, double depth) {
        super(vertices);
        this.setWidth(width);
        this.setHeight(height);
        this.setDepth(depth);
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

    public double getDepth() {
        return depth;
    }

    public void setDepth(double depth) {
        if (depth < 0) {
            throw new IllegalArgumentException("Depth can not be negative!");
        }

        this.depth = depth;
    }

    @Override
    public double getArea() {
        double area = 2 * (
                this.getWidth() * this.getDepth() +
                        this.getDepth() * this.getHeight() +
                        this.getHeight() * this.getWidth());

        return area;
    }

    @Override
    public double getVolume() {
        return this.getWidth() * this.getHeight() * this.getDepth();
    }

    @Override
    public String toString() {
        return super.toString() +
                String.format(
                        ", Width: %.2f, Height: %.2f, Depth: %.2f, Area: %.2f, Volume: %.2f}",
                        this.getWidth(),
                        this.getHeight(),
                        this.getDepth(),
                        this.getArea(),
                        this.getVolume());
    }
}