// Ejercicio 1
// Solicita al usuario ingresar 7 temperaturas registradas durante una semana (en °C) y
// guárdalas en un arreglo. Luego, crea otro arreglo donde se almacenen esas mismas
// temperaturas convertidas a Fahrenheit.
// Muestra ambos arreglos en paralelo (°C ↔ °F).
// - Cálculo de estadísticas avanzadas
// Agrega cálculos adicionales como:
// • Temperatura promedio.
// • Día más frío y día más caluroso.
// • Cuántos días estuvieron por encima de 30 °C.
// • Cuántos días estuvieron bajo cero.

using System.Collections.Immutable;
using System.Globalization;
using System;

class Program
{
    static void Main()
    {
        const int DIAS = 7;
        double[] tempC = new double[DIAS];
        double[] tempF = new double[DIAS];

        // 1. Solicitar temperaturas
        for (int i = 0; i < DIAS; i++)
        {
            Console.Write($"Ingrese la temperatura del día {i + 1} (°C): ");
            tempC[i] = double.Parse(Console.ReadLine());
            tempF[i] = (tempC[i] * 9 / 5) + 32; // Conversión a Fahrenheit
        }

        Console.WriteLine("\nTemperaturas registradas:");
        Console.WriteLine("Día\t°C\t\t°F");
        for (int i = 0; i < DIAS; i++)
        {
            Console.WriteLine($"{i + 1}\t{tempC[i]}°C\t\t{tempF[i]}°F");
        }

        // 2. Estadísticas
        double suma = 0;
        double max = tempC[0];
        double min = tempC[0];
        int diaMax = 1, diaMin = 1;
        int diasSobre30 = 0, diasBajoCero = 0;

        for (int i = 0; i < DIAS; i++)
        {
            suma += tempC[i];

            if (tempC[i] > max)
            {
                max = tempC[i];
                diaMax = i + 1;
            }
            if (tempC[i] < min)
            {
                min = tempC[i];
                diaMin = i + 1;
            }
            if (tempC[i] > 30) diasSobre30++;
            if (tempC[i] < 0) diasBajoCero++;
        }

        double promedio = suma / DIAS;

        Console.WriteLine("\n--- Estadísticas ---");
        Console.WriteLine($"Temperatura promedio: {promedio:F2} °C");
        Console.WriteLine($"Día más frío: Día {diaMin} con {min} °C");
        Console.WriteLine($"Día más caluroso: Día {diaMax} con {max} °C");
        Console.WriteLine($"Días con más de 30 °C: {diasSobre30}");
        Console.WriteLine($"Días bajo 0 °C: {diasBajoCero}");
        Console.ReadKey();
    }
}
