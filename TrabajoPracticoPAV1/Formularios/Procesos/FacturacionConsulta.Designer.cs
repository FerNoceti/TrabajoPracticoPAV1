
namespace TrabajoPracticoPAV1.Formularios.Procesos
{
    partial class FacturacionConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbNroFactura = new System.Windows.Forms.Label();
            this.lbNroConsulta = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.grpPerro = new System.Windows.Forms.GroupBox();
            this.lbNroHistoriaPerro = new System.Windows.Forms.Label();
            this.lbNombrePerro = new System.Windows.Forms.Label();
            this.txtNroHistoriaPerro = new System.Windows.Forms.TextBox();
            this.txtNombrePerro = new System.Windows.Forms.TextBox();
            this.grpDueño = new System.Windows.Forms.GroupBox();
            this.lbApellidoDueño = new System.Windows.Forms.Label();
            this.txtApellidoDueño = new System.Windows.Forms.TextBox();
            this.lbNombreDueño = new System.Windows.Forms.Label();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.grpDetalleFacturacion = new System.Windows.Forms.GroupBox();
            this.lbSignoPeso3 = new System.Windows.Forms.Label();
            this.txtTotalAFacturar = new System.Windows.Forms.TextBox();
            this.grpMedicamentos = new System.Windows.Forms.GroupBox();
            this.lbSignoPeso2 = new System.Windows.Forms.Label();
            this.txtSubtotalMedicamentos = new System.Windows.Forms.TextBox();
            this.lbSubtotalMedicamentos = new System.Windows.Forms.Label();
            this.dgvDetalleMedicamentos = new System.Windows.Forms.DataGridView();
            this.lbTotalAFacturar = new System.Windows.Forms.Label();
            this.grpDiagnostico = new System.Windows.Forms.GroupBox();
            this.lbSignoPeso1 = new System.Windows.Forms.Label();
            this.txtSubtotalDiagnosticos = new System.Windows.Forms.TextBox();
            this.lbSubtotalDiagnosticos = new System.Windows.Forms.Label();
            this.dgvDetalleDiagnosticos = new System.Windows.Forms.DataGridView();
            this.btnConfirmarFacturacion = new System.Windows.Forms.Button();
            this.btnDeshacerFacturacion = new System.Windows.Forms.Button();
            this.btnBuscarConsulta = new System.Windows.Forms.Button();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.cmbNroConsulta = new System.Windows.Forms.ComboBox();
            this.CodigoDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnidadMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPerro.SuspendLayout();
            this.grpDueño.SuspendLayout();
            this.grpDetalleFacturacion.SuspendLayout();
            this.grpMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMedicamentos)).BeginInit();
            this.grpDiagnostico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDiagnosticos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(13, 13);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(37, 13);
            this.lbFecha.TabIndex = 0;
            this.lbFecha.Text = "Fecha";
            // 
            // lbNroFactura
            // 
            this.lbNroFactura.AutoSize = true;
            this.lbNroFactura.Location = new System.Drawing.Point(391, 13);
            this.lbNroFactura.Name = "lbNroFactura";
            this.lbNroFactura.Size = new System.Drawing.Size(60, 13);
            this.lbNroFactura.TabIndex = 1;
            this.lbNroFactura.Text = "NroFactura";
            // 
            // lbNroConsulta
            // 
            this.lbNroConsulta.AutoSize = true;
            this.lbNroConsulta.Location = new System.Drawing.Point(230, 10);
            this.lbNroConsulta.Name = "lbNroConsulta";
            this.lbNroConsulta.Size = new System.Drawing.Size(103, 13);
            this.lbNroConsulta.TabIndex = 2;
            this.lbNroConsulta.Text = "Numero de Consulta";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtFecha.Location = new System.Drawing.Point(16, 29);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(72, 22);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtNroFactura.Location = new System.Drawing.Point(351, 29);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(100, 22);
            this.txtNroFactura.TabIndex = 5;
            // 
            // grpPerro
            // 
            this.grpPerro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.grpPerro.Controls.Add(this.lbNroHistoriaPerro);
            this.grpPerro.Controls.Add(this.lbNombrePerro);
            this.grpPerro.Controls.Add(this.txtNroHistoriaPerro);
            this.grpPerro.Controls.Add(this.txtNombrePerro);
            this.grpPerro.Location = new System.Drawing.Point(10, 90);
            this.grpPerro.Name = "grpPerro";
            this.grpPerro.Size = new System.Drawing.Size(230, 100);
            this.grpPerro.TabIndex = 7;
            this.grpPerro.TabStop = false;
            this.grpPerro.Text = "Perro";
            // 
            // lbNroHistoriaPerro
            // 
            this.lbNroHistoriaPerro.AutoSize = true;
            this.lbNroHistoriaPerro.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbNroHistoriaPerro.Location = new System.Drawing.Point(10, 50);
            this.lbNroHistoriaPerro.Name = "lbNroHistoriaPerro";
            this.lbNroHistoriaPerro.Size = new System.Drawing.Size(79, 17);
            this.lbNroHistoriaPerro.TabIndex = 15;
            this.lbNroHistoriaPerro.Text = "Nro. Historia";
            // 
            // lbNombrePerro
            // 
            this.lbNombrePerro.AutoSize = true;
            this.lbNombrePerro.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbNombrePerro.Location = new System.Drawing.Point(10, 20);
            this.lbNombrePerro.Name = "lbNombrePerro";
            this.lbNombrePerro.Size = new System.Drawing.Size(56, 17);
            this.lbNombrePerro.TabIndex = 14;
            this.lbNombrePerro.Text = "Nombre";
            // 
            // txtNroHistoriaPerro
            // 
            this.txtNroHistoriaPerro.Enabled = false;
            this.txtNroHistoriaPerro.Location = new System.Drawing.Point(90, 50);
            this.txtNroHistoriaPerro.Name = "txtNroHistoriaPerro";
            this.txtNroHistoriaPerro.Size = new System.Drawing.Size(107, 20);
            this.txtNroHistoriaPerro.TabIndex = 16;
            // 
            // txtNombrePerro
            // 
            this.txtNombrePerro.Enabled = false;
            this.txtNombrePerro.Location = new System.Drawing.Point(90, 20);
            this.txtNombrePerro.Name = "txtNombrePerro";
            this.txtNombrePerro.Size = new System.Drawing.Size(107, 20);
            this.txtNombrePerro.TabIndex = 14;
            // 
            // grpDueño
            // 
            this.grpDueño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.grpDueño.Controls.Add(this.lbApellidoDueño);
            this.grpDueño.Controls.Add(this.txtApellidoDueño);
            this.grpDueño.Controls.Add(this.lbNombreDueño);
            this.grpDueño.Controls.Add(this.txtNombreDueño);
            this.grpDueño.Location = new System.Drawing.Point(250, 90);
            this.grpDueño.Name = "grpDueño";
            this.grpDueño.Size = new System.Drawing.Size(210, 100);
            this.grpDueño.TabIndex = 8;
            this.grpDueño.TabStop = false;
            this.grpDueño.Text = "Dueño";
            // 
            // lbApellidoDueño
            // 
            this.lbApellidoDueño.AutoSize = true;
            this.lbApellidoDueño.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbApellidoDueño.Location = new System.Drawing.Point(15, 57);
            this.lbApellidoDueño.Name = "lbApellidoDueño";
            this.lbApellidoDueño.Size = new System.Drawing.Size(58, 17);
            this.lbApellidoDueño.TabIndex = 17;
            this.lbApellidoDueño.Text = "Apellido";
            // 
            // txtApellidoDueño
            // 
            this.txtApellidoDueño.Enabled = false;
            this.txtApellidoDueño.Location = new System.Drawing.Point(74, 54);
            this.txtApellidoDueño.Name = "txtApellidoDueño";
            this.txtApellidoDueño.Size = new System.Drawing.Size(107, 20);
            this.txtApellidoDueño.TabIndex = 18;
            // 
            // lbNombreDueño
            // 
            this.lbNombreDueño.AutoSize = true;
            this.lbNombreDueño.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbNombreDueño.Location = new System.Drawing.Point(15, 22);
            this.lbNombreDueño.Name = "lbNombreDueño";
            this.lbNombreDueño.Size = new System.Drawing.Size(56, 17);
            this.lbNombreDueño.TabIndex = 15;
            this.lbNombreDueño.Text = "Nombre";
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Enabled = false;
            this.txtNombreDueño.Location = new System.Drawing.Point(74, 19);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(107, 20);
            this.txtNombreDueño.TabIndex = 16;
            // 
            // grpDetalleFacturacion
            // 
            this.grpDetalleFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.grpDetalleFacturacion.Controls.Add(this.lbSignoPeso3);
            this.grpDetalleFacturacion.Controls.Add(this.txtTotalAFacturar);
            this.grpDetalleFacturacion.Controls.Add(this.grpMedicamentos);
            this.grpDetalleFacturacion.Controls.Add(this.lbTotalAFacturar);
            this.grpDetalleFacturacion.Controls.Add(this.grpDiagnostico);
            this.grpDetalleFacturacion.Location = new System.Drawing.Point(10, 200);
            this.grpDetalleFacturacion.Name = "grpDetalleFacturacion";
            this.grpDetalleFacturacion.Size = new System.Drawing.Size(450, 364);
            this.grpDetalleFacturacion.TabIndex = 9;
            this.grpDetalleFacturacion.TabStop = false;
            this.grpDetalleFacturacion.Text = "Detalle de Facturacion";
            // 
            // lbSignoPeso3
            // 
            this.lbSignoPeso3.AutoSize = true;
            this.lbSignoPeso3.Location = new System.Drawing.Point(304, 330);
            this.lbSignoPeso3.Name = "lbSignoPeso3";
            this.lbSignoPeso3.Size = new System.Drawing.Size(13, 13);
            this.lbSignoPeso3.TabIndex = 17;
            this.lbSignoPeso3.Text = "$";
            // 
            // txtTotalAFacturar
            // 
            this.txtTotalAFacturar.Enabled = false;
            this.txtTotalAFacturar.Location = new System.Drawing.Point(323, 327);
            this.txtTotalAFacturar.Name = "txtTotalAFacturar";
            this.txtTotalAFacturar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAFacturar.TabIndex = 16;
            // 
            // grpMedicamentos
            // 
            this.grpMedicamentos.Controls.Add(this.lbSignoPeso2);
            this.grpMedicamentos.Controls.Add(this.txtSubtotalMedicamentos);
            this.grpMedicamentos.Controls.Add(this.lbSubtotalMedicamentos);
            this.grpMedicamentos.Controls.Add(this.dgvDetalleMedicamentos);
            this.grpMedicamentos.Location = new System.Drawing.Point(6, 169);
            this.grpMedicamentos.Name = "grpMedicamentos";
            this.grpMedicamentos.Size = new System.Drawing.Size(434, 146);
            this.grpMedicamentos.TabIndex = 9;
            this.grpMedicamentos.TabStop = false;
            this.grpMedicamentos.Text = "Medicamentos";
            // 
            // lbSignoPeso2
            // 
            this.lbSignoPeso2.AutoSize = true;
            this.lbSignoPeso2.Location = new System.Drawing.Point(298, 113);
            this.lbSignoPeso2.Name = "lbSignoPeso2";
            this.lbSignoPeso2.Size = new System.Drawing.Size(13, 13);
            this.lbSignoPeso2.TabIndex = 16;
            this.lbSignoPeso2.Text = "$";
            // 
            // txtSubtotalMedicamentos
            // 
            this.txtSubtotalMedicamentos.Enabled = false;
            this.txtSubtotalMedicamentos.Location = new System.Drawing.Point(317, 110);
            this.txtSubtotalMedicamentos.Name = "txtSubtotalMedicamentos";
            this.txtSubtotalMedicamentos.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalMedicamentos.TabIndex = 15;
            // 
            // lbSubtotalMedicamentos
            // 
            this.lbSubtotalMedicamentos.AutoSize = true;
            this.lbSubtotalMedicamentos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbSubtotalMedicamentos.Location = new System.Drawing.Point(6, 113);
            this.lbSubtotalMedicamentos.Name = "lbSubtotalMedicamentos";
            this.lbSubtotalMedicamentos.Size = new System.Drawing.Size(152, 17);
            this.lbSubtotalMedicamentos.TabIndex = 15;
            this.lbSubtotalMedicamentos.Text = "Subtotal Medicamentos";
            // 
            // dgvDetalleMedicamentos
            // 
            this.dgvDetalleMedicamentos.AllowUserToAddRows = false;
            this.dgvDetalleMedicamentos.AllowUserToDeleteRows = false;
            this.dgvDetalleMedicamentos.AllowUserToResizeColumns = false;
            this.dgvDetalleMedicamentos.AllowUserToResizeRows = false;
            this.dgvDetalleMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMedicamento,
            this.NombreMedicamento,
            this.PrecioUnidadMedicamento,
            this.CantMedicamento});
            this.dgvDetalleMedicamentos.Enabled = false;
            this.dgvDetalleMedicamentos.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalleMedicamentos.Name = "dgvDetalleMedicamentos";
            this.dgvDetalleMedicamentos.ReadOnly = true;
            this.dgvDetalleMedicamentos.RowHeadersVisible = false;
            this.dgvDetalleMedicamentos.Size = new System.Drawing.Size(411, 79);
            this.dgvDetalleMedicamentos.TabIndex = 1;
            // 
            // lbTotalAFacturar
            // 
            this.lbTotalAFacturar.AutoSize = true;
            this.lbTotalAFacturar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbTotalAFacturar.Location = new System.Drawing.Point(12, 330);
            this.lbTotalAFacturar.Name = "lbTotalAFacturar";
            this.lbTotalAFacturar.Size = new System.Drawing.Size(101, 17);
            this.lbTotalAFacturar.TabIndex = 17;
            this.lbTotalAFacturar.Text = "Total a Facturar";
            // 
            // grpDiagnostico
            // 
            this.grpDiagnostico.Controls.Add(this.lbSignoPeso1);
            this.grpDiagnostico.Controls.Add(this.txtSubtotalDiagnosticos);
            this.grpDiagnostico.Controls.Add(this.lbSubtotalDiagnosticos);
            this.grpDiagnostico.Controls.Add(this.dgvDetalleDiagnosticos);
            this.grpDiagnostico.Location = new System.Drawing.Point(6, 17);
            this.grpDiagnostico.Name = "grpDiagnostico";
            this.grpDiagnostico.Size = new System.Drawing.Size(434, 146);
            this.grpDiagnostico.TabIndex = 8;
            this.grpDiagnostico.TabStop = false;
            this.grpDiagnostico.Text = "Diagnosticos";
            this.grpDiagnostico.Enter += new System.EventHandler(this.grpDiagnostico_Enter);
            // 
            // lbSignoPeso1
            // 
            this.lbSignoPeso1.AutoSize = true;
            this.lbSignoPeso1.Location = new System.Drawing.Point(298, 116);
            this.lbSignoPeso1.Name = "lbSignoPeso1";
            this.lbSignoPeso1.Size = new System.Drawing.Size(13, 13);
            this.lbSignoPeso1.TabIndex = 15;
            this.lbSignoPeso1.Text = "$";
            // 
            // txtSubtotalDiagnosticos
            // 
            this.txtSubtotalDiagnosticos.Enabled = false;
            this.txtSubtotalDiagnosticos.Location = new System.Drawing.Point(317, 113);
            this.txtSubtotalDiagnosticos.Name = "txtSubtotalDiagnosticos";
            this.txtSubtotalDiagnosticos.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalDiagnosticos.TabIndex = 14;
            // 
            // lbSubtotalDiagnosticos
            // 
            this.lbSubtotalDiagnosticos.AutoSize = true;
            this.lbSubtotalDiagnosticos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbSubtotalDiagnosticos.Location = new System.Drawing.Point(6, 116);
            this.lbSubtotalDiagnosticos.Name = "lbSubtotalDiagnosticos";
            this.lbSubtotalDiagnosticos.Size = new System.Drawing.Size(139, 17);
            this.lbSubtotalDiagnosticos.TabIndex = 14;
            this.lbSubtotalDiagnosticos.Text = "Subtotal Diagnosticos";
            // 
            // dgvDetalleDiagnosticos
            // 
            this.dgvDetalleDiagnosticos.AllowUserToAddRows = false;
            this.dgvDetalleDiagnosticos.AllowUserToDeleteRows = false;
            this.dgvDetalleDiagnosticos.AllowUserToResizeColumns = false;
            this.dgvDetalleDiagnosticos.AllowUserToResizeRows = false;
            this.dgvDetalleDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleDiagnosticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDiagnostico,
            this.DescripcionDiagnostico,
            this.PrecioDiagnostico});
            this.dgvDetalleDiagnosticos.Enabled = false;
            this.dgvDetalleDiagnosticos.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalleDiagnosticos.Name = "dgvDetalleDiagnosticos";
            this.dgvDetalleDiagnosticos.ReadOnly = true;
            this.dgvDetalleDiagnosticos.RowHeadersVisible = false;
            this.dgvDetalleDiagnosticos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetalleDiagnosticos.Size = new System.Drawing.Size(354, 79);
            this.dgvDetalleDiagnosticos.TabIndex = 0;
            // 
            // btnConfirmarFacturacion
            // 
            this.btnConfirmarFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnConfirmarFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarFacturacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarFacturacion.Location = new System.Drawing.Point(10, 570);
            this.btnConfirmarFacturacion.Name = "btnConfirmarFacturacion";
            this.btnConfirmarFacturacion.Size = new System.Drawing.Size(126, 23);
            this.btnConfirmarFacturacion.TabIndex = 10;
            this.btnConfirmarFacturacion.Text = "Confirmar";
            this.btnConfirmarFacturacion.UseVisualStyleBackColor = false;
            this.btnConfirmarFacturacion.Click += new System.EventHandler(this.btnConfirmarFacturacion_Click);
            // 
            // btnDeshacerFacturacion
            // 
            this.btnDeshacerFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnDeshacerFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacerFacturacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshacerFacturacion.Location = new System.Drawing.Point(325, 567);
            this.btnDeshacerFacturacion.Name = "btnDeshacerFacturacion";
            this.btnDeshacerFacturacion.Size = new System.Drawing.Size(126, 23);
            this.btnDeshacerFacturacion.TabIndex = 11;
            this.btnDeshacerFacturacion.Text = "Deshacer";
            this.btnDeshacerFacturacion.UseVisualStyleBackColor = false;
            this.btnDeshacerFacturacion.Click += new System.EventHandler(this.btnDeshacerFacturacion_Click);
            // 
            // btnBuscarConsulta
            // 
            this.btnBuscarConsulta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnBuscarConsulta.Location = new System.Drawing.Point(200, 60);
            this.btnBuscarConsulta.Name = "btnBuscarConsulta";
            this.btnBuscarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarConsulta.TabIndex = 13;
            this.btnBuscarConsulta.Text = "buscar";
            this.btnBuscarConsulta.UseVisualStyleBackColor = true;
            this.btnBuscarConsulta.Click += new System.EventHandler(this.btnBuscarConsulta_Click);
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(120, 10);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(48, 13);
            this.lbSucursal.TabIndex = 14;
            this.lbSucursal.Text = "Sucursal";
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(120, 30);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(97, 25);
            this.cmbSucursales.TabIndex = 15;
            this.cmbSucursales.SelectedIndexChanged += new System.EventHandler(this.cmbSucursales_SelectedIndexChanged);
            // 
            // cmbNroConsulta
            // 
            this.cmbNroConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroConsulta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cmbNroConsulta.FormattingEnabled = true;
            this.cmbNroConsulta.Location = new System.Drawing.Point(230, 30);
            this.cmbNroConsulta.Name = "cmbNroConsulta";
            this.cmbNroConsulta.Size = new System.Drawing.Size(97, 25);
            this.cmbNroConsulta.TabIndex = 17;
            this.cmbNroConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbNroConsulta_SelectedIndexChanged);
            // 
            // CodigoDiagnostico
            // 
            this.CodigoDiagnostico.DataPropertyName = "Id";
            this.CodigoDiagnostico.HeaderText = "Codigo";
            this.CodigoDiagnostico.Name = "CodigoDiagnostico";
            this.CodigoDiagnostico.ReadOnly = true;
            this.CodigoDiagnostico.Width = 75;
            // 
            // DescripcionDiagnostico
            // 
            this.DescripcionDiagnostico.DataPropertyName = "Descripcion";
            this.DescripcionDiagnostico.HeaderText = "Descripcion";
            this.DescripcionDiagnostico.Name = "DescripcionDiagnostico";
            this.DescripcionDiagnostico.ReadOnly = true;
            this.DescripcionDiagnostico.Width = 200;
            // 
            // PrecioDiagnostico
            // 
            this.PrecioDiagnostico.DataPropertyName = "precio";
            this.PrecioDiagnostico.HeaderText = "PrecioUnidad ($)";
            this.PrecioDiagnostico.Name = "PrecioDiagnostico";
            this.PrecioDiagnostico.ReadOnly = true;
            this.PrecioDiagnostico.Width = 75;
            // 
            // CodigoMedicamento
            // 
            this.CodigoMedicamento.DataPropertyName = "Id";
            this.CodigoMedicamento.HeaderText = "Codigo";
            this.CodigoMedicamento.Name = "CodigoMedicamento";
            this.CodigoMedicamento.ReadOnly = true;
            this.CodigoMedicamento.Width = 50;
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.DataPropertyName = "Descripcion";
            this.NombreMedicamento.HeaderText = "Nombre";
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.ReadOnly = true;
            this.NombreMedicamento.Width = 200;
            // 
            // PrecioUnidadMedicamento
            // 
            this.PrecioUnidadMedicamento.DataPropertyName = "precio";
            this.PrecioUnidadMedicamento.HeaderText = "PrecioUnidad ($)";
            this.PrecioUnidadMedicamento.Name = "PrecioUnidadMedicamento";
            this.PrecioUnidadMedicamento.ReadOnly = true;
            // 
            // CantMedicamento
            // 
            this.CantMedicamento.DataPropertyName = "Dosis";
            this.CantMedicamento.HeaderText = "Cantidad";
            this.CantMedicamento.Name = "CantMedicamento";
            this.CantMedicamento.ReadOnly = true;
            this.CantMedicamento.Width = 50;
            // 
            // FacturacionConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(472, 602);
            this.Controls.Add(this.cmbNroConsulta);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.lbSucursal);
            this.Controls.Add(this.btnBuscarConsulta);
            this.Controls.Add(this.btnDeshacerFacturacion);
            this.Controls.Add(this.btnConfirmarFacturacion);
            this.Controls.Add(this.grpDetalleFacturacion);
            this.Controls.Add(this.grpDueño);
            this.Controls.Add(this.grpPerro);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lbNroConsulta);
            this.Controls.Add(this.lbNroFactura);
            this.Controls.Add(this.lbFecha);
            this.Name = "FacturacionConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturacionConsulta";
            this.Load += new System.EventHandler(this.FacturacionConsulta_Load);
            this.grpPerro.ResumeLayout(false);
            this.grpPerro.PerformLayout();
            this.grpDueño.ResumeLayout(false);
            this.grpDueño.PerformLayout();
            this.grpDetalleFacturacion.ResumeLayout(false);
            this.grpDetalleFacturacion.PerformLayout();
            this.grpMedicamentos.ResumeLayout(false);
            this.grpMedicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleMedicamentos)).EndInit();
            this.grpDiagnostico.ResumeLayout(false);
            this.grpDiagnostico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDiagnosticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbNroFactura;
        private System.Windows.Forms.Label lbNroConsulta;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.GroupBox grpPerro;
        private System.Windows.Forms.GroupBox grpDueño;
        private System.Windows.Forms.GroupBox grpDetalleFacturacion;
        private System.Windows.Forms.GroupBox grpMedicamentos;
        private System.Windows.Forms.GroupBox grpDiagnostico;
        private System.Windows.Forms.Button btnConfirmarFacturacion;
        private System.Windows.Forms.Button btnDeshacerFacturacion;
        private System.Windows.Forms.Button btnBuscarConsulta;
        private System.Windows.Forms.Label lbNroHistoriaPerro;
        private System.Windows.Forms.Label lbNombrePerro;
        private System.Windows.Forms.TextBox txtNroHistoriaPerro;
        private System.Windows.Forms.TextBox txtNombrePerro;
        private System.Windows.Forms.Label lbApellidoDueño;
        private System.Windows.Forms.TextBox txtApellidoDueño;
        private System.Windows.Forms.Label lbNombreDueño;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.TextBox txtTotalAFacturar;
        private System.Windows.Forms.TextBox txtSubtotalMedicamentos;
        private System.Windows.Forms.Label lbSubtotalMedicamentos;
        private System.Windows.Forms.DataGridView dgvDetalleMedicamentos;
        private System.Windows.Forms.Label lbTotalAFacturar;
        private System.Windows.Forms.TextBox txtSubtotalDiagnosticos;
        private System.Windows.Forms.Label lbSubtotalDiagnosticos;
        private System.Windows.Forms.DataGridView dgvDetalleDiagnosticos;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label lbSignoPeso3;
        private System.Windows.Forms.Label lbSignoPeso2;
        private System.Windows.Forms.Label lbSignoPeso1;
        private System.Windows.Forms.ComboBox cmbNroConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidadMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMedicamento;
    }
}