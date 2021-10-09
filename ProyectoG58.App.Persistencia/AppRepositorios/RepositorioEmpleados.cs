using System.Collections.Generic;
using System.Linq;
using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Persistencia
{
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
         private readonly AppContext _appContext;

        public RepositorioEmpleados(AppContext appContext)
         {
            _appContext = appContext;
         }

       //Métodos 

        Empleado IRepositorioEmpleados.AddEmpleado(Empleado empleado)
        {
            var empleadoAdicionado = _appContext.Empleado.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAdicionado.Entity;
        }

        IEnumerable<Empleado> IRepositorioEmpleados.GetAllEmpleados()
        {
            return _appContext.Empleado;
        }

        Empleado IRepositorioEmpleados.GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleado.FirstOrDefault(p => p.id == idEmpleado);
        }

        Empleado IRepositorioEmpleados.UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.Empleado.FirstOrDefault(p => p.id == empleado.id);
            if (empleadoEncontrado!= null)
            {
                empleadoEncontrado.nombre = empleado.nombre;
                empleadoEncontrado.identificacion= empleado.identificacion;
                empleadoEncontrado.cargo = empleado.cargo;
                empleadoEncontrado.estado = empleado.estado;

                _appContext.SaveChanges();
            }
            return empleadoEncontrado;
        }

        void IRepositorioEmpleados.DeleteEmpleado(int idEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleado.FirstOrDefault(p => p.id == idEmpleado);
            if (empleadoEncontrado== null)
                return;
            _appContext.Empleado.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }
       
    }
}
