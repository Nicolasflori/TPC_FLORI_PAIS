﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Username{ get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IDDireccion { get; set; }
        public int IDPermiso { get; set; }

        public bool Baja { get; set; }

    }
}
