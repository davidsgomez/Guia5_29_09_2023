using System;

class Program
{
    static void Main(string[] args)
    {
        double prestamo = 3000;
        int plazoMeses = 6;
        DateTime fechaInicio = DateTime.Today;

        double cuotaMensual = prestamo / plazoMeses;

        Console.WriteLine("Detalle del préstamo: ");
        Console.WriteLine($" - Monto del préstamo: ${prestamo}");
        Console.WriteLine($" - Plazo del préstamo: {plazoMeses} meses");
        Console.WriteLine($" - Cuota mensual: ${cuotaMensual}");

        Console.WriteLine("\nFuturas fechas de pago:");
        for (int i = 0; i < plazoMeses; i++)
        {
            DateTime fechaPago = fechaInicio.AddMonths(i);
            string fechaFormateada = fechaPago.ToString("dd/MM/yyyy");
            Console.WriteLine($" Cuota {i + 1}: {fechaFormateada} - ${cuotaMensual}");
        }
    }
}
