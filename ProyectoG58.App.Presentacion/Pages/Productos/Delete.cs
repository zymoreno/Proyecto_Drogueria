using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Presentacion.Pages.Productos
{
    public class DeleteModel : PageModel
    {
       private readonly IRepositorioProductos _appContext;

        [BindProperty]
        public Producto producto  { get; set; } 

        public DeleteModel()
        {
            this._appContext  =new RepositorioProductos(new ProyectoG58.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int productoId)
        {
            producto = _appContext.GetProducto(productoId);
            if(producto == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(producto.id > 0)
            {
               _appContext.DeleteProducto(producto.id);
            }
            return Page();
        }
    }
}