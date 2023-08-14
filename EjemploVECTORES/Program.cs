using System;

namespace EjemploVECTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            // VECTORES - ARRAY - ARREGLOS
            
            // para declarar un vector es:    int[] numeros = new int[10];
            
            int n;
            int[] numeros = new int[10];

            //  0 1 2 3 4 5 6 7 8 9
            // | | | | | | | | | | |

            // manualmente : 
                    // para CARGAR un vector:
                            numeros[6] = 1;
                            numeros[0] = 8;
                            numeros[9] = 525;
                            //  0 1 2 3 4 5 6 7 8  9
                            // |8| | | | | |1| | |525|
                            n = numeros[6] + numeros[0];
                    // para LEER un vector:
                            Console.WriteLine(numeros[6]);

            // automaticamente : 
                    // para CARGAR un vector:
                            for (int x = 0; x < 10; x++){
                                Console.WriteLine("ingrese la nota...");
                                n = int.Parse(Console.ReadLine());
                                numeros[x] = n;
                            }
                    // para LEER un vector:
                            int acu = 0;

                            for (int x = 0; x < 10; x++){
                                acu += numeros[x];
                                Console.WriteLine("El valor es: " + numeros[x]);
                            }
                            int prom = acu / 10;
                            Console.WriteLine("El promedio es: " + prom);


            Console.WriteLine("Fin del ejemplo");
        }
    }
}
