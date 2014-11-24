package Shapes2D;

import Interfaces.PerimeterMeasurable;
import Interfaces.AreaMeasurable;
import Vertices.Vertex2D;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable {
    protected Vertex2D[] vertices;

    protected PlaneShape(Vertex2D[] vertices) {
        super(vertices);
        this.setVertices(vertices);
    }

    @Override
    public Vertex2D[] getVertices() {
        return this.vertices;
    }

    public void setVertices(Vertex2D[] vertices) {
        if(vertices == null){
            throw new NullPointerException("Vertices can not be null!");
        }
        this.vertices = vertices;
    }

    @Override
    public abstract double getPerimeter();

    @Override
    public abstract double getArea();

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder(", Vertices coordinates: ");
        for (Vertex2D vertex : this.getVertices()) {
            result.append("X: " + vertex.getX() + ", Y: " + vertex.getY()+ ", ");
        }

        return super.toString() + result;
    }
}