using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_propuesto_1
{
    class Program
    {
        static void Main()
        {
            // Declarar los arreglos para almacenar las temperaturas
            double[] temperaturasC = new double[7]; // Temperaturas en grados Celsius
            double[] temperaturasF = new double[7]; // Temperaturas en grados Fahrenheit

            // 1. Solicitar al usuario las 7 temperaturas en °C
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1} (°C): ");
                temperaturasC[i] = Convert.ToDouble(Console.ReadLine());
            }

            // 2. Convertir las temperaturas a Fahrenheit
            for (int i = 0; i < 7; i++)
            {
                temperaturasF[i] = (temperaturasC[i] * 9 / 5) + 32;
            }

            // 3. Mostrar las temperaturas en paralelo (°C ↔ °F)
            Console.WriteLine("\nTemperaturas registradas:");
            Console.WriteLine("Día\t°C\t\t°F");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i + 1}\t{temperaturasC[i]:0.00}\t→\t{temperaturasF[i]:0.00}");
            }

            // 4. Calcular estadísticas
            double suma = 0;
            double tempMin = temperaturasC[0];
            double tempMax = temperaturasC[0];
            int diaMasFrio = 1;
            int diaMasCaluroso = 1;
            int diasSobre30 = 0;
            int diasBajoCero = 0;

            // Recorrer las temperaturas para obtener los cálculos
            for (int i = 0; i < 7; i++)
            {
                double temp = temperaturasC[i];
                suma += temp;

                // Verificar si hay una temperatura menor (día más frío)
                if (temp < tempMin)
                {
                    tempMin = temp;
                    diaMasFrio = i + 1;
                }

                // Verificar si hay una temperatura mayor (día más caluroso)
                if (temp > tempMax)
                {
                    tempMax = temp;
                    diaMasCaluroso = i + 1;
                }

                // Contar días con más de 30 °C
                if (temp > 30)
                {
                    diasSobre30++;
                }

                // Contar días con temperatura bajo 0 °C
                if (temp < 0)
                {
                    diasBajoCero++;
                }
            }

            // Calcular el promedio
            double promedio = suma / 7;

            // 5. Mostrar los resultados estadísticos
            Console.WriteLine("\nEstadísticas de la semana:");
            Console.WriteLine($"Temperatura promedio: {promedio:0.00} °C");
            Console.WriteLine($"Día más frío: Día {diaMasFrio} con {tempMin:0.00} °C");
            Console.WriteLine($"Día más caluroso: Día {diaMasCaluroso} con {tempMax:0.00} °C");
            Console.WriteLine($"Días con más de 30 °C: {diasSobre30}");
            Console.WriteLine($"Días bajo 0 °C: {diasBajoCero}");
        }
    }
}

