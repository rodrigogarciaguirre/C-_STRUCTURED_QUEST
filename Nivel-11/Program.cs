using System;

namespace Nivel11;

internal class Program
{
	private static void Main(string[] args)
	{
		//Solicita un nombre completo y muestra el nombre limpio, la cantidad de caracteres, y
        //sus versiones en mayúsculas y minúsculas. Debe manejar espacios innecesarios.
        Console.WriteLine("Escriba su nombre completo:  ");
        string nombre = Console.ReadLine();

        string nombrelimpio = nombre.Trim();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("CARACTERISTICAS DEL NOMBRE");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Nombre limpio           : {nombrelimpio}");
        Console.WriteLine($"Cantidad de caracteres  : {nombrelimpio.Length}");
        Console.WriteLine($"Version en mayusculas   : {nombrelimpio.ToUpper()}");
        Console.WriteLine($"Su version en minusculas: {nombrelimpio.ToLower()}");

        Console.WriteLine("Presione cualquier tecla...");
        Console.ReadKey();
	}
}

