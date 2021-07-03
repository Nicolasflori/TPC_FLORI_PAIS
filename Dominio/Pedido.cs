using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int ID { get; set; }

        public int IDUsuario { get; set; }

        public decimal Total { get; set; }

        public DateTime Fecha { get; set; }

        public string Estado { get; set; }

        public DateTime FechaEntrega { get; set; }

        public string FormaPago { get; set; }
    }
}
