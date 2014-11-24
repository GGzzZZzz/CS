using System;
using System.Linq;
using System.Text;

[Version (1,2)]
internal class GenericList<T> where T : IComparable<T>
{
    private const int DefaultCapacity = 16;
    private T[] elements;
    private int count = 0;

    public GenericList(int capacity = DefaultCapacity)
    {
        this.Elements = new T[capacity];
    }

    public int Count
    {
        get { return this.count; }
        set { this.count = value; }
    }

    public T[] Elements
    {
        get
        {
            return this.elements;
        }

        set
        {
            this.elements = value;
        }
    }

    // access by index
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(string.Format(
                    "Invalid index: {0}.", index));
            }

            return this.Elements[index];
        }
    }

    // add element
    public void AddElement(T element)
    {
        if (this.Count > this.Elements.Length)
        {
            this.GrowArray();
        }

        this.Elements[this.Count] = element;
        this.Count++;
    }

    // remove element
    public T[] RemoveElement(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new IndexOutOfRangeException(string.Format(
                    "Invalid index: {0}.", index));
        }

        for (int i = index; i < this.Count - 1; i++)
        {
            this.Elements[i] = this.Elements[i + 1];
        }

        this.Count--;

        return this.Elements;
    }

    // insert element
    public void InsertElement(int index, T element)
    {
        if (index < 0 || index > this.Count)
        {
            throw new IndexOutOfRangeException(string.Format(
                    "Invalid index: {0}.", index));
        }

        if (this.Count > this.Elements.Length)
        {
            this.GrowArray();
        }

        for (int i = this.Count; i > index; i--)
        {
            this.Elements[i] = this.Elements[i - 1];
        }

        this.Elements[index] = element;
        this.Count++;
    }

    // clear list
    public void ClearList()
    {
        this.Elements = new T[DefaultCapacity];
        this.Count = 0;
    }

    // find element by value
    public int ReturnIndex(T element)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this.Elements[i].Equals(element))
            {
                return i;
            }
        }

        return -1;
    }

    // check list for certain value
    public bool IsContains(T element)
    {
        return this.Elements.Contains(element);
    }

    // print list
    public override string ToString()
    {
        string result = string.Empty;
        for (int i = 0; i < this.Count; i++)
        {
            result += string.Format("[{0}] = " + this.Elements[i] + "\n", i);
        }

        return result;
    }
   
    // find min value
    public T MinValue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The list has no elements to compare!");
        }

        T min = this.Elements[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.Elements[i].CompareTo(min) < 0)
            {
                min = this.Elements[i];
            }
        }

        return min;
    }

    //find max value
    public T MaxValue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The list has no elements to compare!");
        }

        T max = this.Elements[0];
        for (int i = 1; i < this.Count; i++)
        {
            if (this.Elements[i].CompareTo(max) > 0)
            {
                max = this.Elements[i];
            }
        }

        return max;
    }

    // grow array
    private void GrowArray()
    {
        T[] newArray = new T[this.Elements.Length * 2];
        for (int i = 0; i < this.Count; i++)
        {
            newArray[i] = this.Elements[i];
        }

        this.Elements = newArray;
    }
}