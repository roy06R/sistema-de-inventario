namespace InventarioCrud.Utils;

public static class Validador
{
    public static string LeerTextoNoVacio(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string? entrada = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(entrada))
                return entrada;

            Console.WriteLine("Error: Este campo no puede estar vacío.");
        }
    }

    public static decimal LeerDecimalPositivo(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor > 0)
                return valor;

            Console.WriteLine("Error: Ingrese un monto numérico mayor a 0.");
        }
    }

    public static int LeerEnteroNoNegativo(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out int valor) && valor >= 0)
                return valor;

            Console.WriteLine("Error: Ingrese un número entero válido (0 o mayor).");
        }
    }
}
