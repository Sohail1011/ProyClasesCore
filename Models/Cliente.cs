using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyClasesCore.Models
{
    public class Cliente
    {
        // propiedades
        // escribimos la palabra prop y
        // presionamos 2 veces la tecla TAB
        // IdCliente   entero
        // Nombre      cadena
        // FechaReg    fechatiempo

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaReg { get; set; }

    }
}
