using System;

class ind
{
    private int[] array;

    public ind(int size)
    {
        array = new int[size];
    }

 
    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value * value;
        }
    }
}

class Program
{
    static void Main()
    {
        int size = 5;
        ind Array = new ind(size);

        Array[0] = 2;
        Array[1] = 3;
        Array[2] = 4;
        Array[3] = 5;
        Array[4] = 6;

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Элемент {i}: {Array[i]}");
        }
    }
}
