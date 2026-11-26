using System.Text.Json;
using InventarioCrud.Models;

namespace InventarioCrud.Services;

public class AlmacenamientoJson
{
    private readonly string _rutaArchivo = "productos.json";

    public List<Producto> Cargar()
    {
        if (!File.Exists(_rutaArchivo))
            return new List<Producto>();

        string json = File.ReadAllText(_rutaArchivo);
        return JsonSerializer.Deserialize<List<Producto>>(json) ?? new List<Producto>();
    }

    public void Guardar(List<Producto> productos)
    {
        var opciones = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(productos, opciones);
        File.WriteAllText(_rutaArchivo, json);
    }
}
