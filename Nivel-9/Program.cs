using System;
using System.Runtime.InteropServices;

namespace Nivel9;

class Program
{
    static void Main(string[] args)
    {
        //Recorre una colección de nombres con foreach y muestra únicamente los que tengan más
        //de cuatro caracteres, combinando foreach + if + String.

        string[] nombres = ["Rodrigo", "Javier","Darwin","Angel", "Ana"];

        foreach(string nombre in nombres)
        {
            if(nombre.Length > 4)
            {
                Console.WriteLine($"Nombres con mas de 4 letras: {nombre}");
            }
        }
        Console.WriteLine("Presiona cualquier tecla...");
        Console.ReadKey();

    }
}