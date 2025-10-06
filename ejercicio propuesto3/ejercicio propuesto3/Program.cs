using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_propuesto3
{
    using System;

    class Program
    {
        static void Main()
        {
            // Solicitar el tamaño de los arreglos
            Console.Write("Ingrese la cantidad de elementos para cada arreglo: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Declarar los dos arreglos originales
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            // Llenar el primer arreglo
            Console.WriteLine("\nIngrese los valores para el arreglo 1:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Llenar el segundo arreglo
            Console.WriteLine("\nIngrese los valores para el arreglo 2:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Crear el tercer arreglo para almacenar los valores intercalados
            int[] resultado = new int[n * 2];
            int index = 0;

            // Intercalar los valores de arr1 y arr2
            for (int i = 0; i < n; i++)
            {
                resultado[index++] = arr1[i]; // Agrega un elemento de arr1
                resultado[index++] = arr2[i]; // Agrega un elemento de arr2
            }

            // Mostrar el arreglo resultante
            Console.WriteLine("\nArreglo intercalado:");
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.Write(resultado[i] + " ");
            }

            // Identificar el origen de cada valor
            Console.WriteLine("\n\nOrigen de cada valor:");
            for (int i = 0; i < resultado.Length; i++)
            {
                // Si el índice es par (0, 2, 4...), proviene de arr1
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{resultado[i]} (arr1)");
                }
                else
                {
                    Console.WriteLine($"{resultado[i]} (arr2)");
                }
            }
        }
    }

}
