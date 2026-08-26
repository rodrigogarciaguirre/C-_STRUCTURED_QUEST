using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //consumoTotal = trabajadores × horas × consumoPorHora y muestra el reporte usando operadores aritméticos.
        Console.WriteLine("BIENVENIDO AL PROGRAMA DEL CALCULO DE CONSUMOTOTAL");
        Console.WriteLine();

        int trabajadores;
        Console.WriteLine("Escriba el total de trabajadores en plantilla:   ");
        //Utilizo tryparse para verificar que sea entero
        while(!int.TryParse(Console.ReadLine(), out trabajadores)|| trabajadores <= 0)
        {
            Console.WriteLine("[ERROR]:El valor es invalido");
            Console.WriteLine("Escribelo el total de trabajadores en plantilla de nuevo:   ");
        }
        var horas = 0.0;
        Console.WriteLine("Escribi el total de horas de los trabajadores:   ");
        while(!double.TryParse(Console.ReadLine(), out horas) || horas <= 0)
        {
            Console.WriteLine("[ERROR]:El valor que introduce es invalido.");
            Console.WriteLine("Escriba el numero de horas de nuevo:   ");
        }

        var consumoPorHora = 0.0;
        Console.WriteLine("Escriba el valor de consumo por hora: ");
        while(!double.TryParse(Console.ReadLine(), out consumoPorHora)|| consumoPorHora <= 0)
        {
            Console.WriteLine("[ERROR]:El valor que introduce es invalido.");
            Console.WriteLine("Escriba un numero de consumo por hora valido:   ");
        }
        //Calculo y ya muestro todo los valores
        var consumoTotal = trabajadores*consumoPorHora*horas;
        Console.Clear();
        Console.WriteLine("VALORES TOTALES DEL PROGRAMA");
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"NUMERO DE TRABAJADORES: {trabajadores}");
        Console.WriteLine($"NUMERO DE HORAS       : {horas}");
        Console.WriteLine($"CONSUMO POR HORA      : {consumoPorHora}");
        Console.WriteLine();
        Console.WriteLine($"CONSUMO TOTAL         : {consumoTotal}");
    }
}
