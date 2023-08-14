using System;

namespace Ejercicio7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7-3
            
            // Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
            // sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //      CADENA FUENTE: “La mar estaba serena"
            //      CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //      CADENA RESULTADO: “Li mir estibi sereni"

            // Ejercicio con STRING:

            string cadena;
            char L1, L2;
            // int i=0;

            Console.WriteLine("Ingrese una frase");
            cadena = Console.ReadLine();
            Console.WriteLine("Ingrese una letra a cambiar");
            L1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una letra que sustituya");
            L2 = char.Parse(Console.ReadLine());


            // NO HACE FALTA USAR While PORQUE YA VIENE CONFIGURADA CON LA FUNCION Replace
            // while (cadena[i] != '\0'){
            //     if (L1 == cadena[i]){
            //         cadena[i] = L2;
            //     }
            //     i++;
            // }

            cadena = cadena.Replace(L1, L2);

            Console.WriteLine(cadena);


            // Ejercicio con la forma MANUAL:

            // char[] frase = new char[30];
            // char L, L1, L2;
            // int i=0;

            // Console.WriteLine("Ingrese letra a letra y termine con un punto");
            // L = char.Parse(Console.ReadLine());
            // while (L != '.' && i < 30){
            //     frase[i] = L;
            //     L = char.Parse(Console.ReadLine());
            //     i++;
            // }

            // frase[i] = '\0';

            // Console.WriteLine("Ingrese una letra a cambiar");
            // L1 = char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese una letra que sustituya");
            // L2 = char.Parse(Console.ReadLine());
            
            // i = 0;

            // while (frase[i] != '\0' && i < 30){
            //     if (frase[i] == L1){
            //         frase[i] = L2;
            //     }
            //     i++;
            // }

            // i=0;

            // while (frase[i] != '\0'){
            //     Console.Write(frase[i]);
            //     i++;
            // }

            // Console.WriteLine(" ");

            Console.WriteLine("Fin del programa!");
        }
    }
}
