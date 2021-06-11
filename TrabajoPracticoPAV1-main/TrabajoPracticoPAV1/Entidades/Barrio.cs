using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Barrio
    {
        private int Id;
        private string Nombre;
        private int IdCiudad;
        private string Descripcion;

        public int IdBarrio
        {
            get => Id;
            set => Id = value;
        }

        public string NombreBarrio
        {
            get => Nombre;
            set => Nombre = value;
        }

        public int CiudadBarrio
        {
            get => IdCiudad;
            set => IdCiudad = value;
        }

        public string DescripcionBarrio
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }
}
