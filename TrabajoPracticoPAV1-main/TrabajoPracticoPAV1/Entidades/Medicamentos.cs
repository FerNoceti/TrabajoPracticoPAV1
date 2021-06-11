using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoPAV1.Entidades
{
    public class Medicamentos
    {
        private int Id_Medicamento;
        private string Descripcion;
        private int Id_Laboratorio;
        private DateTime Fecha_Ultimna_Compra;
        private int CantidadMinimaXSucursal;
        private int Id_UnidadMedida;
        private int Id_TipoMedicamento;
        private int Precio;

        public Medicamentos(int id_medic, string descrip, int id_lab, DateTime fecha_de_ultima_compra, int cantidad_minima_x_sucursal, int id_unidad_medida, int id_tipo_medicamento, int precio)
        {
            Id_Medicamento = id_medic;
            Descripcion = descrip;
            Id_Laboratorio = id_lab;
            Fecha_Ultimna_Compra = fecha_de_ultima_compra;
            CantidadMinimaXSucursal = cantidad_minima_x_sucursal;
            Id_UnidadMedida = id_unidad_medida;
            Id_TipoMedicamento = id_tipo_medicamento;
            Precio = precio;
        }

        public Medicamentos()
        {

        }
        public int Id_Medicamentos
        {
            get => Id_Medicamento;
            set => Id_Medicamento = value;
        }
        public string DescripcionMedicamentos
        {
            get => Descripcion;
            set => Descripcion = value;
        }
        public int Id_LaboratorioMedicamentos
        {
            get => Id_Laboratorio;
            set => Id_Laboratorio = value;
        }
        public DateTime Fecha_Ultimna_CompraMedicamentos
        {
            get => Fecha_Ultimna_Compra;
            set => Fecha_Ultimna_Compra = value;
        }
        public int CantidadMinimaXSucursal_Medicamentos
        {
            get => CantidadMinimaXSucursal;
            set => CantidadMinimaXSucursal = value;
        }
        public int Id_UnidadMedidaMedicamentos
        {
            get => Id_UnidadMedida;
            set => Id_UnidadMedida = value;
        }
        public int Id_TipoMedicamentos
        {
            get => Id_TipoMedicamento;
            set => Id_TipoMedicamento = value;
        }
        public int PrecioMedicamentos
        {
            get => Precio;
            set => Precio = value;
        }
    }
}
