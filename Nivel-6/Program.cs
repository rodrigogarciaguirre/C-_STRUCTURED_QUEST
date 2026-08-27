
using System;
using System.Runtime.InteropServices.Marshalling;

namespace Nivel_6
{
	class Program
	{
		static void Main(string[] args)
		{
			//Solicita usuario y contraseña con un máximo de 3 intentos usando while. Muestra los
            //intentos restantes. Si se agotan: "SISTEMA BLOQUEADO".
            var usuario = "Rodrigo";
            var contraseña = "Rodrigo123";
            var intentos = 3;
            var login = false;
            
            var esvalido = false;
            var posible_usuario = "";
            var posible_contrasena = "";
            do
            {
                for(int i=0; i <= 3; i++)
                {
                    Console.Clear();

                    if(intentos == 0)
                    {
                        esvalido = true;
                        break;
                    }
                    Console.WriteLine("Bienvenido a nuestro sistema.");
                    Console.WriteLine("Escribe el nombre de tu usuario:   ");
                    posible_usuario = Console.ReadLine();
                    Console.WriteLine("Escribe la contrasena:   ");
                    posible_contrasena = Console.ReadLine();

                    if(posible_usuario != usuario)
                    {
                        Console.WriteLine("[ERROR]Escribe el usuario correctamente.");
                        intentos--;
                        Console.WriteLine($"Posibles intentos antes de que se bloquee: {intentos}");
                        Console.WriteLine("PRECIONE CUALQUIER TECLA PARA CONTINUAR....");
                        Console.ReadKey();
                    }
                    else if(posible_contrasena != contraseña)
                    {
                        Console.WriteLine("[ERROR]Escribe la contrasena correctamente.");
                        intentos--;
                        Console.WriteLine($"Posibles intentos antes de que se bloquee: {intentos}");
                        Console.WriteLine("PRECIONE CUALQUIER TECLA PARA CONTINUAR....");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Credenciales correctas.");
                        Console.WriteLine("PRECIONE CUALQUIER TECLA PARA CONTINUAR....");
                        Console.ReadKey();
                        login = true;
                        esvalido = true;
                        break;
                    }
                }
            } while(!esvalido);
            
            Console.Clear();
            if (login)
            {
                Console.WriteLine($"Bievenido {usuario}");
            }
            else
            {
                Console.WriteLine("SISTEMA BLOQUEADO");
            }
		}
	}
}
