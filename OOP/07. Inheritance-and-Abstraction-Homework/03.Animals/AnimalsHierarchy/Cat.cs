using System;

public abstract class Cat : Animal
{
    public Cat(string name, int age)
        : base(name, age)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Miay, miay");
    }
}