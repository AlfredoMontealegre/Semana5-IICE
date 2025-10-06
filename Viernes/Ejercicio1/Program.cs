using System;
using System.Linq;

namespace Ejercicio1
{
    internal class Temperatura
    {
        static void Main()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            double[] temperaturaC = new double[7];
            double[] temperaturaF = new double[7];

            // Solicitar temperaturas en °C
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Escribe la temperatura para {dias[i]} (°C): ");

                // TryParse significa que intenta convertir la entrada del usuario a un número double. Y si no puede, devuelve false en lugar de lanzar una excepción.
                // El out significa que la variable temperaturaC[i] se pasará por referencia. Luego, se asignará el valor convertido si la conversión es correcta.
                while (!double.TryParse(Console.ReadLine(), out temperaturaC[i]))
                {
                    Console.Write("Valor inválido. Intenta de nuevo: ");
                }
                temperaturaF[i] = (temperaturaC[i] * 9 / 5) + 32;
            }

            // Mostrar ambos arreglos en paralelo
            // Nombre de las columnas
            Console.WriteLine("\nDía\t\t°C\t\t°F");
            for (int i = 0; i < 7; i++)
            {
                // \t es para que se imprima en columnas
                Console.WriteLine($"{dias[i],-10}\t{temperaturaC[i],6:F1}\t{temperaturaF[i],8:F1}");
            }

            // Estadísticas
            // Average es un método que calcula el promedio de una secuencia de valores numéricos
            double promedio = temperaturaC.Average();

            // Días con temperatura > 30°C y < 0°C, t es igual a la abreviación de temperatura
            int diasSobre30 = temperaturaC.Count(t => t > 30); 
            int diasBajoCero = temperaturaC.Count(t => t < 0);

            // IndexOf es un método que busca el índice de un elemento específico en una matriz o lista, en este caso de la tem min y max
            int diaMasFrio = Array.IndexOf(temperaturaC, temperaturaC.Min());
            int diaMasCaluroso = Array.IndexOf(temperaturaC, temperaturaC.Max());

            Console.WriteLine($"\nTemperatura promedio: {promedio:F2} °C");
            Console.WriteLine($"Día más frío: {dias[diaMasFrio]} ({temperaturaC[diaMasFrio]:F1} °C)");
            Console.WriteLine($"Día más caluroso: {dias[diaMasCaluroso]} ({temperaturaC[diaMasCaluroso]:F1} °C)");
            Console.WriteLine($"Días por encima de 30°C: {diasSobre30}");
            Console.WriteLine($"Días bajo cero: {diasBajoCero}");
        }
    }
}
