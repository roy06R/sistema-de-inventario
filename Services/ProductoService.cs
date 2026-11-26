using InventarioCrud.Models;

namespace InventarioCrud.Services;

public class ProductoService
{
    private readonly AlmacenamientoJson _almacenamiento = new();
    private List<Producto> _productos;

    public ProductoService()
    {
        _productos = _almacenamiento.Cargar();
    }

    public void Crear(Producto nuevo)
    {
        nuevo.Id = _productos.Count > 0 ? _productos.Max(p => p.Id) + 1 : 1;
        _productos.Add(nuevo);
        _almacenamiento.Guardar(_productos);
    }

    public List<Producto> ObtenerTodos() => _productos;

    public Producto? ObtenerPorId(int id) => _productos.FirstOrDefault(p => p.Id == id);

    public bool Actualizar(int id, string nombre, string categoria, decimal precio, int stock)
    {
        var existente = ObtenerPorId(id);
        if (existente == null) return false;

        existente.Nombre = nombre;
        existente.Categoria = categoria;
        existente.Precio = precio;
        existente.Stock = stock;

        _almacenamiento.Guardar(_productos);
        return true;
    }

    public bool Eliminar(int id)
    {
        var producto = ObtenerPorId(id);
        if (producto == null) return false;

        _productos.Remove(producto);
        _almacenamiento.Guardar(_productos);
        return true;
    }
}
