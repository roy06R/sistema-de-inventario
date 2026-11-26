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
}
