using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoG58.App.Dominio;
<<<<<<< HEAD
using ProyectoG58.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2

namespace ProyectoG58.App.Presentacion
{
    public class ListProdModel : PageModel
    {
<<<<<<< HEAD
        private readonly IRepositorioProductos repositorioProductos;

        public IEnumerable<Producto> productos {get;set;}

        public string searchString; 
       
        public ListProdModel(){

            this.repositorioProductos=new RepositorioProductos(new ProyectoG58.App.Persistencia.AppContext());
        }
        public void OnGet()
=======
        public IEnumerable<Producto> productos {get;set;}
       
        public ListProdModel(){
            productos = new List<Producto>()
            {
                new Producto{id=1, nombre="Acetaminofen 500 mg", lote="J7285", fechaVencim="05/2025", cantidad=10, presentacion="Caja x 50 tab", estado="A"},
                new Producto{id=1, nombre="Iboprufeno 800 mg", lote="1525", fechaVencim="08/2024", cantidad=20, presentacion="Caja x 20 tab", estado="A"},
                new Producto{id=1, nombre="Amoxicilina 500 mg", lote="05360920", fechaVencim="09/2022", cantidad=30, presentacion="Blister x 10 cap", estado="A"},
                new Producto{id=1, nombre="Betametasona 0.1%", lote="21B76", fechaVencim="03/2024", cantidad=5, presentacion="Tubo x 20 g", estado="A"},
                new Producto{id=1, nombre="Lidomax 4%", lote="EU2002", fechaVencim="10/2023", cantidad=1, presentacion="Tubo x 15 g", estado="A"},
                new Producto{id=1, nombre="Gabiscon solucion oral", lote="815891", fechaVencim="06/2024", cantidad=18, presentacion="Sobre x 10 ml", estado="A"}
                
                };
        }
                public void OnGet()
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
        {
            productos =repositorioProductos.GetAllProductos(searchString); 
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            productos = repositorioProductos.GetAllProductos(searchString);
            return Page();
        }
        
    }
}
