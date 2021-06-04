
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Medicamentos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_nom_medicamento = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lbl_lab = new System.Windows.Forms.Label();
            this.cbLab = new System.Windows.Forms.ComboBox();
            this.lbl_Fecha_ult_compra = new System.Windows.Forms.Label();
            this.lbl_agregarMedic = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_cantmin = new System.Windows.Forms.Label();
            this.cbTipoM = new System.Windows.Forms.ComboBox();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.lbl_tipomed = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.gdrMedicamentos = new System.Windows.Forms.DataGridView();
            this.btnGuardarMedicamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtCantMin = new System.Windows.Forms.MaskedTextBox();
            this.btnActualizarMed = new System.Windows.Forms.Button();
            this.btnBorrarMed = new System.Windows.Forms.Button();
            this.txtIdMed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarDatosMed = new System.Windows.Forms.Button();
            this.txtUltimaCompra2 = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_min_x_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nom_medicamento
            // 
            this.lbl_nom_medicamento.AutoSize = true;
            this.lbl_nom_medicamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_nom_medicamento.Location = new System.Drawing.Point(10, 90);
            this.lbl_nom_medicamento.Name = "lbl_nom_medicamento";
            this.lbl_nom_medicamento.Size = new System.Drawing.Size(177, 18);
            this.lbl_nom_medicamento.TabIndex = 0;
            this.lbl_nom_medicamento.Text = "Nombre Medicamento";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNombreM.Location = new System.Drawing.Point(190, 90);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(119, 26);
            this.txtNombreM.TabIndex = 1;
            // 
            // lbl_lab
            // 
            this.lbl_lab.AutoSize = true;
            this.lbl_lab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_lab.Location = new System.Drawing.Point(10, 240);
            this.lbl_lab.Name = "lbl_lab";
            this.lbl_lab.Size = new System.Drawing.Size(180, 18);
            this.lbl_lab.TabIndex = 2;
            this.lbl_lab.Text = "Rzon. Scial. Laboratorio";
            // 
            // cbLab
            // 
            this.cbLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLab.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbLab.FormattingEnabled = true;
            this.cbLab.Location = new System.Drawing.Point(191, 242);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(140, 28);
            this.cbLab.TabIndex = 3;
            // 
            // lbl_Fecha_ult_compra
            // 
            this.lbl_Fecha_ult_compra.AutoSize = true;
            this.lbl_Fecha_ult_compra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Fecha_ult_compra.Location = new System.Drawing.Point(11, 202);
            this.lbl_Fecha_ult_compra.Name = "lbl_Fecha_ult_compra";
            this.lbl_Fecha_ult_compra.Size = new System.Drawing.Size(119, 18);
            this.lbl_Fecha_ult_compra.TabIndex = 4;
            this.lbl_Fecha_ult_compra.Text = "Ultima Compra";
            // 
            // lbl_agregarMedic
            // 
            this.lbl_agregarMedic.AutoSize = true;
            this.lbl_agregarMedic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_agregarMedic.Location = new System.Drawing.Point(90, 10);
            this.lbl_agregarMedic.Name = "lbl_agregarMedic";
            this.lbl_agregarMedic.Size = new System.Drawing.Size(178, 18);
            this.lbl_agregarMedic.TabIndex = 5;
            this.lbl_agregarMedic.Text = "Agregar Medicamento";
            // 
            // lbl_cantmin
            // 
            this.lbl_cantmin.AutoSize = true;
            this.lbl_cantmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_cantmin.Location = new System.Drawing.Point(10, 170);
            this.lbl_cantmin.Name = "lbl_cantmin";
            this.lbl_cantmin.Size = new System.Drawing.Size(170, 18);
            this.lbl_cantmin.TabIndex = 8;
            this.lbl_cantmin.Text = "Cant.Min. Por Sucursal";
            // 
            // cbTipoM
            // 
            this.cbTipoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoM.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbTipoM.FormattingEnabled = true;
            this.cbTipoM.Location = new System.Drawing.Point(190, 120);
            this.cbTipoM.Name = "cbTipoM";
            this.cbTipoM.Size = new System.Drawing.Size(114, 28);
            this.cbTipoM.TabIndex = 10;
            // 
            // cbUnidad
            // 
            this.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidad.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(191, 272);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(140, 28);
            this.cbUnidad.TabIndex = 11;
            // 
            // lbl_tipomed
            // 
            this.lbl_tipomed.AutoSize = true;
            this.lbl_tipomed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_tipomed.Location = new System.Drawing.Point(10, 121);
            this.lbl_tipomed.Name = "lbl_tipomed";
            this.lbl_tipomed.Size = new System.Drawing.Size(147, 18);
            this.lbl_tipomed.TabIndex = 12;
            this.lbl_tipomed.Text = "Tipo Medicamento";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_unidad.Location = new System.Drawing.Point(10, 270);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(151, 18);
            this.lbl_unidad.TabIndex = 13;
            this.lbl_unidad.Text = "Unidad de medida:";
            // 
            // gdrMedicamentos
            // 
            this.gdrMedicamentos.AllowUserToAddRows = false;
            this.gdrMedicamentos.AllowUserToDeleteRows = false;
            this.gdrMedicamentos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdrMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.TipoMedicamento,
            this.Precio,
            this.Laboratorio,
            this.Unidad_medida,
            this.UltimaCompra,
            this.Cant_min_x_sucursal});
            this.gdrMedicamentos.Location = new System.Drawing.Point(350, 10);
            this.gdrMedicamentos.Name = "gdrMedicamentos";
            this.gdrMedicamentos.ReadOnly = true;
            this.gdrMedicamentos.RowHeadersVisible = false;
            this.gdrMedicamentos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gdrMedicamentos.Size = new System.Drawing.Size(750, 450);
            this.gdrMedicamentos.TabIndex = 14;
            this.gdrMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrMedicamentos_CellClick);
            // 
            // btnGuardarMedicamento
            // 
            this.btnGuardarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnGuardarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMedicamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardarMedicamento.Location = new System.Drawing.Point(10, 350);
            this.btnGuardarMedicamento.Name = "btnGuardarMedicamento";
            this.btnGuardarMedicamento.Size = new System.Drawing.Size(330, 30);
            this.btnGuardarMedicamento.TabIndex = 15;
            this.btnGuardarMedicamento.Text = "Guardar";
            this.btnGuardarMedicamento.UseVisualStyleBackColor = false;
            this.btnGuardarMedicamento.Click += new System.EventHandler(this.btnGuardarMedicamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtPrecio.Location = new System.Drawing.Point(191, 312);
            this.txtPrecio.Mask = "999999999";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 26);
            this.txtPrecio.TabIndex = 18;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // txtCantMin
            // 
            this.txtCantMin.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtCantMin.Location = new System.Drawing.Point(191, 172);
            this.txtCantMin.Mask = "999999999";
            this.txtCantMin.Name = "txtCantMin";
            this.txtCantMin.Size = new System.Drawing.Size(114, 26);
            this.txtCantMin.TabIndex = 19;
            this.txtCantMin.ValidatingType = typeof(int);
            // 
            // btnActualizarMed
            // 
            this.btnActualizarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnActualizarMed.Enabled = false;
            this.btnActualizarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarMed.Location = new System.Drawing.Point(10, 390);
            this.btnActualizarMed.Name = "btnActualizarMed";
            this.btnActualizarMed.Size = new System.Drawing.Size(160, 30);
            this.btnActualizarMed.TabIndex = 20;
            this.btnActualizarMed.Text = "Actualizar";
            this.btnActualizarMed.UseVisualStyleBackColor = false;
            this.btnActualizarMed.Click += new System.EventHandler(this.btnActualizarMed_Click);
            // 
            // btnBorrarMed
            // 
            this.btnBorrarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnBorrarMed.Enabled = false;
            this.btnBorrarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarMed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrarMed.Location = new System.Drawing.Point(180, 390);
            this.btnBorrarMed.Name = "btnBorrarMed";
            this.btnBorrarMed.Size = new System.Drawing.Size(160, 30);
            this.btnBorrarMed.TabIndex = 21;
            this.btnBorrarMed.Text = "Borrar";
            this.btnBorrarMed.UseVisualStyleBackColor = false;
            this.btnBorrarMed.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtIdMed
            // 
            this.txtIdMed.Enabled = false;
            this.txtIdMed.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtIdMed.Location = new System.Drawing.Point(40, 50);
            this.txtIdMed.Name = "txtIdMed";
            this.txtIdMed.Size = new System.Drawing.Size(30, 26);
            this.txtIdMed.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id:";
            // 
            // btnLimpiarDatosMed
            // 
            this.btnLimpiarDatosMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnLimpiarDatosMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatosMed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDatosMed.Location = new System.Drawing.Point(10, 430);
            this.btnLimpiarDatosMed.Name = "btnLimpiarDatosMed";
            this.btnLimpiarDatosMed.Size = new System.Drawing.Size(330, 30);
            this.btnLimpiarDatosMed.TabIndex = 24;
            this.btnLimpiarDatosMed.Text = "Limpiar Datos";
            this.btnLimpiarDatosMed.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosMed.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // txtUltimaCompra2
            // 
            this.txtUltimaCompra2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtUltimaCompra2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtUltimaCompra2.Location = new System.Drawing.Point(191, 202);
            this.txtUltimaCompra2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtUltimaCompra2.Name = "txtUltimaCompra2";
            this.txtUltimaCompra2.Size = new System.Drawing.Size(114, 26);
            this.txtUltimaCompra2.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Descripcion";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TipoMedicamento
            // 
            this.TipoMedicamento.DataPropertyName = "IdTipoMedicamento";
            this.TipoMedicamento.HeaderText = "Tipo medicamento";
            this.TipoMedicamento.Name = "TipoMedicamento";
            this.TipoMedicamento.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Laboratorio
            // 
            this.Laboratorio.DataPropertyName = "IdLaboratorio";
            this.Laboratorio.HeaderText = "Id Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.ReadOnly = true;
            // 
            // Unidad_medida
            // 
            this.Unidad_medida.DataPropertyName = "IdUnidadMedida";
            this.Unidad_medida.HeaderText = "Unidad de medida";
            this.Unidad_medida.Name = "Unidad_medida";
            this.Unidad_medida.ReadOnly = true;
            // 
            // UltimaCompra
            // 
            this.UltimaCompra.DataPropertyName = "FechaUltimaCompra";
            this.UltimaCompra.HeaderText = "Ultima Compra";
            this.UltimaCompra.Name = "UltimaCompra";
            this.UltimaCompra.ReadOnly = true;
            // 
            // Cant_min_x_sucursal
            // 
            this.Cant_min_x_sucursal.DataPropertyName = "CantidadMinimaxSucursal";
            this.Cant_min_x_sucursal.HeaderText = "Cant minima por sucursal";
            this.Cant_min_x_sucursal.Name = "Cant_min_x_sucursal";
            this.Cant_min_x_sucursal.ReadOnly = true;
            // 
            // ABM_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1108, 465);
            this.Controls.Add(this.txtUltimaCompra2);
            this.Controls.Add(this.btnLimpiarDatosMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMed);
            this.Controls.Add(this.btnBorrarMed);
            this.Controls.Add(this.btnActualizarMed);
            this.Controls.Add(this.txtCantMin);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarMedicamento);
            this.Controls.Add(this.gdrMedicamentos);
            this.Controls.Add(this.lbl_unidad);
            this.Controls.Add(this.lbl_tipomed);
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.cbTipoM);
            this.Controls.Add(this.lbl_cantmin);
            this.Controls.Add(this.lbl_agregarMedic);
            this.Controls.Add(this.lbl_Fecha_ult_compra);
            this.Controls.Add(this.cbLab);
            this.Controls.Add(this.lbl_lab);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.lbl_nom_medicamento);
            this.Name = "ABM_Medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar medicamentos";
            this.Load += new System.EventHandler(this.ABM_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom_medicamento;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label lbl_lab;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.Label lbl_Fecha_ult_compra;
        private System.Windows.Forms.Label lbl_agregarMedic;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_cantmin;
        private System.Windows.Forms.ComboBox cbTipoM;
        private System.Windows.Forms.ComboBox cbUnidad;
        private System.Windows.Forms.Label lbl_tipomed;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.DataGridView gdrMedicamentos;
        private System.Windows.Forms.Button btnGuardarMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox txtCantMin;
        private System.Windows.Forms.Button btnActualizarMed;
        private System.Windows.Forms.Button btnBorrarMed;
        private System.Windows.Forms.TextBox txtIdMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarDatosMed;
        private System.Windows.Forms.DateTimePicker txtUltimaCompra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_min_x_sucursal;
    }
}