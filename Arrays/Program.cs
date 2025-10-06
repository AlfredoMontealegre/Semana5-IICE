// Ejercicio 3
// Intercalar dos arrays

using System.Collections.Immutable;

Console.WriteLine("-----> Intercalacion de Arrays <-----");
int[] arr1 = [1, 3, 5, 7, 9];
int[] arr2 = [2, 4, 6, 8, 10];

int[] arr3 =
    [.. arr1, .. arr2];

Console.WriteLine("Array 1: " + string.Join(", ", arr1));
Console.WriteLine("Array 2: " + string.Join(", ", arr2));
Console.WriteLine("Array Intercalado: " + string.Join(", ", Array.Sort(arr3));
Console.ReadKey();