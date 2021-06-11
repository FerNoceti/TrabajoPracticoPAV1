using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Empleado
    {


        private string documento;
        private string apellido;
        private string nombre;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private int idTipoDocumento;
        private int idSucursal;
        private string calle;

        

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string CallePersona
        {
            get => calle;
            set => calle = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string NroDocumento
        {
            get => documento;
            set => documento = value;
        }

        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public DateTime FechaIngreso
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }

        public int TipoDocumento
        {
            get => idTipoDocumento;
            set => idTipoDocumento = value;
        }

        public int Sucursal
        {
            get => idSucursal;
            set => idSucursal = value;
        }

    }
}
