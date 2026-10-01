using Microsoft.AspNetCore.Mvc;
using NuevaVida.Models;

namespace NuevaVida.Controllers;

public class ProductosController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(_productos);
    }

    [HttpGet]
    public IActionResult CrearProducto()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CrearProducto([Bind("Nombre,Tipo,Cantidad,PrecioUnitario")] Producto producto)
    {
        if (!ModelState.IsValid)
        {
            return View(producto);
        }
        return View("Resultado", producto);
    }

    private static List<Producto> _productos = new()
    {
        new Producto { Id = 1, Nombre = "Manzanilla", Tipo = "Natural", Cantidad = 50, PrecioUnitario = 1500 },
        new Producto { Id = 2, Nombre = "Acetaminofén", Tipo = "Químico", Cantidad = 15, PrecioUnitario = 2500 },
        new Producto { Id = 3, Nombre = "Suero Oral", Tipo = "Líquido", Cantidad = 30, PrecioUnitario = 8000 }
    };
}
