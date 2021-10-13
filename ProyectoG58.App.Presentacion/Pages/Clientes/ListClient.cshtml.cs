using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Presentacion
{
    public class ListClientModel : PageModel
    {
        public IEnumerable<Cliente> clientes {get;set;}
       
        public ListClientModel(){
            clientes = new List<Cliente>()
            {
                new Cliente{id=1, nombre="Pepito Perez", identificacion=12345654, direccion="Cll 5 N 2-4", telefono="3212522125", email="dsfsdf@gmail.com", estado="A"},
                
                new Cliente{id=2, nombre="Carlos Gomez", identificacion=78912321, direccion="Cra 11 N 5-12", telefono="3132222222", email="carlosg@gmail.com", estado="A"},

                new Cliente{id=3, nombre="Camila Reyes", identificacion=52856213, direccion="Diag. 15 N 23-12", telefono="3132290414", email="camila25@hotmail.com", estado="A"},

                new Cliente{id=4, nombre="Blanca Moreno", identificacion=202856563, direccion="Av. 13 N 85-25", telefono="3115625897", email="blancurita@yahoo.es", estado="A"},

                new Cliente{id=5, nombre="Jaime Garcia", identificacion=7792555, direccion="Cra 8 N 32-18", telefono="3158956321", email="jagar2597@gmail.com", estado="A"}

            };
        }
        public void OnGet()
        {
        }
    }
}
