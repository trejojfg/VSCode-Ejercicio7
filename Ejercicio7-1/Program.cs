using System;

namespace Ejercicio7_1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // 7-1
            // Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
        
            int[] numeros = new int[10];
            int[] posicion = new int[10];
            int n, maxpos, max;

            for (int x = 0; x < 10; x++){
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
                posicion[x] = x+1;
            }

            max = numeros[0];
            maxpos = posicion[0];

            for (int x = 0; x < 10; x++){
                if (numeros[x] > max){
                    max = numeros[x];
                    maxpos = posicion[x];

                }
            }

            Console.WriteLine("El maximo es el " + max + " y esta en la posición " + maxpos);
            Console.WriteLine("Fin del programa!!!!!!!!!!!!!!!");
        }
    }
}
