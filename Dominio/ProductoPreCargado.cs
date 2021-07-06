using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ProductoPreCargado
    {
        public int ID { get; set; }
        public int IDColor { get; set; }
        public int IDCategoria { get; set; }
        public int IDEstampado { get; set; }
        public DateTime FechaCarga { get; set; }
    }
}
