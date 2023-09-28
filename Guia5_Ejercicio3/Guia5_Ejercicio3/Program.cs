using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime fechaCumpleaños;

        Console.Write("Ingrese su fecha de cumpleaños (dd/mm/yyyy): ");

        if (DateTime.TryParse(Console.ReadLine(), out fechaCumpleaños))
        {
            DateTime fechaActual = DateTime.Today;

            int diasRestantes = (fechaCumpleaños.DayOfYear >= fechaActual.DayOfYear)
                ? (fechaCumpleaños.DayOfYear - fechaActual.DayOfYear)
                : (365 - (fechaActual.DayOfYear - fechaCumpleaños.DayOfYear));

            Console.WriteLine($"Días restantes para su próximo cumpleaños: {diasRestantes} días");
        }
        else
        {
            Console.WriteLine("La fecha de cumpleaños ingresada es inválida.");
        }
    }
}
