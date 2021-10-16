using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoG58.App.Dominio;

namespace ProyectoG58.App.Presentacion
{
    public class ListProvModel : PageModel
    {
        public IEnumerable<Proveedor> proveedores {get;set;}
       
        public ListProvModel(){
            proveedores = new List<Proveedor>()
            {
                new Proveedor{id=1, nombre="alvaro martinez", nit=123456, direccion="Cll 3 N 2-4", telefono="3212422125", email="almarti@gmail.com", estado="A"}

            };
        }
        public void OnGet()
        {
        }
    }
    }