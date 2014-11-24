/* Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Create appropriate constructors. Implement the ToString() to enable printing a 3D point.
 Add a private static read-only field in the Point3D class to hold the start of the coordinate system – the point StartingPoint {0, 0, 0}. Add a static property to return the starting point.*/

using System;

public class Point3D
{
    private static readonly Point3D startingPoint;

    private float x;
    private float y;
    private float z;

    static Point3D()
    {
        startingPoint = new Point3D(0, 0, 0);
    }

    public Point3D(float x, float y, float z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public static Point3D StartingPoint
    {
        get { return Point3D.startingPoint; }
    }

    public float X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    public float Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public float Z
    {
        get { return this.z; }
        set { this.z = value; }
    }

    public override string ToString()
    {
        return string.Format("({0:F1} , {1:F1} , {2:F1})", this.X, this.Y, this.Z);
    }

    /*public static void Main()
    {
        Point3D point = new Point3D((float)5.5, (float)2.4, (float)6.1);
        Console.WritLine(point);
        Console.WriteLine(Point3D.startingPoint);
    }*/
}