using System;

namespace EjemploSTRING
{
    class Program
    {
        static void Main(string[] args)
        {
            // CADENAS DE CARACTERES - VECTORES tipo CHAR - STRING

            // hay que diferenciar STRING - CADENA CARACTER - Vector CHAR , la diferencia es conceptual aunque manejen lo mismo.
            // - STRING - es un tipo de dato como int, float, char,..., que maneja una cadena de caracteres o varios chars.
            // - CADENA CARACTER - es igual que un Vector CHAR pero la diferencia es que se guarda algo con sentido,
            //   por ejemplo (palabras, frases, nombres,...) y que tiene un caracter especial = "\0" que significa el fin de la cadena.

            // char[] frase = new char[10];
            //  0 1 2 3 4  5 6 7 8 9
            // |H|O|L|A|/0| | | | | |


            // - Vector CHAR - es igual que una CADENA CARACTER para guardar datos pero que no tiene ningun tipo de relación
            //   entre ellos, pero SI para trabajar en el futuro, como ejemplo: la asistencia o falta en el trabajo,

            // char[] cadena = new char[10];
            //  0 1 2 3 4  5 6 7 8 9
            // |A|F|F|F|A|A|A|F| | |

            // Ejemplo MANUALMENTE de cargar y leer un CADENA CARACTER y un Vector CHAR:  programa ESCRIBIR TU NOMBRE

            // char[] nombre = new char[11];
            // char letra;
            // int indice;
            
            // Console.WriteLine("Introduce letra por letra tu nombre y termina con un punto");
            // letra = char.Parse(Console.ReadLine());
            // indice = 0;
            // while (letra != '.' && indice < 10){
            //     nombre[indice] = letra;
            //     letra = char.Parse(Console.ReadLine());
            //     indice++;
            // }

            // nombre[indice] = '\0';

            // Console.Write("HOLA ");
            // indice = 0;
            // while (nombre[indice] != '\0'){
            //     Console.Write(nombre[indice]);
            //     indice++;
            // }
        
            // Console.WriteLine(" ");
            // Console.WriteLine("Fin del programa!!!!!!!!!!!");

            // Ejemplo AUTOMATICO o STRING - es simplificar todo lo anterior sobre un lenguaje de alto nivel, STRING, engloba
            // a una CADENA DE CARACTERES, que a su vez engloba a un Vector de CHAR.

            string nombre;
            Console.WriteLine("Escribe tu nombre.....");
            nombre = Console.ReadLine();
            Console.WriteLine("HOLA " + nombre);

            Console.WriteLine("Fin del programa!!!!!!!");
        }
    }
}
