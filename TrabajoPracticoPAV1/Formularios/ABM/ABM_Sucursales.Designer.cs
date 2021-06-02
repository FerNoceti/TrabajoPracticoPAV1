namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Sucursales
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
            this.lbSucursales = new System.Windows.Forms.Label();
            this.lbNombreSucursal = new System.Windows.Forms.Label();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.gdrSucursales = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuperVisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suplente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.btnActualizarSucursal = new System.Windows.Forms.Button();
            this.btnEliminarSucursal = new System.Windows.Forms.Button();
            this.btnCancelarOperacion = new System.Windows.Forms.Button();
            this.cmbTipoDocSupervisor = new System.Windows.Forms.ComboBox();
            this.cmbTipoDocSuplente = new System.Windows.Forms.ComboBox();
            this.txtNroDocumentoSupervisor = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoSuplente = new System.Windows.Forms.TextBox();
            this.grpSupervisor = new System.Windows.Forms.GroupBox();
            this.lbSupervisorListo = new System.Windows.Forms.Label();
            this.lbSupervError = new System.Windows.Forms.Label();
            this.txtApellidoSupervisor = new System.Windows.Forms.TextBox();
            this.txtNombreSupervisor = new System.Windows.Forms.TextBox();
            this.lbApellidoSupervisor = new System.Windows.Forms.Label();
            this.lbNombreSupervisor = new System.Windows.Forms.Label();
            this.btnBuscarSupervisor = new System.Windows.Forms.Button();
            this.grpSuplente = new System.Windows.Forms.GroupBox();
            this.lbSuplenteListo = new System.Windows.Forms.Label();
            this.lbCamposSuplIncompletos = new System.Windows.Forms.Label();
            this.lbSuplError = new System.Windows.Forms.Label();
            this.txtApellidoSuplente = new System.Windows.Forms.TextBox();
            this.btnBuscarSuplente = new System.Windows.Forms.Button();
            this.txtNombreSuplente = new System.Windows.Forms.TextBox();
            this.lbApellidoSuplente = new System.Windows.Forms.Label();
            this.lbNombreSuplente = new System.Windows.Forms.Label();
            this.txtIdSucursal = new System.Windows.Forms.TextBox();
            this.lbIdSucursal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSucursales)).BeginInit();
            this.grpSupervisor.SuspendLayout();
            this.grpSuplente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSucursales
            // 
            this.lbSucursales.AutoSize = true;
            this.lbSucursales.Location = new System.Drawing.Point(174, 9);
            this.lbSucursales.Name = "lbSucursales";
            this.lbSucursales.Size = new System.Drawing.Size(59, 13);
            this.lbSucursales.TabIndex = 0;
            this.lbSucursales.Text = "Sucursales";
            // 
            // lbNombreSucursal
            // 
            this.lbNombreSucursal.AutoSize = true;
            this.lbNombreSucursal.Location = new System.Drawing.Point(109, 56);
            this.lbNombreSucursal.Name = "lbNombreSucursal";
            this.lbNombreSucursal.Size = new System.Drawing.Size(44, 13);
            this.lbNombreSucursal.TabIndex = 1;
            this.lbNombreSucursal.Text = "Nombre";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(159, 53);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(221, 20);
            this.txtNombreSucursal.TabIndex = 4;
            // 
            // gdrSucursales
            // 
            this.gdrSucursales.AllowUserToAddRows = false;
            this.gdrSucursales.AllowUserToDeleteRows = false;
            this.gdrSucursales.AllowUserToResizeColumns = false;
            this.gdrSucursales.AllowUserToResizeRows = false;
            this.gdrSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.SuperVisor,
            this.Suplente});
            this.gdrSucursales.Location = new System.Drawing.Point(397, 12);
            this.gdrSucursales.MultiSelect = false;
            this.gdrSucursales.Name = "gdrSucursales";
            this.gdrSucursales.ReadOnly = true;
            this.gdrSucursales.RowHeadersVisible = false;
            this.gdrSucursales.Size = new System.Drawing.Size(305, 583);
            this.gdrSucursales.TabIndex = 7;
            this.gdrSucursales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrSucursales_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 25;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 75;
            // 
            // SuperVisor
            // 
            this.SuperVisor.HeaderText = "SuperVisor";
            this.SuperVisor.Name = "SuperVisor";
            this.SuperVisor.ReadOnly = true;
            // 
            // Suplente
            // 
            this.Suplente.HeaderText = "Suplente";
            this.Suplente.Name = "Suplente";
            this.Suplente.ReadOnly = true;
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Location = new System.Drawing.Point(12, 492);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(366, 31);
            this.btnAgregarSucursal.TabIndex = 8;
            this.btnAgregarSucursal.Text = "Agregar";
            this.btnAgregarSucursal.UseVisualStyleBackColor = true;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // btnActualizarSucursal
            // 
            this.btnActualizarSucursal.Location = new System.Drawing.Point(12, 529);
            this.btnActualizarSucursal.Name = "btnActualizarSucursal";
            this.btnActualizarSucursal.Size = new System.Drawing.Size(178, 31);
            this.btnActualizarSucursal.TabIndex = 9;
            this.btnActualizarSucursal.Text = "Actualizar";
            this.btnActualizarSucursal.UseVisualStyleBackColor = true;
            this.btnActualizarSucursal.Click += new System.EventHandler(this.btnActualizarSucursal_Click);
            // 
            // btnEliminarSucursal
            // 
            this.btnEliminarSucursal.Location = new System.Drawing.Point(200, 529);
            this.btnEliminarSucursal.Name = "btnEliminarSucursal";
            this.btnEliminarSucursal.Size = new System.Drawing.Size(178, 31);
            this.btnEliminarSucursal.TabIndex = 10;
            this.btnEliminarSucursal.Text = "Eliminar";
            this.btnEliminarSucursal.UseVisualStyleBackColor = true;
            this.btnEliminarSucursal.Click += new System.EventHandler(this.btnEliminarSucursal_Click);
            // 
            // btnCancelarOperacion
            // 
            this.btnCancelarOperacion.Location = new System.Drawing.Point(9, 566);
            this.btnCancelarOperacion.Name = "btnCancelarOperacion";
            this.btnCancelarOperacion.Size = new System.Drawing.Size(369, 31);
            this.btnCancelarOperacion.TabIndex = 11;
            this.btnCancelarOperacion.Text = "Cancelar";
            this.btnCancelarOperacion.UseVisualStyleBackColor = true;
            this.btnCancelarOperacion.Click += new System.EventHandler(this.btnCancelarOperacion_Click);
            // 
            // cmbTipoDocSupervisor
            // 
            this.cmbTipoDocSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocSupervisor.FormattingEnabled = true;
            this.cmbTipoDocSupervisor.Location = new System.Drawing.Point(26, 31);
            this.cmbTipoDocSupervisor.Name = "cmbTipoDocSupervisor";
            this.cmbTipoDocSupervisor.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDocSupervisor.TabIndex = 12;
            this.cmbTipoDocSupervisor.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocSupervisor_SelectedValueChanged);
            // 
            // cmbTipoDocSuplente
            // 
            this.cmbTipoDocSuplente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocSuplente.FormattingEnabled = true;
            this.cmbTipoDocSuplente.Location = new System.Drawing.Point(26, 30);
            this.cmbTipoDocSuplente.Name = "cmbTipoDocSuplente";
            this.cmbTipoDocSuplente.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDocSuplente.TabIndex = 13;
            this.cmbTipoDocSuplente.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocSuplente_SelectedValueChanged);
            // 
            // txtNroDocumentoSupervisor
            // 
            this.txtNroDocumentoSupervisor.Location = new System.Drawing.Point(164, 31);
            this.txtNroDocumentoSupervisor.Name = "txtNroDocumentoSupervisor";
            this.txtNroDocumentoSupervisor.Size = new System.Drawing.Size(121, 20);
            this.txtNroDocumentoSupervisor.TabIndex = 14;
            this.txtNroDocumentoSupervisor.TextChanged += new System.EventHandler(this.txtNroDocumentoSupervisor_TextChanged);
            // 
            // txtNroDocumentoSuplente
            // 
            this.txtNroDocumentoSuplente.Location = new System.Drawing.Point(164, 30);
            this.txtNroDocumentoSuplente.Name = "txtNroDocumentoSuplente";
            this.txtNroDocumentoSuplente.Size = new System.Drawing.Size(121, 20);
            this.txtNroDocumentoSuplente.TabIndex = 15;
            this.txtNroDocumentoSuplente.TextChanged += new System.EventHandler(this.txtNroDocumentoSuplente_TextChanged);
            // 
            // grpSupervisor
            // 
            this.grpSupervisor.Controls.Add(this.lbSupervisorListo);
            this.grpSupervisor.Controls.Add(this.lbSupervError);
            this.grpSupervisor.Controls.Add(this.txtApellidoSupervisor);
            this.grpSupervisor.Controls.Add(this.txtNombreSupervisor);
            this.grpSupervisor.Controls.Add(this.lbApellidoSupervisor);
            this.grpSupervisor.Controls.Add(this.lbNombreSupervisor);
            this.grpSupervisor.Controls.Add(this.btnBuscarSupervisor);
            this.grpSupervisor.Controls.Add(this.cmbTipoDocSupervisor);
            this.grpSupervisor.Controls.Add(this.txtNroDocumentoSupervisor);
            this.grpSupervisor.Location = new System.Drawing.Point(15, 83);
            this.grpSupervisor.Name = "grpSupervisor";
            this.grpSupervisor.Size = new System.Drawing.Size(365, 189);
            this.grpSupervisor.TabIndex = 16;
            this.grpSupervisor.TabStop = false;
            this.grpSupervisor.Text = "Supervisor";
            // 
            // lbSupervisorListo
            // 
            this.lbSupervisorListo.AutoSize = true;
            this.lbSupervisorListo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbSupervisorListo.Location = new System.Drawing.Point(32, 163);
            this.lbSupervisorListo.Name = "lbSupervisorListo";
            this.lbSupervisorListo.Size = new System.Drawing.Size(142, 13);
            this.lbSupervisorListo.TabIndex = 27;
            this.lbSupervisorListo.Text = "Supervisor listo para registrar";
            // 
            // lbSupervError
            // 
            this.lbSupervError.AutoSize = true;
            this.lbSupervError.ForeColor = System.Drawing.Color.Red;
            this.lbSupervError.Location = new System.Drawing.Point(119, 63);
            this.lbSupervError.Name = "lbSupervError";
            this.lbSupervError.Size = new System.Drawing.Size(129, 13);
            this.lbSupervError.TabIndex = 26;
            this.lbSupervError.Text = "Empleado No Encontrado";
            this.lbSupervError.Visible = false;
            // 
            // txtApellidoSupervisor
            // 
            this.txtApellidoSupervisor.Enabled = false;
            this.txtApellidoSupervisor.Location = new System.Drawing.Point(97, 135);
            this.txtApellidoSupervisor.Name = "txtApellidoSupervisor";
            this.txtApellidoSupervisor.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoSupervisor.TabIndex = 20;
            // 
            // txtNombreSupervisor
            // 
            this.txtNombreSupervisor.Enabled = false;
            this.txtNombreSupervisor.Location = new System.Drawing.Point(97, 99);
            this.txtNombreSupervisor.Name = "txtNombreSupervisor";
            this.txtNombreSupervisor.Size = new System.Drawing.Size(121, 20);
            this.txtNombreSupervisor.TabIndex = 18;
            // 
            // lbApellidoSupervisor
            // 
            this.lbApellidoSupervisor.AutoSize = true;
            this.lbApellidoSupervisor.Location = new System.Drawing.Point(32, 138);
            this.lbApellidoSupervisor.Name = "lbApellidoSupervisor";
            this.lbApellidoSupervisor.Size = new System.Drawing.Size(44, 13);
            this.lbApellidoSupervisor.TabIndex = 17;
            this.lbApellidoSupervisor.Text = "Apellido";
            // 
            // lbNombreSupervisor
            // 
            this.lbNombreSupervisor.AutoSize = true;
            this.lbNombreSupervisor.Location = new System.Drawing.Point(32, 102);
            this.lbNombreSupervisor.Name = "lbNombreSupervisor";
            this.lbNombreSupervisor.Size = new System.Drawing.Size(44, 13);
            this.lbNombreSupervisor.TabIndex = 16;
            this.lbNombreSupervisor.Text = "Nombre";
            // 
            // btnBuscarSupervisor
            // 
            this.btnBuscarSupervisor.Location = new System.Drawing.Point(26, 58);
            this.btnBuscarSupervisor.Name = "btnBuscarSupervisor";
            this.btnBuscarSupervisor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarSupervisor.TabIndex = 15;
            this.btnBuscarSupervisor.Text = "Buscar";
            this.btnBuscarSupervisor.UseVisualStyleBackColor = true;
            this.btnBuscarSupervisor.Click += new System.EventHandler(this.btnBuscarSupervisor_Click);
            // 
            // grpSuplente
            // 
            this.grpSuplente.Controls.Add(this.lbSuplenteListo);
            this.grpSuplente.Controls.Add(this.lbCamposSuplIncompletos);
            this.grpSuplente.Controls.Add(this.lbSuplError);
            this.grpSuplente.Controls.Add(this.txtApellidoSuplente);
            this.grpSuplente.Controls.Add(this.btnBuscarSuplente);
            this.grpSuplente.Controls.Add(this.txtNombreSuplente);
            this.grpSuplente.Controls.Add(this.lbApellidoSuplente);
            this.grpSuplente.Controls.Add(this.cmbTipoDocSuplente);
            this.grpSuplente.Controls.Add(this.lbNombreSuplente);
            this.grpSuplente.Controls.Add(this.txtNroDocumentoSuplente);
            this.grpSuplente.Location = new System.Drawing.Point(15, 287);
            this.grpSuplente.Name = "grpSuplente";
            this.grpSuplente.Size = new System.Drawing.Size(365, 192);
            this.grpSuplente.TabIndex = 17;
            this.grpSuplente.TabStop = false;
            this.grpSuplente.Text = "Suplente";
            // 
            // lbSuplenteListo
            // 
            this.lbSuplenteListo.AutoSize = true;
            this.lbSuplenteListo.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbSuplenteListo.Location = new System.Drawing.Point(32, 166);
            this.lbSuplenteListo.Name = "lbSuplenteListo";
            this.lbSuplenteListo.Size = new System.Drawing.Size(134, 13);
            this.lbSuplenteListo.TabIndex = 28;
            this.lbSuplenteListo.Text = "Suplente listo para registrar";
            // 
            // lbCamposSuplIncompletos
            // 
            this.lbCamposSuplIncompletos.AutoSize = true;
            this.lbCamposSuplIncompletos.ForeColor = System.Drawing.Color.Red;
            this.lbCamposSuplIncompletos.Location = new System.Drawing.Point(119, 62);
            this.lbCamposSuplIncompletos.Name = "lbCamposSuplIncompletos";
            this.lbCamposSuplIncompletos.Size = new System.Drawing.Size(0, 13);
            this.lbCamposSuplIncompletos.TabIndex = 26;
            this.lbCamposSuplIncompletos.Visible = false;
            // 
            // lbSuplError
            // 
            this.lbSuplError.AutoSize = true;
            this.lbSuplError.ForeColor = System.Drawing.Color.Red;
            this.lbSuplError.Location = new System.Drawing.Point(119, 62);
            this.lbSuplError.Name = "lbSuplError";
            this.lbSuplError.Size = new System.Drawing.Size(129, 13);
            this.lbSuplError.TabIndex = 25;
            this.lbSuplError.Text = "Empleado No Encontrado";
            this.lbSuplError.Visible = false;
            // 
            // txtApellidoSuplente
            // 
            this.txtApellidoSuplente.Enabled = false;
            this.txtApellidoSuplente.Location = new System.Drawing.Point(106, 134);
            this.txtApellidoSuplente.Name = "txtApellidoSuplente";
            this.txtApellidoSuplente.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoSuplente.TabIndex = 24;
            // 
            // btnBuscarSuplente
            // 
            this.btnBuscarSuplente.Location = new System.Drawing.Point(26, 57);
            this.btnBuscarSuplente.Name = "btnBuscarSuplente";
            this.btnBuscarSuplente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarSuplente.TabIndex = 16;
            this.btnBuscarSuplente.Text = "Buscar";
            this.btnBuscarSuplente.UseVisualStyleBackColor = true;
            this.btnBuscarSuplente.Click += new System.EventHandler(this.btnBuscarSuplente_Click);
            // 
            // txtNombreSuplente
            // 
            this.txtNombreSuplente.Enabled = false;
            this.txtNombreSuplente.Location = new System.Drawing.Point(106, 98);
            this.txtNombreSuplente.Name = "txtNombreSuplente";
            this.txtNombreSuplente.Size = new System.Drawing.Size(121, 20);
            this.txtNombreSuplente.TabIndex = 23;
            // 
            // lbApellidoSuplente
            // 
            this.lbApellidoSuplente.AutoSize = true;
            this.lbApellidoSuplente.Location = new System.Drawing.Point(41, 137);
            this.lbApellidoSuplente.Name = "lbApellidoSuplente";
            this.lbApellidoSuplente.Size = new System.Drawing.Size(44, 13);
            this.lbApellidoSuplente.TabIndex = 22;
            this.lbApellidoSuplente.Text = "Apellido";
            // 
            // lbNombreSuplente
            // 
            this.lbNombreSuplente.AutoSize = true;
            this.lbNombreSuplente.Location = new System.Drawing.Point(41, 101);
            this.lbNombreSuplente.Name = "lbNombreSuplente";
            this.lbNombreSuplente.Size = new System.Drawing.Size(44, 13);
            this.lbNombreSuplente.TabIndex = 21;
            this.lbNombreSuplente.Text = "Nombre";
            // 
            // txtIdSucursal
            // 
            this.txtIdSucursal.Enabled = false;
            this.txtIdSucursal.Location = new System.Drawing.Point(50, 53);
            this.txtIdSucursal.Name = "txtIdSucursal";
            this.txtIdSucursal.Size = new System.Drawing.Size(35, 20);
            this.txtIdSucursal.TabIndex = 21;
            // 
            // lbIdSucursal
            // 
            this.lbIdSucursal.AutoSize = true;
            this.lbIdSucursal.Location = new System.Drawing.Point(23, 56);
            this.lbIdSucursal.Name = "lbIdSucursal";
            this.lbIdSucursal.Size = new System.Drawing.Size(16, 13);
            this.lbIdSucursal.TabIndex = 22;
            this.lbIdSucursal.Text = "Id";
            // 
            // ABM_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 607);
            this.Controls.Add(this.lbIdSucursal);
            this.Controls.Add(this.txtIdSucursal);
            this.Controls.Add(this.grpSuplente);
            this.Controls.Add(this.grpSupervisor);
            this.Controls.Add(this.btnCancelarOperacion);
            this.Controls.Add(this.btnEliminarSucursal);
            this.Controls.Add(this.btnActualizarSucursal);
            this.Controls.Add(this.btnAgregarSucursal);
            this.Controls.Add(this.gdrSucursales);
            this.Controls.Add(this.txtNombreSucursal);
            this.Controls.Add(this.lbNombreSucursal);
            this.Controls.Add(this.lbSucursales);
            this.Name = "ABM_Sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.ABM_Sucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrSucursales)).EndInit();
            this.grpSupervisor.ResumeLayout(false);
            this.grpSupervisor.PerformLayout();
            this.grpSuplente.ResumeLayout(false);
            this.grpSuplente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSucursales;
        private System.Windows.Forms.Label lbNombreSucursal;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.Button btnActualizarSucursal;
        private System.Windows.Forms.Button btnEliminarSucursal;
        private System.Windows.Forms.Button btnCancelarOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuperVisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suplente;
        private System.Windows.Forms.ComboBox cmbTipoDocSupervisor;
        private System.Windows.Forms.ComboBox cmbTipoDocSuplente;
        private System.Windows.Forms.TextBox txtNroDocumentoSupervisor;
        private System.Windows.Forms.TextBox txtNroDocumentoSuplente;
        private System.Windows.Forms.GroupBox grpSupervisor;
        private System.Windows.Forms.TextBox txtApellidoSupervisor;
        private System.Windows.Forms.TextBox txtNombreSupervisor;
        private System.Windows.Forms.Label lbApellidoSupervisor;
        private System.Windows.Forms.Label lbNombreSupervisor;
        private System.Windows.Forms.Button btnBuscarSupervisor;
        private System.Windows.Forms.GroupBox grpSuplente;
        private System.Windows.Forms.TextBox txtApellidoSuplente;
        private System.Windows.Forms.Button btnBuscarSuplente;
        private System.Windows.Forms.TextBox txtNombreSuplente;
        private System.Windows.Forms.Label lbApellidoSuplente;
        private System.Windows.Forms.Label lbNombreSuplente;
        private System.Windows.Forms.TextBox txtIdSucursal;
        private System.Windows.Forms.Label lbIdSucursal;
        private System.Windows.Forms.Label lbSupervError;
        private System.Windows.Forms.Label lbSuplError;
        private System.Windows.Forms.Label lbCamposSuplIncompletos;
        private System.Windows.Forms.DataGridView gdrSucursales;
        private System.Windows.Forms.Label lbSupervisorListo;
        private System.Windows.Forms.Label lbSuplenteListo;
    }
}