using System.Collections.Generic;
using System.Linq;
using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Persistencia
{
    public class RepositorioBodega : IRepositorioBodega
    {
         private readonly AppContext _appContext;

        public RepositorioBodega(AppContext appContext)
         {
            _appContext = appContext;
         }

       //Métodos 

        Bodega IRepositorioBodega.AddBodega(Bodega bodega)
        {
            var BodegaAdicionada = _appContext.Bodega.Add(bodega);
            _appContext.SaveChanges();
            return BodegaAdicionada.Entity;
        }

        IEnumerable<Bodega> IRepositorioBodega.GetAllBodegas()
        {
            return _appContext.Bodega;
        }

        Bodega IRepositorioBodega.GetBodega(int idBodega)
        {
            return _appContext.Bodega.FirstOrDefault(p => p.id == idBodega);
        }

        Bodega IRepositorioBodega.UpdateBodega(Bodega bodega)
        {
            var BodegaEncontrada = _appContext.Bodega.FirstOrDefault(p => p.id == bodega.id);
            if (BodegaEncontrada != null)
            {
                BodegaEncontrada.nombre = bodega.nombre;
                BodegaEncontrada.direccion = bodega.direccion;
                BodegaEncontrada.telefono = bodega.telefono;
                
                _appContext.SaveChanges();
            }
            return BodegaEncontrada;
        }

        void IRepositorioBodega.DeleteBodega(int idBodega)
        {
            var BodegaEncontrada = _appContext.Bodega.FirstOrDefault(p => p.id == idBodega);
            if (BodegaEncontrada== null)
                return;
            _appContext.Bodega.Remove(BodegaEncontrada);
            _appContext.SaveChanges();
        }
       
    }
}
