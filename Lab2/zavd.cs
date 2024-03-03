using System;

class StringArray
{
    private string[] array;
    private int[] lengths;

    public StringArray()
    {
        array = new string[0];
        lengths = new int[0];
    }

    public StringArray(int size)
    {
        array = new string[size];
        lengths = new int[size];
    }

    public StringArray(string[] elements)
    {
        array = elements;
        lengths = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            lengths[i] = elements[i].Length;
        }
    }

    public int Length
    {
        get { return array.Length; }
    }

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException("Index is out of range");
            return array[index];
        }
        set
        {
            if (index < 0 || index >= array.Length)
                throw new IndexOutOfRangeException("Index is out of range");
            array[index] = value;
            lengths[index] = value.Length;
        }
    }

    public void PrintElement(int index)
    {
        Console.WriteLine("Element at index {0}: {1}", index, array[index]);
    }

    public void PrintAllElements()
    {
        Console.WriteLine("Array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element {0}: {1}", i, array[i]);
        }
    }
}
