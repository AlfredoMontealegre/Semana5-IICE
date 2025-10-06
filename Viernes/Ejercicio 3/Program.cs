using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Intercalar_arreglos
{
    internal class Program
    {

        //Intercalar arreglos 
        //Enunciado: Solicita dos arreglos de n elementos cada uno.Crea un tercer arreglo que combine ambos intercalando los valores.
        //Identificar origen de cada valor 
        //Después de crear el arreglo intercalado, muestra para cada número si proviene de arr1 o arr2.

        static void Main(string[] args)
        {
            // n es el tammaño de los arreglos
            int n = 10;
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int[] array3 = new int[n * 2];

            Console.WriteLine("Ingrese los 10 números del primer arreglo:");
            for (int i = 0; i < array1.Length; i++)
            {
                
                Console.Write($"Número {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los 10 números del segundo arreglo:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Intercambiando los arreglos...");

            int j = 0; //Se crea otra variable para el arreglo 3
            for (int i = 0; i < 10; i++)
            {
                array3[j] = array1[i];
                Console.WriteLine(array1[i] + " (arr1)");
                j++; //Se incrementa j para que no se sobreescriba el valor anterior
                array3[j] = array2[i];
                Console.WriteLine(array2[i] + " (arr2)");
                j++;

            }
            Console.ReadKey(); //Pausa para ver el resultado

        }
    }
}
