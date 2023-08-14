using System;

namespace Ejercicio7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7-2
            // Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio

            int[] numeros = new int[10];
            float acu= 0, prom = 0;

            for (int x = 0; x < 10; x++){
                Console.WriteLine("Introduce un numero");
                numeros[x] = int.Parse(Console.ReadLine());
            }
            for (int x = 0; x < 10; x++){
                acu+= numeros[x];
            }
            prom = acu / 10;
            Console.Write("Los numeros mayores al promedio " + prom.ToString("0.00") + " son: ");
            for (int x = 0; x < 10; x++){
                if (numeros[x] > prom){
                    Console.Write(numeros[x] + ", ");
                }
            }   
            Console.WriteLine("Fin del programa!");
        }
    }
}
