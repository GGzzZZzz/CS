package Vertices;

public class Vertex2D extends Vertex {

    public Vertex2D(double x, double y) {
        super(x, y);
    }

    public static double calculateDistance(Vertex2D one, Vertex2D two){
        double distance = Math.sqrt(
                Math.pow(two.getX() - one.getX(), 2) + Math.pow(two.getY() - one.getY(), 2));

        return  distance;
    }
}