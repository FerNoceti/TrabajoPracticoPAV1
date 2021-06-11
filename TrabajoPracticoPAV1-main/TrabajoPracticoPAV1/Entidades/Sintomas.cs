using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Sintoma
    {
        private int Id;
        private string Nombre;

        public Sintoma()
        {

        }
        
        public int IdSintomas
        {
            get => Id;
            set => Id = value;
        }

        public string NombreSintomas
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
