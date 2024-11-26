using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Program
    {
        static Metodos metodos = new Metodos();
        static Menu menu = new Menu();
        static int burbujaCount = 0;
        static int shellCount = 0;
        static int seleccionCount = 0;
        static int inserccionCount = 0;
        static int[] numerosGuardados = null;
        static void Main(string[] args)
        {
            try
            {
                int opcion;
                do
                {
                    menu.menuPrincipal();
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            numerosGuardados = iniciar();
                            break;
                        case 2:
                            if (numerosGuardados == null)
                            {
                                Console.WriteLine("You need to enter numbers first.");
                            }
                            else
                            {
                                primeraOpcion(numerosGuardados);
                            }
                            break;
                        case 3:
                            historialMetodo();
                            break;
                        case 4:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                } while (opcion != 4);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        static int[] iniciar()
        {
            int[] numeros = new int[10];
            Console.WriteLine("Enter 10 different numbers:");

            for (int i = 0; i < 10; i++)
            {
                int num;
                do
                {
                    Console.Write($"Enter number {i + 1}: ");
                    num = int.Parse(Console.ReadLine());

                    if (metodos.repetido(num, numeros))
                    {
                        Console.WriteLine("This number is repeated. Please enter a different number.");
                    }
                } while (metodos.repetido(num, numeros));
                numeros[i] = num;
            }

            return numeros;
        }

        static void primeraOpcion(int[] numeros)
        {
            menu.menuOrdenar();
            int metodo = int.Parse(Console.ReadLine());

            switch (metodo)
            {
                case 1:
                    metodos.ordenarBurbuja(numeros);
                    burbujaCount++;
                    break;
                case 2:
                    metodos.ordenarShell(numeros);
                    shellCount++;
                    break;
                case 3:
                    metodos.ordenarSeleccion(numeros);
                    seleccionCount++;
                    break;
                case 4:
                    metodos.ordenarInserccion(numeros);
                    inserccionCount++;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            Console.WriteLine("Ordered numbers:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }

        static void historialMetodo()
        {
            menu.historial(burbujaCount, shellCount, seleccionCount, inserccionCount);
        }
    }
}
