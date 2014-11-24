package Shapes3D;

import Interfaces.AreaMeasurable;
import Interfaces.VolumeMeasurable;
import Shapes2D.Shape;
import Vertices.Vertex3D;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {
protected Vertex3D[] vertices;

    protected SpaceShape(Vertex3D[] vertices) {
        super(vertices);
        this.setVertices(vertices);
    }

    @Override
    public Vertex3D[] getVertices() {
        return this.vertices;
    }

    public void setVertices(Vertex3D[] vertices) {
        if(vertices == null){
            throw new NullPointerException("Vertices can not be null!");
        }

        this.vertices = new Vertex3D[]{vertices[0]};
    }

    @Override
    public abstract double getArea();

    @Override
    public abstract double getVolume();

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder(", Vertices coordinates: ");
        for (Vertex3D vertex : this.getVertices()) {
            result.append(
                    "X: " + vertex.getX() +
                            ", Y: " + vertex.getY()+
                            ", Z: " + vertex.getZ());
        }

        return super.toString() + result;
    }
}