using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Menu
    {
        public void menuPrincipal()
        {
            Console.WriteLine("1. Enter numbers");
            Console.WriteLine("2. Order numbers");
            Console.WriteLine("3. View history");
            Console.WriteLine("4. Exit");
        }

        public void historial(int burbuja, int shell, int seleccion, int inserccion)
        {
            Console.WriteLine("History of sorting methods used:");
            Console.WriteLine($"Bubble Sort: {burbuja}");
            Console.WriteLine($"Shell Sort: {shell}");
            Console.WriteLine($"Selection Sort: {seleccion}");
            Console.WriteLine($"Insertion Sort: {inserccion}");
        }

        public void menuOrdenar()
        {
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Shell Sort");
            Console.WriteLine("3. Selection Sort");
            Console.WriteLine("4. Insertion Sort");
        }
    }
}
