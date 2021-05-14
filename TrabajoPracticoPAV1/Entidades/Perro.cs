using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Perro
    {
        private string Nombre;
        private int Peso;
        private int Altura;
        private DateTime FechaNacimiento;
        private int IdSexo;
        private int IdRaza;
        private int IdDueño;
        private int IdSucursal;
        private int HistClinica;
        public Perro(string nombre, int peso, int altura)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
        }
        public Perro()
        {

        }

        public int DueñoPerro
        {
            get => IdDueño;
            set => IdDueño = value;
        }
        public int Sucursal
        {
            get => IdSucursal;
            set => IdSucursal= value;
        }
        public int HistoriaClinica
        {
            get => HistClinica;
            set => HistClinica = value;
        }
        public int SexoPerro
        {
            get => IdSexo;
            set => IdSexo = value;
        }
        public int RazaPerro
        {
            get => IdRaza;
            set => IdRaza = value;
        }
        public DateTime FechaNacimientoPerro
        {
            get => FechaNacimiento;
            set => FechaNacimiento = value;
        }
        public string NombrePerro
        {
            get => Nombre;
            set => Nombre= value;

        }
        public int PesoPerro
        {
            get => Peso;
            set => Peso = value;
        }
        public int AlturaPerro
        {
            get => Altura;
            set => Altura = value;
        }
    }
}
