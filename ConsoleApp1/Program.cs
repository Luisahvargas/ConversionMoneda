using System;

namespace ConvertirMonedaCOP
{
    class Programa
    {
        static void Main(string[] args)
        {
            //Definir tasa de cambio//
            const decimal tasaUsd = 4000m; // 1 USD //
            const decimal tasaEur = 4500m; // 1 EUR //

            Console.WriteLine("Convertir de COP a USD y EUR");

            decimal valorCop;

            // Asegurar que el Usuario ingrese numero valido //
            while (true)
            {
                Console.WriteLine("Ingrese el valor en COP");
                string entrada = Console.ReadLine();

                if (decimal.TryParse(entrada, out valorCop) && valorCop >= 0)
                {
                    Console.WriteLine($"entrada valida: {valorCop} COP");

                    // Realizar conversiones de moneda //
                    decimal valorUsd = valorCop / tasaUsd;
                    decimal valorEur = valorCop / tasaEur;

                    Console.WriteLine($"El Valor USD es: {valorUsd:F2}");
                    Console.WriteLine($"El Valor EUR es: {valorEur:F2}");

                    Console.WriteLine("Presione cualquier tecla para salir");
                    Console.ReadKey();

                    break;

                    //Salida del ingreso de numero valido //

                    //Saldra error si digitamos numeros invalidos o letras ejem -100 o abc//
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un número válido mayor o igual a cero.");
                    Console.WriteLine("Por favor,intente nuevamente");
                }
            }
        }
    }
} 
//FIN 





