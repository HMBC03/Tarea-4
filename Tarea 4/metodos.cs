using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Metodos
    {
        public int numero { get; set; }
        public int[] numeros { get; set; }

        public bool repetido(int numero, int[] numeros)
        {
            foreach (int n in numeros)
            {
                if (n == numero) return true;
            }
            return false;
        }

        public void ordenarBurbuja(int[] numeros)
        {
            int n = numeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }
        }

        public void ordenarShell(int[] numeros)
        {
            int n = numeros.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = numeros[i];
                    int j;
                    for (j = i; j >= gap && numeros[j - gap] > temp; j -= gap)
                    {
                        numeros[j] = numeros[j - gap];
                    }
                    numeros[j] = temp;
                }
            }
        }

        public void ordenarSeleccion(int[] numeros)
        {
            int n = numeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (numeros[j] < numeros[min_idx])
                        min_idx = j;

                int temp = numeros[min_idx];
                numeros[min_idx] = numeros[i];
                numeros[i] = temp;
            }
        }

        public void ordenarInserccion(int[] numeros)
        {
            int n = numeros.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = numeros[i];
                int j = i - 1;

                while (j >= 0 && numeros[j] > key)
                {
                    numeros[j + 1] = numeros[j];
                    j = j - 1;
                }
                numeros[j + 1] = key;
            }
        }

        public void escribir(int[] numeros, string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                foreach (int numero in numeros)
                {
                    sw.WriteLine(numero);
                }
            }
        }

        public int[] leer(string ruta)
        {
            string[] lines = File.ReadAllLines(ruta);
            int[] numeros = Array.ConvertAll(lines, int.Parse);
            return numeros;
        }
    }
}
