using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public int ID { get; set; }
        public int IDUsuario { get; set; }
        public List<Producto> Items { get; set; }
        public decimal SubTotalProductos { get; set; }
        public decimal CostoDeEnvio { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public string FormaPago { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
