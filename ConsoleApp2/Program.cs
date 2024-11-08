using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de elementos en el arreglo: ");
            int n = int.Parse(Console.ReadLine());
            int[] arreglo = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el valor en la posición {i + 1}: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nArreglo original:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            Console.Write("\nIngrese la posición que desea eliminar (1 a " + n + "): ");
            int posicion = int.Parse(Console.ReadLine()) - 1;
            if (posicion < 0 || posicion >= n)
            {
                Console.WriteLine("La posición ingresada no es válida.");
            }
            else
            {
                int[] nuevoArreglo = new int[n - 1];
                for (int i = 0, j = 0; i < n; i++)
                {
                    if (i != posicion)
                    {
                        nuevoArreglo[j] = arreglo[i];
                        j++;
                    }
                }
                Console.WriteLine("\nArreglo después de eliminar el elemento:");
                for (int i = 0; i < nuevoArreglo.Length; i++)
                {
                    Console.Write(nuevoArreglo[i] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
