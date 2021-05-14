
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFechaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.txtHistoriaClinica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.gridConsultas = new System.Windows.Forms.DataGridView();
            this.btnActualizarConsulta = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnGuardarConsulta = new System.Windows.Forms.Button();
            this.btnEliminarConsulta = new System.Windows.Forms.Button();
            this.Nro_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historia_Clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(393, 204);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(141, 20);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de Entrada:";
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Location = new System.Drawing.Point(549, 204);
            this.txtFechaEntrada.Mask = "00/00/0000";
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtFechaEntrada.TabIndex = 10;
            this.txtFechaEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Enabled = false;
            this.txtIdConsulta.Location = new System.Drawing.Point(549, 96);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(182, 20);
            this.txtIdConsulta.TabIndex = 9;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(376, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(158, 20);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Numero de Consulta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(459, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Sucursal:";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(549, 178);
            this.txtNumeroDoc.Mask = "99999999";
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(182, 20);
            this.txtNumeroDoc.TabIndex = 15;
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoc.Location = new System.Drawing.Point(258, 178);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(276, 20);
            this.lblNumeroDoc.TabIndex = 14;
            this.lblNumeroDoc.Text = "Numero de Documento de Empleado:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(549, 151);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(182, 21);
            this.cmbTipoDoc.TabIndex = 13;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(284, 151);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(250, 20);
            this.lblTipoDoc.TabIndex = 12;
            this.lblTipoDoc.Text = "Tipo de Documento de Empleado:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(549, 68);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(182, 21);
            this.cmbSucursal.TabIndex = 16;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Location = new System.Drawing.Point(549, 122);
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.Size = new System.Drawing.Size(182, 20);
            this.txtHistoriaClinica.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero de Historia Clinica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha de Salida:";
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(549, 230);
            this.txtFechaSalida.Mask = "00/00/0000";
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(100, 20);
            this.txtFechaSalida.TabIndex = 19;
            this.txtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // gridConsultas
            // 
            this.gridConsultas.AllowUserToAddRows = false;
            this.gridConsultas.AllowUserToDeleteRows = false;
            this.gridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Consulta,
            this.Historia_Clinica,
            this.Sucursal,
            this.TipoDoc,
            this.Doc,
            this.FechaE,
            this.FechaS});
            this.gridConsultas.Location = new System.Drawing.Point(160, 360);
            this.gridConsultas.Name = "gridConsultas";
            this.gridConsultas.ReadOnly = true;
            this.gridConsultas.Size = new System.Drawing.Size(744, 223);
            this.gridConsultas.TabIndex = 21;
            this.gridConsultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultas_CellClick);
            // 
            // btnActualizarConsulta
            // 
            this.btnActualizarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarConsulta.Location = new System.Drawing.Point(428, 280);
            this.btnActualizarConsulta.Name = "btnActualizarConsulta";
            this.btnActualizarConsulta.Size = new System.Drawing.Size(115, 49);
            this.btnActualizarConsulta.TabIndex = 29;
            this.btnActualizarConsulta.Text = "Actualizar Consulta";
            this.btnActualizarConsulta.UseVisualStyleBackColor = true;
            this.btnActualizarConsulta.Click += new System.EventHandler(this.btnActualizarConsulta_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(304, 280);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(115, 49);
            this.btnLimpiarDatos.TabIndex = 28;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnGuardarConsulta
            // 
            this.btnGuardarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConsulta.Location = new System.Drawing.Point(549, 280);
            this.btnGuardarConsulta.Name = "btnGuardarConsulta";
            this.btnGuardarConsulta.Size = new System.Drawing.Size(115, 49);
            this.btnGuardarConsulta.TabIndex = 27;
            this.btnGuardarConsulta.Text = "Guardar Consulta";
            this.btnGuardarConsulta.UseVisualStyleBackColor = true;
            this.btnGuardarConsulta.Click += new System.EventHandler(this.btnGuardarConsulta_Click);
            // 
            // btnEliminarConsulta
            // 
            this.btnEliminarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConsulta.Location = new System.Drawing.Point(670, 280);
            this.btnEliminarConsulta.Name = "btnEliminarConsulta";
            this.btnEliminarConsulta.Size = new System.Drawing.Size(115, 49);
            this.btnEliminarConsulta.TabIndex = 30;
            this.btnEliminarConsulta.Text = "Eliminar Consulta";
            this.btnEliminarConsulta.UseVisualStyleBackColor = true;
            this.btnEliminarConsulta.Click += new System.EventHandler(this.btnEliminarConsulta_Click);
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
            // ABM_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 605);
            this.Controls.Add(this.btnEliminarConsulta);
            this.Controls.Add(this.btnActualizarConsulta);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnGuardarConsulta);
            this.Controls.Add(this.gridConsultas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtHistoriaClinica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.txtNumeroDoc);
            this.Controls.Add(this.lblNumeroDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtFechaEntrada;
        private System.Windows.Forms.TextBox txtIdConsulta;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox txtNumeroDoc;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.TextBox txtHistoriaClinica;
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
    }
}