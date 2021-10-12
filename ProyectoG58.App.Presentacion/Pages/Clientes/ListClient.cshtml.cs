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
                new Cliente{id=1, nombre="Pepito Perez", identificacion=123456, direccion="Cll 5 N 2-4", telefono="3212522125", email="dsfsdf@gmail.com", estado="A"},
                
                new Cliente{id=2, nombre="Carlos Gomez", identificacion=789123, direccion="Cra 11 N 5-12", telefono="3132222222", email="carlosg@gmail.com", estado="A"}

            };
        }
        public void OnGet()
        {
        }
    }
}
