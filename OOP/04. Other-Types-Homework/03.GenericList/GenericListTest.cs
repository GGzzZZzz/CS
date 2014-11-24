using System;

internal class GenericListTest
{
    public static void Main()
    {
        GenericList<int> list = new GenericList<int>();

        // display version
        Type type = typeof(GenericList<>);
        object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
        Console.WriteLine("Class's Version {0} \n", allAttributes[0]);

        list.AddElement(4);
        list.AddElement(324235);
        list.AddElement(56);
        list.AddElement(1000);
        list.AddElement(12345);

        list.InsertElement(2, 100);

        list.RemoveElement(2);

        Console.WriteLine(list[2]);

        Console.WriteLine(list.ReturnIndex(12345));

        Console.WriteLine(list.IsContains(10));

        Console.WriteLine(list.MaxValue<int>());
        Console.WriteLine(list.MinValue<int>());

        Console.WriteLine(list);

        list.ClearList();

        // list.MaxValue<int>(); // this throws an exception
        list.AddElement(234);
        Console.WriteLine(list);
    }
}