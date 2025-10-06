// Ejercicio 3
// Intercalar dos arrays

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----> Intercalación de Arrays <-----");

        int[] arr1 = { 1, 3, 5, 7, 9 };
        int[] arr2 = { 2, 4, 6, 8, 10 };

        int[] arr3 = new int[arr1.Length + arr2.Length];

        int index = 0;

        // Intercalar los elementos
        for (int i = 0; i < arr1.Length; i++)
        {
            arr3[index++] = arr1[i];
            arr3[index++] = arr2[i];
        }

        Console.WriteLine("Array 1: " + string.Join(", ", arr1));
        Console.WriteLine("Array 2: " + string.Join(", ", arr2));
        Console.WriteLine("Array Intercalado: " + string.Join(", ", arr3));

        Console.ReadKey();
    }
}
