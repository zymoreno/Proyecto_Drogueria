using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Presentacion
{
    public class ListUserModel : PageModel
    {
        public IEnumerable<Empleado> Empleados {get;set;}
       
        public ListUserModel(){
            Empleados = new List<Empleado>()
            {
                new Empleado{id=1, nombre="diego sanchez", identificacion=123456, cargo="cajero",  estado="A"}

            };
        }
        public void OnGet()
        {

                 
                         
        }
    }
<<<<<<< HEAD
}
=======
}

>>>>>>> a76a560baca89fdb12ad375d19d94fab53c92fb3
