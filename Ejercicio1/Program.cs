using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    //Solicita al usuario ingresar 7 temperaturas registradas durante una semana(en °C) y guárdalas en un arreglo.
    //Luego, crea otro arreglo donde se almacenen esas mismas
    //temperaturas convertidas a Fahrenheit.
    //Muestra ambos arreglos en paralelo (°C ↔ °F).
    //- Cálculo de estadísticas avanzadas
    //Agrega cálculos adicionales como:
    //• Temperatura promedio.
    //• Día más frío y día más caluroso.
    //• Cuántos días estuvieron por encima de 30 °C.
    //• Cuántos días estuvieron bajo cero.

    internal class Program
    {
        class Temperatura
        {
            public double temperatura_promedio;
            public int dia_mas_frio;
            public int dia_mas_caluroso;
            public int dias_sobre_30;
            public int dias_bajo_cero;
        }
        class ArregloTemperaturas
        {
            public double[] temperaturas_celsius;
            public double[] temperaturas_fahrenheit;
            public Temperatura estadisticas;
        }


            static void Main(string[] args)
            {
            ArregloTemperaturas datos = new ArregloTemperaturas();
            datos.temperaturas_celsius = new double[7];
            datos.temperaturas_fahrenheit = new double[7];
            datos.estadisticas = new Temperatura();

            Console.WriteLine("Ingrese las 7 temperaturas en °C registradas durante la semana:");
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Día {i + 1}: ");
                datos.temperaturas_celsius[i] = double.Parse(Console.ReadLine());
            }

            // Convertir a Fahrenheit
            for (int i = 0; i < 7; i++)
            {
                datos.temperaturas_fahrenheit[i] = (datos.temperaturas_celsius[i] * 9 / 5) + 32;
            }

            Console.WriteLine("\nTemperaturas de la semana:");
            Console.WriteLine("Día\t°C\t\t°F");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{i + 1}\t{datos.temperaturas_celsius[i]}°C\t→\t{datos.temperaturas_fahrenheit[i]}°F");
            }

            // Calcular estadísticas
            double suma = 0;
            datos.estadisticas.dia_mas_frio = 0;
            datos.estadisticas.dia_mas_caluroso = 0;
            datos.estadisticas.dias_bajo_cero = 0;
            datos.estadisticas.dias_sobre_30 = 0;

            for (int i = 0; i < 7; i++)
            {
                double temp = datos.temperaturas_celsius[i];
                suma += temp;

                if (temp < datos.temperaturas_celsius[datos.estadisticas.dia_mas_frio])
                    datos.estadisticas.dia_mas_frio = i;
                if (temp > datos.temperaturas_celsius[datos.estadisticas.dia_mas_caluroso])
                    datos.estadisticas.dia_mas_caluroso = i;

                if (temp < 0)
                    datos.estadisticas.dias_bajo_cero++;
                if (temp > 30)
                    datos.estadisticas.dias_sobre_30++;
            }

            datos.estadisticas.temperatura_promedio = suma / 7;

            // Mostrar estadísticas
            Console.WriteLine("\n--- Estadísticas ---");
            Console.WriteLine($"Temperatura promedio: {datos.estadisticas.temperatura_promedio:F2} °C");
            Console.WriteLine($"Día más frío: Día {datos.estadisticas.dia_mas_frio + 1} ({datos.temperaturas_celsius[datos.estadisticas.dia_mas_frio]} °C)");
            Console.WriteLine($"Día más caluroso: Día {datos.estadisticas.dia_mas_caluroso + 1} ({datos.temperaturas_celsius[datos.estadisticas.dia_mas_caluroso]} °C)");
            Console.WriteLine($"Días sobre 30 °C: {datos.estadisticas.dias_sobre_30}");
            Console.WriteLine($"Días bajo 0 °C: {datos.estadisticas.dias_bajo_cero}");
        }
    }
}
