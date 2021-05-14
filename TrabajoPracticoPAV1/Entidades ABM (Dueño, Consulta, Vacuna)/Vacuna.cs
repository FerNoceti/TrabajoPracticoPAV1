using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    class Vacuna
    {
        private string Id;
        private string Nombre;
        private float Dosis;
        private string Descripcion;

        public Vacuna()
        {

        }

        public Vacuna(string idVacuna, string nombreVacuna, float dosis, string descripcion)
        {
            Id = idVacuna;
            Nombre = nombreVacuna;
            Dosis = dosis;
            Descripcion = descripcion;
        }
        public string IdVacuna
        {
            get => Id;
            set => Id = value;
        }
        public string NombreVacuna
        {
            get => Nombre;
            set => Nombre = value;
        }
        public float DosisVacuna
        {
            get => Dosis;
            set => Dosis = value;
        }
        public string DescripcionVacuna
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }
}
