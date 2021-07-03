using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public  class PedidoDet
    {
        public int ID { get; set; }
        public int IDEstampado { get; set; }
        public int IDColor { get; set; }
        public int IDCategoria { get; set; }
        public int IDTalle { get; set; }

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public int IDPedido { get; set; }

    }
}
