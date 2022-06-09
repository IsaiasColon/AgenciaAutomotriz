﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz.Modelos
{
    public class Login
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
    }
}
