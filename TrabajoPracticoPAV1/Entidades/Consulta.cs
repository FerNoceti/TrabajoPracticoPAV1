using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades_ABM__Dueño__Consulta__Vacuna_
{
    class Consulta
    {
        private int Sucursal;
        private string IdConsulta;
        private string HistoriaClinica;
        private int IdTipoDoc;
        private string NumeroDocumento;
        private DateTime FechaEntrada;
        private DateTime FechaSalida;


        public Consulta()
        {

        }
        public int Id_Sucursal
        {
            get => Sucursal;
            set => Sucursal = value;
        }
        public string Id_Consulta
        {
            get => IdConsulta;
            set => IdConsulta = value;
        }
        public string NroHistoriaClinica
        {
            get => HistoriaClinica;
            set => HistoriaClinica = value;
        }
        public int TipoDocumentoEmpleado
        {
            get => IdTipoDoc;
            set => IdTipoDoc = value;
        }
        public string NumeroDeDocumento
        {
            get => NumeroDocumento;
            set => NumeroDocumento = value;
        }
        public DateTime FechaDeEntrada
        {
            get => FechaEntrada;
            set => FechaEntrada = value;
        }
        public DateTime FechaDeSalida
        {
            get => FechaSalida;
            set => FechaSalida = value;
        }
    }
}
