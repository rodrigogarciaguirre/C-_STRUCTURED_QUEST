using System;

class Program
{
    static void Main(string[] args)
    {
        //Solicita edad, nivel de seguridad y estado de credencial. Autoriza el acceso solo si
        //edad ≥ 18 Y nivel ≥ 3 Y credencial activa, usando operadores lógicos.
        var edad = 0;
        Console.WriteLine("Por favor escriba su edad:   ");
        while(!int.TryParse(Console.ReadLine(), out edad)|| edad < 0)
        {
            Console.WriteLine("[ERROR]: Ese es un valor invalido.");
            Console.WriteLine("Escriba nuevamente su edad:   ");
        }

        var nivel_seguridad = 0;
        Console.WriteLine("Escriba el nivel de seguridad en una escalad del [1-3]:   ");
        while(!int.TryParse(Console.ReadLine(), out nivel_seguridad)|| nivel_seguridad < 1 || nivel_seguridad > 3)
        {
            Console.WriteLine("[ERROR]: Escriba un valor valido.");
            Console.WriteLine("Escriba nuevamente el nivel de seguridad en escala del [1-3]:    ");
        }

        var credencial = false;
        Console.WriteLine("Escriba si su credencial sigue activa[S/N]:    ");
        var esvalido = Console.ReadLine();
        esvalido = esvalido.ToLower();
        while(true)
        {
            if(esvalido == "s" || esvalido == "si")
            {
                credencial = true;
                break;
            }
            else if(esvalido == "n" || esvalido == "no")
            {
                break;
            }
            else 
            {
                Console.WriteLine("[ERROR]: El valor no es valido.");
                Console.WriteLine("Escriba otra vez si su credencial sigue activa[S/N]:    ");
                esvalido = Console.ReadLine();
            }
        }
            
        //Juicio final afasfsdfsdfsadf
        if(edad >= 18 && credencial && nivel_seguridad >= 3)
        {
            Console.WriteLine("ACCESO AUTORIZADO");
        }
        else
        {
            Console.WriteLine("acceso denegado...");
        }
    }
}