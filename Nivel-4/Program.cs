using System;

class Program
{
    static void Main(string[] args)
    {
        //Solicita un nivel de alerta entre 0 y 10 y clasifícalo: 0 NORMAL, 1-3 ADVERTENCIA,
        // 4-6 PELIGRO, 7-9 CRÍTICO, 10 EMERGENCIA. Fuera de rango: "NIVEL DE ALERTA INVÁLIDO".
        //Usa if / else if / else.        
        var nivel_alerta = 0;
        Console.WriteLine("Escriba el nivel de alerta en una escala de [1-10]:   ");
        while(!int.TryParse(Console.ReadLine(), out nivel_alerta)|| nivel_alerta < 0 || nivel_alerta > 10)
        {
            Console.WriteLine("[ERROR]: NIVEL DE ALERTA INVÁLIDO");
            Console.WriteLine("Escriba de nuevo el nivel de alerta:   ");
        }

        
        if( nivel_alerta == 0)
        {
            Console.WriteLine("NORMAL");
        }
        else if (nivel_alerta <= 3)
        {
            Console.WriteLine("ADVERTENCIA");
        }
        else if(nivel_alerta <= 6)
        {
            Console.WriteLine("PELIGRO");
        }
        else if(nivel_alerta <= 9)
        {
            Console.WriteLine("CRITICO");
        }
        else
        {
            Console.WriteLine("EMERGENCIA");
        }
        
    }
}