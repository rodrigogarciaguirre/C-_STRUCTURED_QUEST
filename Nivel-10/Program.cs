using System;

namespace Nivel10;

internal class Program
{
    private static void Main(string[] args)
    {
        //Procesa una secuencia de códigos: ignora "ERROR" con continue y detén el procesamiento al encontrar "EXIT" con break.
        string[] codigos = ["Codigo1","Codigo2","EXIT","Codigo3","ERROR"];

        foreach(string codigo in codigos)
        {

            if(codigo == "ERROR")
            {
                Console.WriteLine("[SE IGNORA]: El codigo tiene un error.");
                continue;
            }
            if(codigo == "EXIT")
            {
                Console.WriteLine("[EXIT]: El codigo se detiene");
                break;
            }
            Console.WriteLine("El codigo funciona correctamente.");
        }
    }
}
