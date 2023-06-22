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

            // Agregamos tres arreglos a la lista 1 (Impares y Pares).
            listaArreglos.Add(new int[] { 1, 3, 5, 7, 9 }); // Para los números impares.
            listaArreglos.Add(new int[] { 2, 4, 6, 8, 10 }); // Para los números pares.

            // Agregamos tres arreglos a la lista 2 (Primos y Compuestos).

            listaArreglos2.Add(new int[] { 11, 13, 17, 19, 23 }); // Para los números primos.
            listaArreglos2.Add(new int[] { 12, 14, 15, 16, 18, 21, 22 }); // Para los números compuestos.

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

