
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Consultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFechaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.gridConsultas = new System.Windows.Forms.DataGridView();
            this.Nro_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historia_Clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarConsulta = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnGuardarConsulta = new System.Windows.Forms.Button();
            this.btnEliminarConsulta = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.grpConsultor = new System.Windows.Forms.GroupBox();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPerros = new System.Windows.Forms.ComboBox();
            this.grpMedicamentos = new System.Windows.Forms.GroupBox();
            this.btnModificarMedicamento = new System.Windows.Forms.Button();
            this.btnEliminarMedicamento = new System.Windows.Forms.Button();
            this.dgvMedicamentosSelec = new System.Windows.Forms.DataGridView();
            this.CodMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.cmbMedicamentos = new System.Windows.Forms.ComboBox();
            this.grpDiagnosticos = new System.Windows.Forms.GroupBox();
            this.btnModificarDiagnostico = new System.Windows.Forms.Button();
            this.btnEliminarDiagnostico = new System.Windows.Forms.Button();
            this.dgvDiagnosticosSelec = new System.Windows.Forms.DataGridView();
            this.CodDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarDiagnosticos = new System.Windows.Forms.Button();
            this.cmbDiagnosticos = new System.Windows.Forms.ComboBox();
            this.lbCantidadMedicamentos = new System.Windows.Forms.Label();
            this.txtCantidadMedicamento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultas)).BeginInit();
            this.grpConsultor.SuspendLayout();
            this.grpMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosSelec)).BeginInit();
            this.grpDiagnosticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticosSelec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(10, 130);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(142, 18);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de Entrada:";
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFechaEntrada.Location = new System.Drawing.Point(280, 130);
            this.txtFechaEntrada.Mask = "00/00/0000";
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(100, 26);
            this.txtFechaEntrada.TabIndex = 10;
            this.txtFechaEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Enabled = false;
            this.txtIdConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtIdConsulta.Location = new System.Drawing.Point(190, 50);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(190, 26);
            this.txtIdConsulta.TabIndex = 9;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(10, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(130, 18);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Nro de Consulta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(10, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Sucursal:";
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNumeroDoc.Location = new System.Drawing.Point(10, 100);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(149, 18);
            this.lblNumeroDoc.TabIndex = 14;
            this.lblNumeroDoc.Text = "NroDoc Empleado:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoDoc.Location = new System.Drawing.Point(10, 70);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(157, 18);
            this.lblTipoDoc.TabIndex = 12;
            this.lblTipoDoc.Text = "TipoDoc  Empleado:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(190, 20);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(190, 26);
            this.cmbSucursal.TabIndex = 16;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Perro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha de Salida:";
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFechaSalida.Location = new System.Drawing.Point(280, 170);
            this.txtFechaSalida.Mask = "00/00/0000";
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(100, 26);
            this.txtFechaSalida.TabIndex = 19;
            this.txtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // gridConsultas
            // 
            this.gridConsultas.AllowUserToAddRows = false;
            this.gridConsultas.AllowUserToDeleteRows = false;
            this.gridConsultas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Consulta,
            this.Historia_Clinica,
            this.Sucursal,
            this.TipoDoc,
            this.Doc,
            this.FechaE,
            this.FechaS});
            this.gridConsultas.Location = new System.Drawing.Point(410, 160);
            this.gridConsultas.Name = "gridConsultas";
            this.gridConsultas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridConsultas.RowHeadersVisible = false;
            this.gridConsultas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridConsultas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridConsultas.Size = new System.Drawing.Size(690, 510);
            this.gridConsultas.TabIndex = 21;
            this.gridConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultas_CellClick);
            // 
            // Nro_Consulta
            // 
            this.Nro_Consulta.DataPropertyName = "Id";
            this.Nro_Consulta.HeaderText = "Consulta N°";
            this.Nro_Consulta.Name = "Nro_Consulta";
            this.Nro_Consulta.ReadOnly = true;
            // 
            // Historia_Clinica
            // 
            this.Historia_Clinica.DataPropertyName = "NroHistoriaClinica";
            this.Historia_Clinica.HeaderText = "N° Historia Clinica";
            this.Historia_Clinica.Name = "Historia_Clinica";
            this.Historia_Clinica.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.DataPropertyName = "IdSucursal";
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // TipoDoc
            // 
            this.TipoDoc.DataPropertyName = "TipoDocumentoEmpl";
            this.TipoDoc.HeaderText = "Tipo de Documento Empleado";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.ReadOnly = true;
            // 
            // Doc
            // 
            this.Doc.DataPropertyName = "NroDocumentoEmpl";
            this.Doc.HeaderText = "N° Documento Empleado";
            this.Doc.Name = "Doc";
            this.Doc.ReadOnly = true;
            // 
            // FechaE
            // 
            this.FechaE.DataPropertyName = "FechaEntrada";
            this.FechaE.HeaderText = "Fecha de Entrada";
            this.FechaE.Name = "FechaE";
            this.FechaE.ReadOnly = true;
            // 
            // FechaS
            // 
            this.FechaS.DataPropertyName = "FechaSalida";
            this.FechaS.HeaderText = "Fecha de Salida";
            this.FechaS.Name = "FechaS";
            this.FechaS.ReadOnly = true;
            // 
            // btnActualizarConsulta
            // 
            this.btnActualizarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnActualizarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarConsulta.Location = new System.Drawing.Point(810, 90);
            this.btnActualizarConsulta.Name = "btnActualizarConsulta";
            this.btnActualizarConsulta.Size = new System.Drawing.Size(130, 50);
            this.btnActualizarConsulta.TabIndex = 29;
            this.btnActualizarConsulta.Text = "Actualizar Consulta";
            this.btnActualizarConsulta.UseVisualStyleBackColor = false;
            this.btnActualizarConsulta.Click += new System.EventHandler(this.btnActualizarConsulta_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDatos.Location = new System.Drawing.Point(960, 20);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(130, 50);
            this.btnLimpiarDatos.TabIndex = 28;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnGuardarConsulta
            // 
            this.btnGuardarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnGuardarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardarConsulta.Location = new System.Drawing.Point(810, 20);
            this.btnGuardarConsulta.Name = "btnGuardarConsulta";
            this.btnGuardarConsulta.Size = new System.Drawing.Size(130, 50);
            this.btnGuardarConsulta.TabIndex = 27;
            this.btnGuardarConsulta.Text = "Guardar Consulta";
            this.btnGuardarConsulta.UseVisualStyleBackColor = false;
            this.btnGuardarConsulta.Click += new System.EventHandler(this.btnGuardarConsulta_Click);
            // 
            // btnEliminarConsulta
            // 
            this.btnEliminarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnEliminarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarConsulta.Location = new System.Drawing.Point(960, 90);
            this.btnEliminarConsulta.Name = "btnEliminarConsulta";
            this.btnEliminarConsulta.Size = new System.Drawing.Size(130, 50);
            this.btnEliminarConsulta.TabIndex = 30;
            this.btnEliminarConsulta.Text = "Eliminar Consulta";
            this.btnEliminarConsulta.UseVisualStyleBackColor = false;
            this.btnEliminarConsulta.Click += new System.EventHandler(this.btnEliminarConsulta_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(180, 20);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(190, 26);
            this.cmbEmpleados.TabIndex = 31;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // grpConsultor
            // 
            this.grpConsultor.Controls.Add(this.txtTipoDoc);
            this.grpConsultor.Controls.Add(this.txtNumeroDoc);
            this.grpConsultor.Controls.Add(this.label3);
            this.grpConsultor.Controls.Add(this.cmbEmpleados);
            this.grpConsultor.Controls.Add(this.lblTipoDoc);
            this.grpConsultor.Controls.Add(this.lblNumeroDoc);
            this.grpConsultor.Location = new System.Drawing.Point(410, 0);
            this.grpConsultor.Name = "grpConsultor";
            this.grpConsultor.Size = new System.Drawing.Size(380, 150);
            this.grpConsultor.TabIndex = 32;
            this.grpConsultor.TabStop = false;
            this.grpConsultor.Text = "Profesional Consultor";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Enabled = false;
            this.txtTipoDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTipoDoc.Location = new System.Drawing.Point(180, 70);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(190, 26);
            this.txtTipoDoc.TabIndex = 34;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Enabled = false;
            this.txtNumeroDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNumeroDoc.Location = new System.Drawing.Point(180, 100);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(190, 26);
            this.txtNumeroDoc.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Empleado";
            // 
            // cmbPerros
            // 
            this.cmbPerros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbPerros.FormattingEnabled = true;
            this.cmbPerros.Location = new System.Drawing.Point(190, 90);
            this.cmbPerros.Name = "cmbPerros";
            this.cmbPerros.Size = new System.Drawing.Size(190, 26);
            this.cmbPerros.TabIndex = 33;
            // 
            // grpMedicamentos
            // 
            this.grpMedicamentos.Controls.Add(this.lbCantidadMedicamentos);
            this.grpMedicamentos.Controls.Add(this.txtCantidadMedicamento);
            this.grpMedicamentos.Controls.Add(this.btnModificarMedicamento);
            this.grpMedicamentos.Controls.Add(this.btnEliminarMedicamento);
            this.grpMedicamentos.Controls.Add(this.dgvMedicamentosSelec);
            this.grpMedicamentos.Controls.Add(this.btnAgregarMedicamento);
            this.grpMedicamentos.Controls.Add(this.cmbMedicamentos);
            this.grpMedicamentos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMedicamentos.Location = new System.Drawing.Point(10, 210);
            this.grpMedicamentos.Name = "grpMedicamentos";
            this.grpMedicamentos.Size = new System.Drawing.Size(380, 240);
            this.grpMedicamentos.TabIndex = 34;
            this.grpMedicamentos.TabStop = false;
            this.grpMedicamentos.Text = "Medicamentos";
            // 
            // btnModificarMedicamento
            // 
            this.btnModificarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnModificarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMedicamento.Location = new System.Drawing.Point(220, 210);
            this.btnModificarMedicamento.Name = "btnModificarMedicamento";
            this.btnModificarMedicamento.Size = new System.Drawing.Size(150, 23);
            this.btnModificarMedicamento.TabIndex = 5;
            this.btnModificarMedicamento.Text = "Modificar";
            this.btnModificarMedicamento.UseVisualStyleBackColor = false;
            this.btnModificarMedicamento.Click += new System.EventHandler(this.btnModificarMedicamento_Click);
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnEliminarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMedicamento.Location = new System.Drawing.Point(10, 210);
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(150, 23);
            this.btnEliminarMedicamento.TabIndex = 4;
            this.btnEliminarMedicamento.Text = "Eliminar";
            this.btnEliminarMedicamento.UseVisualStyleBackColor = false;
            this.btnEliminarMedicamento.Click += new System.EventHandler(this.btnEliminarMedicamento_Click);
            // 
            // dgvMedicamentosSelec
            // 
            this.dgvMedicamentosSelec.AllowUserToAddRows = false;
            this.dgvMedicamentosSelec.AllowUserToDeleteRows = false;
            this.dgvMedicamentosSelec.AllowUserToResizeColumns = false;
            this.dgvMedicamentosSelec.AllowUserToResizeRows = false;
            this.dgvMedicamentosSelec.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMedicamentosSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentosSelec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMedicamento,
            this.NombreMedicamento,
            this.CantidadMedicamento});
            this.dgvMedicamentosSelec.Location = new System.Drawing.Point(10, 80);
            this.dgvMedicamentosSelec.Name = "dgvMedicamentosSelec";
            this.dgvMedicamentosSelec.ReadOnly = true;
            this.dgvMedicamentosSelec.RowHeadersVisible = false;
            this.dgvMedicamentosSelec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMedicamentosSelec.Size = new System.Drawing.Size(360, 120);
            this.dgvMedicamentosSelec.TabIndex = 3;
            this.dgvMedicamentosSelec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentosSelec_CellClick);
            // 
            // CodMedicamento
            // 
            this.CodMedicamento.HeaderText = "Cod";
            this.CodMedicamento.Name = "CodMedicamento";
            this.CodMedicamento.ReadOnly = true;
            this.CodMedicamento.Width = 50;
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.HeaderText = "Nombre";
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.ReadOnly = true;
            this.NombreMedicamento.Width = 210;
            // 
            // CantidadMedicamento
            // 
            this.CantidadMedicamento.HeaderText = "Cantidad";
            this.CantidadMedicamento.Name = "CantidadMedicamento";
            this.CantidadMedicamento.ReadOnly = true;
            this.CantidadMedicamento.Width = 95;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnAgregarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(220, 20);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(150, 23);
            this.btnAgregarMedicamento.TabIndex = 2;
            this.btnAgregarMedicamento.Text = "Agregar";
            this.btnAgregarMedicamento.UseVisualStyleBackColor = false;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // cmbMedicamentos
            // 
            this.cmbMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicamentos.FormattingEnabled = true;
            this.cmbMedicamentos.Location = new System.Drawing.Point(10, 20);
            this.cmbMedicamentos.Name = "cmbMedicamentos";
            this.cmbMedicamentos.Size = new System.Drawing.Size(200, 24);
            this.cmbMedicamentos.TabIndex = 0;
            // 
            // grpDiagnosticos
            // 
            this.grpDiagnosticos.Controls.Add(this.btnModificarDiagnostico);
            this.grpDiagnosticos.Controls.Add(this.btnEliminarDiagnostico);
            this.grpDiagnosticos.Controls.Add(this.dgvDiagnosticosSelec);
            this.grpDiagnosticos.Controls.Add(this.btnAgregarDiagnosticos);
            this.grpDiagnosticos.Controls.Add(this.cmbDiagnosticos);
            this.grpDiagnosticos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDiagnosticos.Location = new System.Drawing.Point(10, 450);
            this.grpDiagnosticos.Name = "grpDiagnosticos";
            this.grpDiagnosticos.Size = new System.Drawing.Size(380, 210);
            this.grpDiagnosticos.TabIndex = 35;
            this.grpDiagnosticos.TabStop = false;
            this.grpDiagnosticos.Text = "Diagnosticos";
            // 
            // btnModificarDiagnostico
            // 
            this.btnModificarDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnModificarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDiagnostico.Location = new System.Drawing.Point(220, 180);
            this.btnModificarDiagnostico.Name = "btnModificarDiagnostico";
            this.btnModificarDiagnostico.Size = new System.Drawing.Size(150, 23);
            this.btnModificarDiagnostico.TabIndex = 5;
            this.btnModificarDiagnostico.Text = "Modificar";
            this.btnModificarDiagnostico.UseVisualStyleBackColor = false;
            this.btnModificarDiagnostico.Click += new System.EventHandler(this.btnModificarDiagnostico_Click);
            // 
            // btnEliminarDiagnostico
            // 
            this.btnEliminarDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnEliminarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDiagnostico.Location = new System.Drawing.Point(10, 180);
            this.btnEliminarDiagnostico.Name = "btnEliminarDiagnostico";
            this.btnEliminarDiagnostico.Size = new System.Drawing.Size(150, 23);
            this.btnEliminarDiagnostico.TabIndex = 4;
            this.btnEliminarDiagnostico.Text = "Eliminar";
            this.btnEliminarDiagnostico.UseVisualStyleBackColor = false;
            this.btnEliminarDiagnostico.Click += new System.EventHandler(this.btnEliminarDiagnostico_Click);
            // 
            // dgvDiagnosticosSelec
            // 
            this.dgvDiagnosticosSelec.AllowUserToAddRows = false;
            this.dgvDiagnosticosSelec.AllowUserToDeleteRows = false;
            this.dgvDiagnosticosSelec.AllowUserToResizeColumns = false;
            this.dgvDiagnosticosSelec.AllowUserToResizeRows = false;
            this.dgvDiagnosticosSelec.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDiagnosticosSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosticosSelec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodDiagnostico,
            this.NombreDiagnostico});
            this.dgvDiagnosticosSelec.Location = new System.Drawing.Point(10, 50);
            this.dgvDiagnosticosSelec.Name = "dgvDiagnosticosSelec";
            this.dgvDiagnosticosSelec.ReadOnly = true;
            this.dgvDiagnosticosSelec.RowHeadersVisible = false;
            this.dgvDiagnosticosSelec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDiagnosticosSelec.Size = new System.Drawing.Size(360, 120);
            this.dgvDiagnosticosSelec.TabIndex = 3;
            this.dgvDiagnosticosSelec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosticosSelec_CellClick);
            // 
            // CodDiagnostico
            // 
            this.CodDiagnostico.HeaderText = "Cod";
            this.CodDiagnostico.Name = "CodDiagnostico";
            this.CodDiagnostico.ReadOnly = true;
            this.CodDiagnostico.Width = 50;
            // 
            // NombreDiagnostico
            // 
            this.NombreDiagnostico.HeaderText = "Nombre";
            this.NombreDiagnostico.Name = "NombreDiagnostico";
            this.NombreDiagnostico.ReadOnly = true;
            this.NombreDiagnostico.Width = 305;
            // 
            // btnAgregarDiagnosticos
            // 
            this.btnAgregarDiagnosticos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnAgregarDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDiagnosticos.Location = new System.Drawing.Point(220, 20);
            this.btnAgregarDiagnosticos.Name = "btnAgregarDiagnosticos";
            this.btnAgregarDiagnosticos.Size = new System.Drawing.Size(150, 23);
            this.btnAgregarDiagnosticos.TabIndex = 2;
            this.btnAgregarDiagnosticos.Text = "Agregar";
            this.btnAgregarDiagnosticos.UseVisualStyleBackColor = false;
            this.btnAgregarDiagnosticos.Click += new System.EventHandler(this.btnAgregarDiagnosticos_Click);
            // 
            // cmbDiagnosticos
            // 
            this.cmbDiagnosticos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnosticos.FormattingEnabled = true;
            this.cmbDiagnosticos.Location = new System.Drawing.Point(20, 20);
            this.cmbDiagnosticos.Name = "cmbDiagnosticos";
            this.cmbDiagnosticos.Size = new System.Drawing.Size(181, 24);
            this.cmbDiagnosticos.TabIndex = 0;
            // 
            // lbCantidadMedicamentos
            // 
            this.lbCantidadMedicamentos.AutoSize = true;
            this.lbCantidadMedicamentos.Location = new System.Drawing.Point(10, 50);
            this.lbCantidadMedicamentos.Name = "lbCantidadMedicamentos";
            this.lbCantidadMedicamentos.Size = new System.Drawing.Size(62, 16);
            this.lbCantidadMedicamentos.TabIndex = 7;
            this.lbCantidadMedicamentos.Text = "Cantidad";
            // 
            // txtCantidadMedicamento
            // 
            this.txtCantidadMedicamento.Location = new System.Drawing.Point(80, 50);
            this.txtCantidadMedicamento.Mask = "99999";
            this.txtCantidadMedicamento.Name = "txtCantidadMedicamento";
            this.txtCantidadMedicamento.Size = new System.Drawing.Size(50, 21);
            this.txtCantidadMedicamento.TabIndex = 6;
            this.txtCantidadMedicamento.ValidatingType = typeof(int);
            // 
            // ABM_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1116, 665);
            this.Controls.Add(this.grpDiagnosticos);
            this.Controls.Add(this.grpMedicamentos);
            this.Controls.Add(this.cmbPerros);
            this.Controls.Add(this.grpConsultor);
            this.Controls.Add(this.btnEliminarConsulta);
            this.Controls.Add(this.btnActualizarConsulta);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnGuardarConsulta);
            this.Controls.Add(this.gridConsultas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.txtIdConsulta);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "ABM_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.ABM_Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultas)).EndInit();
            this.grpConsultor.ResumeLayout(false);
            this.grpConsultor.PerformLayout();
            this.grpMedicamentos.ResumeLayout(false);
            this.grpMedicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosSelec)).EndInit();
            this.grpDiagnosticos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticosSelec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtFechaEntrada;
        private System.Windows.Forms.TextBox txtIdConsulta;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFechaSalida;
        private System.Windows.Forms.DataGridView gridConsultas;
        private System.Windows.Forms.Button btnActualizarConsulta;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnGuardarConsulta;
        private System.Windows.Forms.Button btnEliminarConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Historia_Clinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaS;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.GroupBox grpConsultor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.ComboBox cmbPerros;
        private System.Windows.Forms.GroupBox grpMedicamentos;
        private System.Windows.Forms.Button btnModificarMedicamento;
        private System.Windows.Forms.Button btnEliminarMedicamento;
        private System.Windows.Forms.DataGridView dgvMedicamentosSelec;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.ComboBox cmbMedicamentos;
        private System.Windows.Forms.GroupBox grpDiagnosticos;
        private System.Windows.Forms.Button btnModificarDiagnostico;
        private System.Windows.Forms.Button btnEliminarDiagnostico;
        private System.Windows.Forms.DataGridView dgvDiagnosticosSelec;
        private System.Windows.Forms.Button btnAgregarDiagnosticos;
        private System.Windows.Forms.ComboBox cmbDiagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDiagnostico;
        private System.Windows.Forms.Label lbCantidadMedicamentos;
        private System.Windows.Forms.MaskedTextBox txtCantidadMedicamento;
    }
}