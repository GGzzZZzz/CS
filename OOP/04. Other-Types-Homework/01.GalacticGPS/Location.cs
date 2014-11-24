/*Create a struct Location that holds fields of type double latitude and longitude of a given location. Create an enumeration Planet that holds the following constants: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune.
•	Add an enum field of type Planet. Encapsulate all fields. 
•	Add a constructor that holds 3 parameters: latitude, longitude and planet.
•	Override ToString() to print the current location in the format <latitude>, <longitude> - <location>*/

using System;
using System.Text;

public struct Location
{
    private double latitude;
    private double longitude;
    private Planet planet;

    public Location(double latitude, double longitude, Planet planet) : this()
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Planet = planet;
    }

    public double Latitude
    {
        get { return this.latitude; }
        set { this.latitude = value; }
    }

    public double Longitude
    {
        get { return this.longitude; }
        set { this.longitude = value; }
    }

    public Planet Planet
    {
        get { return this.planet; }
        set { this.planet = value; }
    }

    public override string ToString()
    {
        StringBuilder location = new StringBuilder();
        location.Append(this.Latitude + ", ");
        location.Append(this.Longitude + " - ");
        location.Append(this.Planet);

        return location.ToString();
    }
}