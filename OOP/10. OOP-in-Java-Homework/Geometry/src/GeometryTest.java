import Interfaces.PerimeterMeasurable;
import Interfaces.VolumeMeasurable;
import Shapes2D.Circle;
import Shapes2D.PlaneShape;
import Shapes2D.Rectangle;
import Shapes2D.Triangle;
import Shapes3D.Cuboid;
import Shapes3D.Sphere;
import Shapes3D.SquarePyramid;
import Vertices.Vertex2D;
import Vertices.Vertex3D;
import Shapes2D.Shape;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class GeometryTest {
    public static void main(String[] args) {
        Vertex2D[] triangleVertices = new Vertex2D[]{
                new Vertex2D(5.2, 3.7),
                new Vertex2D(0.5, 2.1),
                new Vertex2D(2.9, 5.6),
        };
        Shape triangle = new Triangle(triangleVertices);

        Vertex2D[] rectangleVertices = new Vertex2D[]{
                new Vertex2D(11.3, 2.8)
        };
        Shape rectangle = new Rectangle(rectangleVertices, 12, 9);

        Vertex2D[] circleVertices = new Vertex2D[]{
                new Vertex2D(0.8, 6.6)
        };
        Shape circle = new Circle(circleVertices, 5.5);

        Vertex3D[] pyramidVertex = new Vertex3D[]{
                new Vertex3D(11.90, 4.7, 3.76)
        };
        Shape pyramid = new SquarePyramid(pyramidVertex, 10.22, 7.09);

        Vertex3D[] cuboidVertices = new Vertex3D[]{
                new Vertex3D(9.54, 3.55, 7.22)
        };
        Cuboid cuboid = new Cuboid(cuboidVertices, 12.12, 9.9, 7.7);

        Vertex3D[] sphereVertices = new Vertex3D[]{
                new Vertex3D(5.5, 0.8, 3.4)
        };
        Shape sphere = new Sphere(sphereVertices, 3.2);

        Shape[] shapes = new Shape[]{
                triangle,
                rectangle,
                circle,
                pyramid,
                cuboid,
                sphere
        };

        for (Shape shape : shapes) {
            System.out.println(shape);
        }
        System.out.println();

        List<Shape> filteredByVolume = Arrays.asList(shapes)
                .stream()
                .filter(shape -> shape instanceof VolumeMeasurable)
                .filter(volume -> ((VolumeMeasurable) volume)
                        .getVolume() > 40)
                .collect(Collectors.toList());

        for (Shape shape : filteredByVolume) {
            System.out.println(shape);
        }

        System.out.println();

        Comparator<Shape> comparator = (shapeOne, shapeTwo) -> {
            PerimeterMeasurable firstShape = (PerimeterMeasurable) shapeOne;
            double perimeterOne = firstShape.getPerimeter();
            PerimeterMeasurable secondShape = (PerimeterMeasurable) shapeTwo;
            double perimeterTwo = secondShape.getPerimeter();
            if (perimeterOne < perimeterTwo) {
                return -1;
            }
            if (perimeterOne > perimeterTwo) {
                return 1;
            } else {
                return 0;
            }
        };
        List<Shape> filteredByPerimeter = Arrays.asList(shapes)
                .stream()
                .filter(shape -> shape instanceof PlaneShape)
                .sorted(comparator)
                .collect(Collectors.toList());

        for (Shape shape : filteredByPerimeter) {
            System.out.println(shape);
        }
    }
}