using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Persistencia
{
    public interface IRepositorioProductos
    {
        IEnumerable<Producto> GetAllProductos();
        Producto AddProducto(Producto producto);
        Producto UpdateProducto(Producto producto);
        void DeleteProducto(int idProducto);    
        Producto GetProducto(int idProducto);
    }
     
}
