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
            Console.WriteLine();
            Console.WriteLine("--- Registrar Producto ---");
            string nombre = Validador.LeerTextoNoVacio("Nombre: ");
            string categoria = Validador.LeerTextoNoVacio("Categoría: ");
            decimal precio = Validador.LeerDecimalPositivo("Precio: ");
            int stock = Validador.LeerEnteroNoNegativo("Stock inicial: ");

            servicio.Crear(new Producto
            {
                Nombre = nombre,
                Categoria = categoria,
                Precio = precio,
                Stock = stock
            });
            Console.WriteLine("Producto registrado correctamente.");
            break;

        case "2":
            Console.WriteLine();
            Console.WriteLine("--- Lista de Productos ---");
            var lista = servicio.ObtenerTodos();
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                Console.WriteLine($"{"ID",-5} {"Nombre",-20} {"Categoría",-15} {"Precio",-12} {"Stock",-6}");
                Console.WriteLine(new string('-', 62));
                foreach (var p in lista)
                {
                    Console.WriteLine($"{p.Id,-5} {p.Nombre,-20} {p.Categoria,-15} {p.Precio,-12:C2} {p.Stock,-6}");
                }
            }
            break;
          
        case "3":
            
        case "4":
  
        case "5":
            salir = true;
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
