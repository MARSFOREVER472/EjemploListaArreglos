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
            List<int[]> listaArreglos2 = new List<int[]>();

            // Agregamos tres arreglos a la lista 1
            listaArreglos.Add(new int[] { 1, 2, 3 }); // Para los números 1, 2 y 3.
            listaArreglos.Add(new int[] { 4, 5, 6 }); // Para los números 4, 5 y 6.
            listaArreglos.Add(new int[] { 7, 8, 9 }); // para los números 7, 8 y 9.

            // Agregamos tres arreglos a la lista 2

            listaArreglos2.Add(new int[] { 10, 11, 12 }); // Para los números 10, 11 y 12.
            listaArreglos2.Add(new int[] { 13, 14, 15 }); // Para los números 13, 14 y 15.
            listaArreglos2.Add(new int[] { 16, 17, 18 }); // para los números 16, 17 y 18.

            // Recorremos la lista de arreglos y mostramos su contenido.
            foreach (int[] arreglo in listaArreglos)
            {
                Console.WriteLine("Arreglo secuencial: ");
                foreach (int n in arreglo)
                {
                    Console.WriteLine(n);
                }
            }

            // Para la lista de arreglos número 2 hacemos el mismo proceso pero con otras variables.
            foreach (int[] arreglo in listaArreglos2)
            {
                Console.WriteLine("Arreglo secuencial 2: ");
                foreach (int n2 in arreglo)
                {
                    Console.WriteLine(n2);
                }
            }

            // Ejemplo de un algoritmo que suma los elementos de los arreglos en dos listas distintas.

            int sum1 = 0;
            int sum2 = 0;

            foreach (int[] array in listaArreglos)
            {
                foreach (int n in array)
                {
                    sum1 += n;
                }
            }
            Console.WriteLine("La suma total de los arreglos es: " + sum1);

            foreach (int[] array in listaArreglos2)
            {
                foreach (int n2 in array)
                {
                    sum2 += n2;
                }
            }
            Console.WriteLine("La suma total de los arreglos 2 es: " + sum2);

            Console.ReadLine();
        }
    }
}

