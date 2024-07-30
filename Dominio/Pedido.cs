using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        
        public List<Articulo> Articulos { get; set; }
        public decimal Total { get; set; }

    }
}
