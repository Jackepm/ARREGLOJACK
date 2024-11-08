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


            Console.ReadKey();
        }
    }
}
