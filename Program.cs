using InventarioCrud.Models;
using InventarioCrud.Services;
using InventarioCrud.Utils;

var servicio = new ProductoService();
bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE INVENTARIO ===");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Listar productos");
    Console.WriteLine("3. Actualizar producto");
    Console.WriteLine("4. Eliminar producto");
    Console.WriteLine("5. Salir");
    Console.WriteLine();
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":

        case "2":
          
        case "3":
            
        case "4":
  
        case "5":
 
    }
}
