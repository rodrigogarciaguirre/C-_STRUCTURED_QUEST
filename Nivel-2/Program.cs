using System;


class Program
{
    static void Main(string[] args)
    {
        /*Solicita la edad del operador. Si es mayor o igual a 18, 
        muestra "Acceso permitido"; si es menor, "Acceso restringido". Usa operadores relacionales e if.*/
        var edad = 0;
        Console.WriteLine("Escriba su edad:  ");
        while(!int.TryParse(Console.ReadLine(), out edad)|| edad <= 0)
        {
            Console.WriteLine("[ERROR]:Escriba su edad con un valor de numero entero.");
            Console.WriteLine("Escriba su edad de nuevo.");
        }
        //Condicional
        if(edad <=17 && edad > 0)
        {
            Console.WriteLine("Acceso permitido.");
        }
        else if(edad >= 18 && edad < 120)
        {
            Console.WriteLine("Acceso restringido.");
        }
        else
        {
            Console.WriteLine("Nadie vie tanto pajero");
        }
    }
}
