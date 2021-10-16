using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Presentacion
{
    public class NewBuyModel : PageModel
    {
        public IEnumerable<OrdenCompra> OrdenCompra {get;set;}
       
        public NewBuyModel(){
            OrdenCompra = new List<OrdenCompra>()
            {
                new OrdenCompra{id=1, fecha="12/05/2021", bodegaId=1 , proveedorId=1 , estado="A"}

            };
        }
        public void OnGet()
        {
        }
    }
}
