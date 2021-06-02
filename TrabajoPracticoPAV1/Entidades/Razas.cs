using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Razas
    {
        private int Id_Raza;
        private float PesoMinimoHembra;
        private float PesoMinimoMacho;
        private float PesoMaximoHembra;
        private float PesoMaximoMacho;
        private int AltumaMediaHembra;
        private int AlturaMediaMacho;
        private string NotaCuidados;
        private string Nombre;

        public Razas(int id_raza, float peso_minimohembra, float peso_minimomacho, float peso_maximohembra, float peso_maximomacho, int altura_mediahembra, int altura_mediamacho, string nota_cuidados)
        {
            Id_Raza = id_raza;
            PesoMinimoHembra = peso_minimohembra;
            PesoMinimoMacho = peso_minimomacho;
            PesoMaximoHembra = peso_maximohembra;
            PesoMaximoMacho = peso_maximomacho;
            AltumaMediaHembra = altura_mediahembra;
            AlturaMediaMacho = altura_mediamacho;
            NotaCuidados = nota_cuidados;
        }

        public Razas()
        {

        }
        public int Id_Razas
        {
            get => Id_Raza;
            set => Id_Raza = value;
        }
        public float PesoMinimoHembras
        {
            get => PesoMinimoHembra;
            set => PesoMinimoHembra = value;
        }
        public float PesoMinimoMachos
        {
            get => PesoMinimoMacho;
            set => PesoMinimoMacho = value;
        }
        public float PesoMaximoHembras
        {
            get => PesoMaximoHembra;
            set => PesoMaximoHembra = value;
        }
        public float PesoMaximoMachos
        {
            get => PesoMaximoMacho;
            set => PesoMaximoMacho = value;
        }
        public int AltumaMediaHembras
        {
            get => AltumaMediaHembra;
            set => AltumaMediaHembra = value;
        }
        public int AlturaMediaMachos
        {
            get => AlturaMediaMacho;
            set => AlturaMediaMacho = value;
        }
        public string NotaCuidadosRazas
        {
            get => NotaCuidados;
            set => NotaCuidados = value;
        }
        public string NombreRaza
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
