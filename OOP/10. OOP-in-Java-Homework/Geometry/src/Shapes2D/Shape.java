package Shapes2D;

import Vertices.Vertex;

public abstract class Shape {
    protected Vertex[] vertices;

    protected Shape(Vertex[] vertices) {
        this.setVertices(vertices);
    }

    public Vertex[] getVertices() {
        return this.vertices;
    }

    public void setVertices(Vertex[] vertices) {
        if(vertices == null){
            throw new NullPointerException("Vertices can not be null!");
        }

        this.vertices = vertices;
    }

    @Override
    public String toString() {
        return "{Type: " + this.getClass().toString().substring(15);
    }
}