using System.Collections.Generic;
using System.Linq;
using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Persistencia
{
    public class RepositorioProductos : IRepositorioProductos
    {
         private readonly AppContext _appContext;

        public RepositorioProductos(AppContext appContext)
         {
            _appContext = appContext;
         }

       //Métodos 

        Producto IRepositorioProductos.AddProducto(Producto producto)
        {
            var productoAdicionado = _appContext.Producto.Add(producto);
            _appContext.SaveChanges();
            return productoAdicionado.Entity;
        }

        IEnumerable<Producto> IRepositorioProductos.GetAllProductos()
        {
            return _appContext.Producto;
        }

        Producto IRepositorioProductos.GetProducto(int idProducto)
        {
            return _appContext.Producto.FirstOrDefault(p => p.id == idProducto);
        }

        Producto IRepositorioProductos.UpdateProducto(Producto producto)
        {
            var productoEncontrado = _appContext.Producto.FirstOrDefault(p => p.id == producto.id);
            if (productoEncontrado!= null)
            {
                productoEncontrado.nombre = producto.nombre;
                productoEncontrado.lote= producto.lote;
                productoEncontrado.fechaVencim = producto.fechaVencim;
                productoEncontrado.cantidad = producto.cantidad;
                productoEncontrado.presentacion = producto.presentacion;
                productoEncontrado.estado = producto.estado;

                _appContext.SaveChanges();
            }
            return productoEncontrado;
        }

        void IRepositorioProductos.DeleteProducto(int idProducto)
        {
            var productoEncontrado = _appContext.Producto.FirstOrDefault(p => p.id == idProducto);
            if (productoEncontrado== null)
                return;
            _appContext.Producto.Remove(productoEncontrado);
            _appContext.SaveChanges();
        }
       
    }
}
