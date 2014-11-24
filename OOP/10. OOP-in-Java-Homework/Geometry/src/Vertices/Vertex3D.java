package Vertices;

public class Vertex3D extends Vertex {
    private double z;

    public Vertex3D(double x, double y, double z) {
        super(x, y);
        this.setZ(z);
    }

    public double getZ() {
        return this.z;
    }

    public void setZ(double z) {
        this.z = z;
    }

    public static double calculateDistance(Vertex3D one, Vertex3D two) {
        double distance = Math.sqrt(
                Math.pow(two.getX() - one.getX(), 2) +
                        Math.pow(two.getY() - one.getY(), 2) +
                        two.getZ() - one.getZ());

        return distance;
    }
}