package Vertices;

public abstract class Vertex {
    private double x;
    private double y;

    public Vertex(double x, double y) {
        this.setX(x);
        this.setY(y);
    }

    public double getX() {
        return this.x;
    }

    public double getY() {
        return this.y;
    }

    public void setX(double x) {
        this.x = x;
    }

    public void setY(double y) {
        this.y = y;
    }
}