using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
internal class VersionAttribute : System.Attribute
{
    private int major;
    private int minor;

    public VersionAttribute(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }

    public int Major
    {
        get { return this.major; }
        set { this.major = value; }
    }

    public int Minor
    {
        get { return this.minor; }
        set { this.minor = value; }
    }

    public override string ToString()
    {
        return this.Major + "." + this.Minor;
    }
}