using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            {
                Console.WriteLine("Menú de operaciones:");
                Console.WriteLine("1. Pares e Impares");
                Console.WriteLine("2. Tabla de multiplicar");
                Console.WriteLine("3. Factorial de un número");
                Console.WriteLine("4. Números Primos");
                Console.WriteLine("5. Sucesión de Fibonacci");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese su elección (1-6): ");

                string12 input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            ParesImpares();
                            break;
                        case 2:
                            TablaDeMultiplicar();
                            break;
                        case 3:
                            Factorial();
                            break;
                        case 4:
                            NumerosPrimos();
                            break;
                        case 5:
                            Fibonacci();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número del 1 al 6.");
                }

            }
        }
        static void ParesImpares()
        {
            do
            {
                Console.Write("Ingrese un número entero positivo: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("Pares: ");
                    for (int i = 0; i <= numero; i++)
                    {
                        if (i % 2 == 0)
                            Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Impares: ");
                    for (int i = 0; i <= numero; i++)
                    {
                        if (i % 2 != 0)
                            Console.Write(i + " ");
                    }
                    Console.WriteLine();

                    int sumaPares = Enumerable.Range(0, numero + 1).Where(x => x % 2 == 0).Sum();
                    int sumaImpares = Enumerable.Range(0, numero + 1).Where(x => x % 2 != 0).Sum();
                    Console.WriteLine($"Suma de pares: {sumaPares}");
                    Console.WriteLine($"Suma de impares: {sumaImpares}");
                    Console.WriteLine(sumaPares > sumaImpares ? "La suma de pares es mayor que la suma de impares." : "La suma de impares es mayor que la suma de pares.");
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
                }

                Console.Write("¿Desea realizar otra operación en Pares e Impares? (s/n): ");
            } while (Console.ReadLine().Trim().ToLower() == "s");
        }
