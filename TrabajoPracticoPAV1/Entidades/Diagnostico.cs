using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{

    public class Diagnostico
    {
        private int id;
        private float precio;
        private string descripcion;

        public int IdDiagnostico
        {
            get => id;
            set => id = value;
        }


        public float PrecioDiagnostico
        {
            get => precio;
            set => precio = value;
        }

        public string DescripcionDiagnostico
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
