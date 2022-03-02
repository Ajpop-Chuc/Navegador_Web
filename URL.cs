using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegadorWeb
{
    internal class URL
    {
        private string direccion;
        private int vecesVisitada;
        private DateTime ultimaFechaAccedida;

        public string Direccion { get => direccion; set => direccion = value; }
        public int VecesVisitada { get => vecesVisitada; set => vecesVisitada = value; }
        public DateTime UltimaFechaAccedida { get => ultimaFechaAccedida; set => ultimaFechaAccedida = value; }
    }

}
