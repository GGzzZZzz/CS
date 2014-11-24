package Shapes3D;

import Vertices.Vertex3D;

public class SquarePyramid extends SpaceShape {
    private double baseWidth;
    private double height;

    public SquarePyramid(Vertex3D[] vertices, double baseWidth, double height) {
        super(vertices);
        this.setBaseWidth(baseWidth);
        this.setHeight(height);
    }

    public double getBaseWidth() {
        return this.baseWidth;
    }

    public void setBaseWidth(double baseWidth) {
        if (baseWidth < 0) {
            throw new IllegalArgumentException("Base width can not be negative!");
        }

        this.baseWidth = baseWidth;
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
    public double getArea() {
        double area = Math.pow(
                this.getBaseWidth(), 2) +
                2 * this.getBaseWidth() *
                        Math.sqrt(Math.pow(this.getBaseWidth(), 2) / 4 +
                                Math.pow(this.getHeight(), 2));
        return area;
    }

    @Override
    public double getVolume() {
        return (Math.pow(this.getBaseWidth(), 2)) *
                this.getHeight() / 3;
    }

    @Override
    public String toString() {
        return super.toString() +
                String.format(
                        ", Base Width: %.2f, Height: %.2f, Area: %.2f, Volume: %.2f}",
                        this.getBaseWidth(),
                        this.getHeight(),
                        this.getArea(),
                        this.getVolume());
    }
}