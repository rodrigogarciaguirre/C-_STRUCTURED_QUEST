using System;

namespace Nivel_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicita dos números y calcula potencia, raíz cuadrada, valor absoluto, redondeo, 
            //mayor y menor usando la clase Math.
            var num1 = 0.0;
            var num2 = 0.0;
            Console.WriteLine("Ingrese el primer número:");
            while(!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido:");
            }
            Console.WriteLine("Ingrese el segundo número:");
            while(!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido:");
            }
            Console.WriteLine($"Potencia: {Math.Pow(num1, num2)}");
            Console.WriteLine($"Raíz cuadrada del primer número: {Math.Sqrt(num1)}");
            Console.WriteLine($"Valor absoluto del primer número: {Math.Abs(num1)}");
            Console.WriteLine($"Valor absoluto del segundo número: {Math.Abs(num2)}");
            Console.WriteLine($"Redondeo del primer número: {Math.Round(num1)}");
            Console.WriteLine($"Redondeo del segundo número: {Math.Round(num2)}"); 
            Console.WriteLine($"Mayor: {Math.Max(num1, num2)}");
            Console.WriteLine($"Menor: {Math.Min(num1, num2)}");
        }
    }
}