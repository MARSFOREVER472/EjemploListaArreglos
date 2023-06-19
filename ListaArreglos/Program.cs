using System; // Importamos las variables.
using System.Collections.Generic;

namespace ListaArreglos // namespace asociado a la solución.
{
    class Program // Clase Program.
    {
        static void Main(string[] args) // Main por defecto.
        {
            // Creamos una lista de arreglos de enteros
            List<int[]> listaArreglos = new List<int[]>();

            // Agregamos dos arreglos a la lista
            listaArreglos.Add(new int[] { 1, 2, 3 }); // Para los números 1, 2 y 3.
            listaArreglos.Add(new int[] { 4, 5, 6 }); // Para los números 4, 5 y 6.

            // Recorremos la lista de arreglos y mostramos su contenido.
            foreach (int[] arreglo in listaArreglos)
            {
                Console.WriteLine("Arreglo: ");
                foreach (int n in arreglo)
                {
                    Console.WriteLine(n);
                }
            }

            // Ejemplo de un algoritmo que suma los elementos de los arreglos en la lista.
            int sumTotal = 0;
            foreach (int[] array in listaArreglos)
            {
                foreach (int n in array)
                {
                    sumTotal += n;
                }
            }
            Console.WriteLine("La suma total de los arreglos es: " + sumTotal);

            Console.ReadLine();
        }
    }
}

