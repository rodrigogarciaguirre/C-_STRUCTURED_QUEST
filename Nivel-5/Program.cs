using System;

class Program
{
    static void Main(string[] args)
    {
        //Crea un menú con 5 opciones (Consultar estado, Mostrar temperatura, Mostrar
        //operadores, Reiniciar sistema, Salir) usando switch. Opción inexistente: "OPCIÓN NO
        //VÁLIDA".
        var opcion = 0;
        do{
            Console.WriteLine("------------------------------");
            Console.WriteLine("BIENVENIDO AL MENU");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1.Consultar estado.");
            Console.WriteLine("2.Mostrar temperatura.");
            Console.WriteLine("3.Mostrar operadores.");
            Console.WriteLine("4.Reiniciar sistema.");
            Console.WriteLine("5.Salir");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Eliga una opcion:     ");
            while(!int.TryParse(Console.ReadLine(), out opcion)|| opcion <= 0 || opcion > 5)
            {
                Console.WriteLine("Opción inexistente: OPCIÓN NO VÁLIDA");
                Console.WriteLine("Elige una opcion de nueve:    ");
            }
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El estado es bueno xddd");
                    break;
                case 2:
                    Console.WriteLine("Esta perra la calor.");
                    break;
                case 3:
                    Console.WriteLine("Bueno los operadores sons *  - + / % y ya.");
                    break;
                case 4:
                    Console.WriteLine("Bueno ahoria lo reinicio el sistema.");
                    break;
                case 5:
                    Console.WriteLine("Salu pue");
                    break;
            } 
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }while(opcion != 5);

    }
}
