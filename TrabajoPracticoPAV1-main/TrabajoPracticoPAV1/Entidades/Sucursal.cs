using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Sucursal
    {
        private int id;
        private string nombre;
        private int tipoDocSupervisor;
        private string nroDocSupervisor = "NULL";
        private int tipoDocSuplente;
        private string nroDocSuplente = "NULL";
    
        public int Id
        {
            get => id;
            set => id = value;
        }

        public int TipoDocumentoSupervisor
        {
            get => tipoDocSupervisor;
            set => tipoDocSupervisor = value;
        }

        public int TipoDocumentoSuplente
        {
            get => tipoDocSuplente;
            set => tipoDocSuplente = value;
        }

        public string NroDocumentoSupervisor
        {
            get => nroDocSupervisor;
            set => nroDocSupervisor = value;
        }

        public string NroDocumentoSuplente
        {
            get => nroDocSuplente;
            set => nroDocSuplente = value;
        }

        public string NombreSucursal
        {
            get => nombre;
            set => nombre = value;
        }
    }
}
