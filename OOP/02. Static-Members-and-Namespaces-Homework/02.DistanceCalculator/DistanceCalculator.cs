/* Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space. Search in Internet how to calculate distance in the 3D Euclidian space.*/

using System;

internal static class DistanceCalculator
{
    public static float CalculateDistance(Point3D pointOne, Point3D pointTwo)
    {
        float distance = 0;

        distance = (float)Math.Sqrt(Math.Pow(pointTwo.X - pointOne.X, 2) +
            Math.Pow(pointTwo.Y - pointOne.Y, 2) + Math.Pow(pointTwo.Z - pointOne.Z, 2));

        return distance;
    }

    /*public static void Main()
    {
        Point3D pointOne = new Point3D((float)2.3, (float)12.1, (float)9.3);
        Point3D pointTwo = new Point3D((float)6.9, (float)2.6, (float)4.7);

        Console.WriteLine(DistanceCalculator.CalculateDistance(pointOne, pointTwo));
    }*/
}