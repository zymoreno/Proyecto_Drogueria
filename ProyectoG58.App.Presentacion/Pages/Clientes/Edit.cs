using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoG58.App.Dominio;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Presentacion.Pages.Clientes
{
    public class EditModel : PageModel
    {
       private readonly IRepositorioClientes _appContext;

        [BindProperty]
        public Cliente cliente  { get; set; } 

        public EditModel()
        {
            this._appContext  =new RepositorioClientes(new ProyectoG58.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? clienteId)
        {
            if (clienteId.HasValue)
            {
                cliente = _appContext.GetCliente(clienteId.Value);
            }
            else
            {
                cliente = new Cliente();
            }

            if (cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        //se ejecuta al presionar Editar en el formulario
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(cliente.id > 0)
            {
               cliente = _appContext.UpdateCliente( cliente );               
            }
            else
            {
               _appContext.AddCliente( cliente );
            }
            return Page();
        }
    }
}


