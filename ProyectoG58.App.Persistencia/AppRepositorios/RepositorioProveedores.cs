using System.Collections.Generic;
using System.Linq;
using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Persistencia
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
         private readonly AppContext _appContext;

        public RepositorioProveedores(AppContext appContext)
         {
            _appContext = appContext;
         }

       //Métodos 

        Proveedor IRepositorioProveedores.AddProveedor(Proveedor proveedor)
        {
            var proveedorAdicionado = _appContext.Proveedor.Add(proveedor);
            _appContext.SaveChanges();
            return proveedorAdicionado.Entity;
        }

        IEnumerable<Proveedor> IRepositorioProveedores.GetAllProveedores()
        {
            return _appContext.Proveedor;
        }

        Proveedor IRepositorioProveedores.GetProveedor(int idProveedor)
        {
            return _appContext.Proveedor.FirstOrDefault(p => p.id == idProveedor);
        }

        Proveedor IRepositorioProveedores.UpdateProveedor(Proveedor proveedor)
        {
            var proveedorEncontrado = _appContext.Proveedor.FirstOrDefault(p => p.id == proveedor.id);
            if (proveedorEncontrado!= null)
            {
                proveedorEncontrado.nombre = proveedor.nombre;
                proveedorEncontrado.nit = proveedor.nit;
                proveedorEncontrado.direccion = proveedor.direccion;
                proveedorEncontrado.telefono = proveedor.telefono;
                proveedorEncontrado.email = proveedor.email;
                proveedorEncontrado.estado = proveedor.estado;

                _appContext.SaveChanges();
            }
            return proveedorEncontrado;
        }

        void IRepositorioProveedores.DeleteProveedor(int idProveedor)
        {
            var proveedorEncontrado = _appContext.Proveedor.FirstOrDefault(p => p.id == idProveedor);
            if (proveedorEncontrado== null)
                return;
            _appContext.Proveedor.Remove(proveedorEncontrado);
            _appContext.SaveChanges();
        }
       
    }
}
