using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Laboratorio
    {
        private int Id;
        private string RazonSocial;
        private string Calle;
        private string NumeroCalle;
        private int IdBarrio;

        public Laboratorio()
        {

        }


        public int IdLaboratorios
        {
            get => Id;
            set => Id = value;
        }
        public string RazonSocialLaboratorio
        {
            get => RazonSocial;
            set => RazonSocial = value;
        }
        public string CalleLaboratorio
        {
            get => Calle;
            set => Calle = value;
        }
        public string NumeroCalleLaboratorio
        {
            get => NumeroCalle;
            set => NumeroCalle = value;
        }
        public int IdBarrioLaboratorio
        {
            get => IdBarrio;
            set => IdBarrio = value;
        }

    }
}
