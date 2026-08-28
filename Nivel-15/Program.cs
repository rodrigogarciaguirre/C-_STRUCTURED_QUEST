using System;

class Program
{
    static void Main(string[] args)
    {
        //Genera un código de seguridad de seis dígitos con Random. Reto adicional: permitir generar varios códigos según lo indique el usuario.
        Random random = new Random();
        Console.Write("¿Cuántos códigos deseas generar? ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.WriteLine("Códigos de seguridad generados:");
        for (int i = 0; i < cantidad; i++)
        {
            int codigo = random.Next(100000, 1000000);
            Console.WriteLine(codigo);
        }

    }
}
