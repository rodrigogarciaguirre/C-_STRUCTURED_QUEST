using System;

class Program
{
	static void Main(string[] args)
	{
		//Muestra la fecha y hora actual, el día, el mes y el año usando DateTime. Reto
        //adicional: calcular la edad a partir de la fecha de nacimiento.
        DateTime  ahora = DateTime.Now;
        int dia = ahora.Day;
        int mes = ahora.Month;
        int ano = ahora.Year;

        int hora = ahora.Hour;
        int minutos = ahora.Minute;
        int segundos = ahora.Second;

        Console.WriteLine($"Ano-{ano}-mes-{mes}-dia-{dia}");
        Console.WriteLine($"Hora-{hora}.minutos-{minutos}.segundos-{segundos}");

        Console.WriteLine("Escriba su ano de naciemiento:  ");
        var esvaldio = Console.ReadLine();

        while(!int.TryParse(esvaldio, out _)|| int.Parse(esvaldio) < 1900 || int.Parse(esvaldio) > ahora.Year)
        {
            Console.WriteLine("[ERROR] Escriba de nuevo la edad:  ");
            esvaldio = Console.ReadLine();
        }
        var nacimiento = int.Parse(esvaldio);

        var edad = DateTime.Now.Year - nacimiento;
        Console.WriteLine($"Tu edad es:  {edad}");

	}
}

