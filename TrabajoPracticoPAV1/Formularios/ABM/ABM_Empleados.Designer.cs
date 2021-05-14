
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Empleados
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
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gdrEmpleados = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbEmpleados = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbTipoDocumento = new System.Windows.Forms.Label();
            this.lbNroDocumento = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnCancelarOperacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(159, 318);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(127, 31);
            this.btnEliminarEmpleado.TabIndex = 1;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(21, 277);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(265, 35);
            this.btnAgregarEmpleado.TabIndex = 2;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(21, 318);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(132, 31);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gdrEmpleados
            // 
            this.gdrEmpleados.AllowUserToAddRows = false;
            this.gdrEmpleados.AllowUserToDeleteRows = false;
            this.gdrEmpleados.AllowUserToResizeColumns = false;
            this.gdrEmpleados.AllowUserToResizeRows = false;
            this.gdrEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NroDocumento,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.FechaIngreso,
            this.Sucursal});
            this.gdrEmpleados.Location = new System.Drawing.Point(317, 12);
            this.gdrEmpleados.MultiSelect = false;
            this.gdrEmpleados.Name = "gdrEmpleados";
            this.gdrEmpleados.ReadOnly = true;
            this.gdrEmpleados.RowHeadersVisible = false;
            this.gdrEmpleados.Size = new System.Drawing.Size(581, 386);
            this.gdrEmpleados.TabIndex = 4;
            this.gdrEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEmpleados_CellClick);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "TipoDoc";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 52;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "NroDocumento";
            this.NroDocumento.HeaderText = "NroDocumento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 75;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 75;
            // 
            // Sucursal
            // 
            this.Sucursal.DataPropertyName = "Sucursal";
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // lbEmpleados
            // 
            this.lbEmpleados.AutoSize = true;
            this.lbEmpleados.Location = new System.Drawing.Point(126, 12);
            this.lbEmpleados.Name = "lbEmpleados";
            this.lbEmpleados.Size = new System.Drawing.Size(59, 13);
            this.lbEmpleados.TabIndex = 5;
            this.lbEmpleados.Text = "Empleados";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(12, 42);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(12, 71);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 7;
            this.lbApellido.Text = "Apellido";
            // 
            // lbTipoDocumento
            // 
            this.lbTipoDocumento.AutoSize = true;
            this.lbTipoDocumento.Location = new System.Drawing.Point(12, 114);
            this.lbTipoDocumento.Name = "lbTipoDocumento";
            this.lbTipoDocumento.Size = new System.Drawing.Size(48, 13);
            this.lbTipoDocumento.TabIndex = 8;
            this.lbTipoDocumento.Text = "TipoDoc";
            // 
            // lbNroDocumento
            // 
            this.lbNroDocumento.AutoSize = true;
            this.lbNroDocumento.Location = new System.Drawing.Point(18, 151);
            this.lbNroDocumento.Name = "lbNroDocumento";
            this.lbNroDocumento.Size = new System.Drawing.Size(44, 13);
            this.lbNroDocumento.TabIndex = 9;
            this.lbNroDocumento.Text = "NroDoc";
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(12, 191);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(85, 26);
            this.lbFechaNacimiento.TabIndex = 10;
            this.lbFechaNacimiento.Text = "   Nacimiento \r\n(DD/MM/YYYY)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(94, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(94, 114);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(192, 21);
            this.cmbTipoDocumento.TabIndex = 13;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(94, 148);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(192, 20);
            this.txtNroDocumento.TabIndex = 14;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(114, 197);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(71, 20);
            this.txtFechaNac.TabIndex = 15;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(18, 233);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(48, 13);
            this.lbSucursal.TabIndex = 16;
            this.lbSucursal.Text = "Sucursal";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(94, 233);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(192, 21);
            this.cmbSucursal.TabIndex = 17;
            // 
            // btnCancelarOperacion
            // 
            this.btnCancelarOperacion.Location = new System.Drawing.Point(21, 355);
            this.btnCancelarOperacion.Name = "btnCancelarOperacion";
            this.btnCancelarOperacion.Size = new System.Drawing.Size(265, 33);
            this.btnCancelarOperacion.TabIndex = 18;
            this.btnCancelarOperacion.Text = "Cancelar";
            this.btnCancelarOperacion.UseVisualStyleBackColor = true;
            this.btnCancelarOperacion.Click += new System.EventHandler(this.btnCancelarOperacion_Click);
            // 
            // ABM_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 410);
            this.Controls.Add(this.btnCancelarOperacion);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lbSucursal);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.lbNroDocumento);
            this.Controls.Add(this.lbTipoDocumento);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbEmpleados);
            this.Controls.Add(this.gdrEmpleados);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Name = "ABM_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ABM_Empleados_FormClosed);
            this.Load += new System.EventHandler(this.ABM_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView gdrEmpleados;
        private System.Windows.Forms.Label lbEmpleados;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbTipoDocumento;
        private System.Windows.Forms.Label lbNroDocumento;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Button btnCancelarOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
    }
}