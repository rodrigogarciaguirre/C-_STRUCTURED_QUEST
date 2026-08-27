using System;

namespace Nivel7;

internal class Program
{
	private static void Main(string[] args)
	{
		//Crea un menú de 5 opciones que se repita con do-while hasta que el usuario elija
        //"Salir". El menú debe ejecutarse al menos una vez.
        var opcion = 0;
        do
        {
            Console.WriteLine("Bienvenido al menu de algo xd");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1.Ser feliz");
            Console.WriteLine("2.Tener 2 Millones en el banco");
            Console.WriteLine("3.Tener una ps2 Chipeada");
            Console.WriteLine("4.Que ella te quiera.");
            Console.WriteLine("5.Salir de este maravilloso programa.");
            Console.WriteLine();
            Console.WriteLine("Elige una opcion:    ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ve a un psicologo, porfavor.");
                    break;
                case 2:
                    Console.WriteLine("Esto no es el gta, lo siento.");
                    break;
                case 3:
                    Console.WriteLine("Ummm, mejor una wii U");
                    break;
                case 4:
                    Console.WriteLine("jajajaajajajajajajajaajajajaj, si claro");
                    break;
                case 5:
                    Console.WriteLine("Vapue");
                    
                    break;
                default:
                    Console.WriteLine("Elige una opcion de las 5 pax");
                    break;
            }
            Console.WriteLine("Presiona una tecla...");
            Console.ReadKey();
        } while(opcion != 5);

	}
}
