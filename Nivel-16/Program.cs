using System;

Console.Title = "Consola de Control";
Console.Clear();

MostrarEstado("OPERATIVO", "Todos los sistemas funcionan correctamente.", ConsoleColor.Black, ConsoleColor.Green);
MostrarEstado("ADVERTENCIA", "Se detectó una condición que requiere atención.", ConsoleColor.Black, ConsoleColor.Yellow);
MostrarEstado("ERROR", "No se pudo completar la operación.", ConsoleColor.White, ConsoleColor.Red);
MostrarEstado("INFORMACIÓN", "La consola está lista para recibir instrucciones.", ConsoleColor.Cyan, ConsoleColor.DarkBlue);

Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Presiona una tecla para salir...");
Console.ReadKey(true);

static void MostrarEstado(string estado, string mensaje, ConsoleColor colorTexto, ConsoleColor colorFondo)
{
	Console.ForegroundColor = colorTexto;
	Console.BackgroundColor = colorFondo;
	Console.WriteLine($"[{estado}] {mensaje}");
	Console.ResetColor();
}

