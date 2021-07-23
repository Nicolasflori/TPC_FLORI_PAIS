using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int ID { get; set; }
        public int IDEstampado { get; set; }
        public string Estampado { get; set; }
        public string ImagenEstampado { get; set; }
        public int IDColor { get; set; } 
        public string Color { get; set; }
        public string ImagenColor { get; set; }
        public int IDCategoria { get; set; }
        public string Categoria { get; set; }
        public int IDTalle { get; set; }
        public string Talle { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioxProducto { get; set; }
        public int IDCarrito { get; set; }
    }
}
