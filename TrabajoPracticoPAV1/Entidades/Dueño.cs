using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    class Dueño
    {
        private string Id;
        private string Nombre;
        private string Apellido;
        private string Telefono;

        public Dueño()
        {

        }

        public Dueño(string idDueño, string nombre, string apellido, string telefono)
        {
            Id = idDueño;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }
        public string NombreDueño
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string ApellidoDueño
        {
            get => Apellido;
            set => Apellido = value;
        }
        public string TelefonoDueño
        {
            get => Telefono;
            set => Telefono = value;
        }
        public string IdDueño
        {
            get => Id;
            set => Id = value;
        }
    }
}

