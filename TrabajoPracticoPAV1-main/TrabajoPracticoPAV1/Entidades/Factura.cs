using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Factura
    {
        private int nroFactura;
        private DateTime fechaFactura;
        private int idConsulta;
        private int idTipoFactura;

        public int NumeroFactura
        {
            get => nroFactura;
            set => nroFactura = value;
        }

        public int IdConsulta
        {
            get => idConsulta;
            set => idConsulta = value;
        }

        public int IdTipoFactura
        {
            get => idTipoFactura;
            set => idTipoFactura = value;
        }

        public DateTime FechaFactura
        {
            get => fechaFactura;
            set => fechaFactura = value;
        }
    }
}
