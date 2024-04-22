using System;

public class GenericArray<T>
{
    private T[] array;
    private int size;
    
    public GenericArray(int capacity)
    {
        array = new T[capacity];
        size = 0;
    }
    
    public void Add(T item)
    {
        if (size < array.Length)
        {
            array[size] = item;
            size++;
        }
        else
        {
            Console.WriteLine("Array is full, cannot add more items.");
        }
    }
    
    public void RemoveAt(int index)
    {
        if (index >= 0 && index < size)
        {
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
    
    public T Get(int index)
    {
        if (index >= 0 && index < size)
        {
            return array[index];
        }
        else
        {
            Console.WriteLine("Invalid index.");
            return default(T);
        }
    }
    
    public int Length()
    {
        return size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);
        
        GenericArray<string> stringArray = new GenericArray<string>(5);
        stringArray.Add("Hello");
        stringArray.Add("World");
        
        GenericArray<double> doubleArray = new GenericArray<double>(5);
        doubleArray.Add(3.14);
        doubleArray.Add(2.718);
        
        Console.WriteLine("Length of intArray: " + intArray.Length());
        Console.WriteLine("Length of stringArray: " + stringArray.Length());
        Console.WriteLine("Length of doubleArray: " + doubleArray.Length());
        
        Console.WriteLine("Element at index 1 of intArray: " + intArray.Get(1));
        Console.WriteLine("Element at index 0 of stringArray: " + stringArray.Get(0));
        Console.WriteLine("Element at index 1 of doubleArray: " + doubleArray.Get(1));
        
        intArray.RemoveAt(1);
        Console.WriteLine("Length of intArray after removal: " + intArray.Length());
    }
}
