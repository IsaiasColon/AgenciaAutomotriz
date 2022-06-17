using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz.Modelos
{
    public class Movimiento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int Automovil { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
