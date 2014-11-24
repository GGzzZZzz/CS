using System;

internal class Battery
{
    // fields
    private string type;
    private float life;

    // constructor
    public Battery(string type, float life)
    {
        this.Type = type;
        this.Life = life;
    }

    // properties
    public string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Battery type can not be empty!", "value");
            }

            this.type = value;
        }
    }

    public float Life
    {
        get
        {
            return this.life;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Battery life can not be negative!", "value");
            }

            this.life = value;
        }
    }
}