using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    class MedicamentoPorConsulta
    {
        public int IdConsulta { get; set; }
        public int IdMedicamento { get; set; }
        public int Dosis { get; set; }
        public int Periodicidad { get; set; }
        public float Precio { get; set; }
    }
}
