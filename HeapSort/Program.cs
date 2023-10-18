using System;
using System.Data;

public class HeapSort
{
    public static void Main(string[] args)

    {
        int[] array = { 10, 16, 7, 9, 4, 2, 1 };

        Console.WriteLine("Oringal Array ");

        foreach (int i in array)
        {
            Console.Write(i + " ");
        }

        Sort<int>(array);

        Console.WriteLine("\nSorted Array ");

        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }

    private static void Sort<T>(T[] array) where T : IComparable<T>
    {
        int length = array.Length;
        T temp;

        for (int i = length/2; i >= 0; i--)
        {
            Heapify(array, length-1, i);
        }

        for (int i = length-1; i >= 0; i--)
        {
            temp = array[i];
            array[i] = array[0];
            array[0] = temp;

            Heapify(array, i-1, 0);
        }
    }

     static void Heapify<T>(T[] array, int length, int parrent) where T : IComparable<T>
    {
       int max = parrent;
       int leftChild = 2 * parrent + 1;
       int rightChild = 2 * parrent + 2;

        if (leftChild <= length && array[leftChild].CompareTo(array[max]) > 0)
        {
            max = leftChild;
        }
        if (rightChild <= length && array[rightChild].CompareTo(array[max]) > 0)
        {
            max = rightChild;
        }

        if(max != parrent) 
        {
            T temp = array[parrent];
            array[parrent] = array[max];
            array[max] = temp;
       
            Heapify(array, length, max);
        }

    }

}

