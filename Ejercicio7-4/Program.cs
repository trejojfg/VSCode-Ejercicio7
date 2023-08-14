using System;

namespace Ejercicio7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7-4

            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro 
            // con los siguientes datos:
            //  - Número de Artículo (1 a 15)
            //  - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            //          a) El número de artículo que más se vendió en total.
            //          b) Los números de artículos que no registraron ventas.
            //          c) Cuantas unidades se vendieron del número de artículo 10.

            int[] venta = new int[15];
            int A, V;
            int MaxVenta, MaxArticulo = 0;

            for (int x = 0; x < 15; x++){
                venta[x] = 0;
            }

            Console.WriteLine("Introduce un articulo vendido");
            A = int.Parse(Console.ReadLine());

            while (A != 0){
                Console.WriteLine("Introduce la cantidad vendida del articulo");
                V = int.Parse(Console.ReadLine());
                for (int x = 0; x < 15; x++){
                    if (A == x+1){
                        venta[x] += V;
                    }
                }

            Console.WriteLine("Introduce otro articulo vendido o cero para terminar");
            A = int.Parse(Console.ReadLine());
            }

            // Apartado A
            MaxVenta = venta[0];
            for (int x = 0; x < 15; x++){
                if (venta[x] > MaxVenta){
                    MaxVenta = venta[x];
                    MaxArticulo = x+1;
                }
            }

            Console.WriteLine("El articulo mas vendido es el " + MaxArticulo + " con un total de ventas de " + MaxVenta);

            // Apartado B
            Console.Write("Los articulos sin venta son: ");
            for (int x = 0; x < 15; x++){
                if (venta[x] == 0){
                    Console.Write((x+1) + ", ");
                }
            }
            Console.WriteLine("");

            // Apartado C
            Console.WriteLine("El articulo 10 tuvo una venta de: " + venta[9]);

            Console.WriteLine("Fin del programa!!!!!!");
        }
    }
}
