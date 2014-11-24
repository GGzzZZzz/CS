using System;

internal class PersonTest
{
    public static void Main()
    {
        Person somePerson = new Person("Pesho", 27, "pesho@gmail.com");
        Person anotherPerson = new Person("Gosho", 32);
        Console.WriteLine(somePerson.ToString());
        Console.WriteLine();
        Console.WriteLine(anotherPerson.ToString());
    }
}