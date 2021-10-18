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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioClientes _appContext;
        public Cliente cliente { get; set; }

        public DetailsModel()
        {
            this._appContext=new RepositorioClientes(new ProyectoG58.App.Persistencia.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int clienteId)
        {
            cliente = _appContext.GetCliente(clienteId);
            if(cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}