using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Usuario
    {
        private string NombreUsu;
        private string Pass;
        private DateTime FechaRegistro;
        private string Nombre;
        private string Email;
        private int TipoUsu;
        private string Apellido;

        public Usuario(string nombreUsuario, string password)
        {
            NombreUsu = nombreUsuario;
            Pass = password;

        }
        public string EmailPersona
        {
            get => Email;
            set => Email = value;

        }
        public string ApellidoPersona
        {
            get => Apellido;
            set => Apellido = value;
        }
        public int TipoUsuario
        {
            get => TipoUsu;
            set => TipoUsu = value;

        }
        public string NombrePersona
        {
            get => Nombre;
            set => Nombre = value;

        }
        public DateTime FechaDeRegistro
        {
            get => FechaRegistro;
            set => FechaRegistro = value;
        }

        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;

        }
        public string contraseña
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
