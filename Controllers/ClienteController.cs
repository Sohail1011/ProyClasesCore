using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// acceder al modelo
using ProyClasesCore.Models;

namespace ProyClasesCore.Controllers
{
    public class ClienteController : Controller
    {
        // creamos una lista de clientes de ejemplo:
        List<Cliente> lista = new List<Cliente>();

        void PoblarClientes()
        {
            Cliente obj1 = new Cliente();
            obj1.IdCliente = 1234;
            obj1.Nombre = "Juan Perez";
            obj1.FechaReg = DateTime.Parse("05/10/2000");

            Cliente obj2 = new Cliente()
            {
                IdCliente = 5678, Nombre="Rosa Sanchez",
                FechaReg = new DateTime(2001, 8, 28)
            };

            lista.Add(obj1);
            lista.Add(obj2);
            //
            lista.Add(new Cliente()
            {
                IdCliente = 8751,
                Nombre = "Fernando Torres",
                FechaReg = DateTime.Today
            });
        }
        public IActionResult ClienteIndex()
        {
            PoblarClientes();

            //return View("ClienteIndex",lista);
            return View(lista);
        }
    }
}
