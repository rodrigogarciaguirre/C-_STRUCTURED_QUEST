using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("   BIENVENIDO AL CREADOR DE TABLAS DE MULTIPLICAR");
        Console.WriteLine("==============================================\n");

        var inicio = 0;
        var final = 0;
        var valido = false;

        // Pedir y validar el rango de la tabla
        while (!valido)
        {
            Console.Write("Escribe desde dónde quieres que se inicie la tabla: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Escribe el final del rango de la tabla: ");
            final = int.Parse(Console.ReadLine());

            if (inicio > final)
            {
                Console.WriteLine("\n[ERROR]: El inicio no puede ser mayor al final. Inténtalo de nuevo.\n");
            }
            else
            {
                valido = true;
            }
        }

        Console.WriteLine();

        // Pedir y validar el número a multiplicar
        Console.Write("Escribe el número que deseas multiplicar: ");
        var numero = 0.0;

        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("[ERROR] Escribe un número válido, no caracteres.");
            Console.Write("Escribe nuevamente el número que deseas multiplicar: ");
        }

        // Mostrar el resultado de la tabla
        Console.WriteLine($"\n----------------------------------------------");
        Console.WriteLine($"   Tabla del {numero} (del {inicio} al {final})");
        Console.WriteLine($"----------------------------------------------");

        for (int i = inicio; i <= final; i++)
        {
            var resultado = i * numero;
            Console.WriteLine($"  {numero} * {i} = {resultado}");
        }

        Console.WriteLine("----------------------------------------------");
    }
}