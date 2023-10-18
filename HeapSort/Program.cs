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

        sort(array);

        Console.WriteLine("\nSorted Array ");

        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }

    private static void sort(int[] array)
    {
        int length = array.Length;
        int temp;

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

     static void Heapify(int[] array, int length, int parrent)
    {
       int max = parrent;
       int leftChild = 2 * parrent + 1;
       int rightChild = 2 * parrent + 2;

        if (leftChild <= length && array[leftChild] > array[max])
        {
            max = leftChild;
        }
        if (rightChild <= length && array[rightChild] > array[max])
        {
            max = rightChild;
        }

        if(max != parrent) 
        {
            int temp = array[parrent];
            array[parrent] = array[max];
            array[max] = temp;
       
            Heapify(array, length, max);
        }

    }

}

