using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        class ArregloNumeros
        {
            public int[] valores;

            public ArregloNumeros(int n)
            {
                valores = new int[n];
            }

            // Método para llenar el arreglo desde teclado
            public void IngresarValores(string nombre)
            {
                Console.WriteLine($"\n--- Ingreso de datos para {nombre} ---");
                for (int i = 0; i < valores.Length; i++)
                {
                    Console.Write($"Elemento {i + 1}: ");
                    valores[i] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Clase que combina los dos arreglos y muestra resultados
        class Intercalador
        {
            public int[] resultado;

            public void Intercalar(ArregloNumeros arr1, ArregloNumeros arr2)
            {
                int n = arr1.valores.Length;
                resultado = new int[n * 2];
                int index = 0;

                for (int i = 0; i < n; i++)
                {
                    resultado[index++] = arr1.valores[i];
                    resultado[index++] = arr2.valores[i];
                }
            }

            public void MostrarResultado()
            {
                Console.WriteLine("\n--- Arreglo intercalado ---");
                Console.Write("Resultado = [ ");
                foreach (var num in resultado)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine("]");
            }

            public void MostrarOrigen()
            {
                Console.WriteLine("\n--- Origen de cada valor ---");
                for (int i = 0; i < resultado.Length; i++)
                {
                    string origen = (i % 2 == 0) ? "arr1" : "arr2";
                    Console.WriteLine($"{resultado[i]} ({origen})");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de elementos para cada arreglo: ");
            int n = int.Parse(Console.ReadLine());

            ArregloNumeros arr1 = new ArregloNumeros(n);
            ArregloNumeros arr2 = new ArregloNumeros(n);

            arr1.IngresarValores("arr1");
            arr2.IngresarValores("arr2");

            Intercalador combinador = new Intercalador();
            combinador.Intercalar(arr1, arr2);

            combinador.MostrarResultado();
            combinador.MostrarOrigen();
        }
    }
}
