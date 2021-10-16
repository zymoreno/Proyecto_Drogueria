using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Presentacion
{
    public class ListBuyModel : PageModel
    {
        public IEnumerable<OrdenCompra> OrdenCompra {get;set;}
       
        public ListBuyModel(){
            OrdenCompra = new List<OrdenCompra>()
            {
                new OrdenCompra{id=1, fecha="10/07/2021", bodegaId=6, proveedorId=1, estado="A"}

            };
        }
        public void OnGet()
        {
        }
    }
}
