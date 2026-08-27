using System;

namespace Nivel12
{
	class Program
	{
		static void Main(string[] args)
		{
			//Solicita edad, salario y año de nacimiento usando Parse y TryParse según
            //corresponda, sin que el programa termine con valores inválidos como "abc".
            var edad = 0;
            Console.WriteLine("Escriba su edad:   ");
            while(!int.TryParse(Console.ReadLine(),out edad) || edad < 0)
            {
                Console.WriteLine("[ERROR]Escribe bien la edad:  ");
            }
            
            //Solicita el salario, asegurándose de que sea un número válido y no negativo.
            Console.WriteLine("Escriba su salario:   ");
            var salario = 0.0;
            while(!double.TryParse(Console.ReadLine(),out salario) || salario < 0)
            {
                Console.WriteLine("[ERROR]Escribe bien el salario:  ");
            }

            //Solicita el año de nacimiento, asegurándose de que sea un número válido y no negativo.
            Console.WriteLine("Escriba su año de nacimiento:   ");
            var esValido = Console.ReadLine();

            while(!int.TryParse(esValido, out _) || int.Parse(esValido) < 1900 || int.Parse(esValido) > DateTime.Now.Year)
            {
                Console.WriteLine("[ERROR]Escribe bien el año de nacimiento:  ");
                esValido = Console.ReadLine();
            }
            var anioNacimiento = int.Parse(esValido);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine($"Edad: {edad}, Salario: {salario}, Año de nacimiento: {anioNacimiento}");
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
		}
	}
}

