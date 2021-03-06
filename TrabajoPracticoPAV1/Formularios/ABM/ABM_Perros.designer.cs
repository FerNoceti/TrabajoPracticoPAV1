
namespace TrabajoPracticoPAV1
{
    partial class ABM_Perros
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
            this.lblNombrePerro = new System.Windows.Forms.Label();
            this.txtNombrePerro = new System.Windows.Forms.TextBox();
            this.lblRazaPerro = new System.Windows.Forms.Label();
            this.lblPesoPerro = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.cmbDueño = new System.Windows.Forms.ComboBox();
            this.lblAlturaPerro = new System.Windows.Forms.Label();
            this.lblSexoPerro = new System.Windows.Forms.Label();
            this.lblDueño = new System.Windows.Forms.Label();
            this.txtPesoPerro = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdHembra = new System.Windows.Forms.RadioButton();
            this.rdMacho = new System.Windows.Forms.RadioButton();
            this.txtAlturaPerro = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarPerro = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.gdrPerros = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroHistoriaClinica = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPerros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePerro
            // 
            this.lblNombrePerro.AutoSize = true;
            this.lblNombrePerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNombrePerro.Location = new System.Drawing.Point(10, 10);
            this.lblNombrePerro.Name = "lblNombrePerro";
            this.lblNombrePerro.Size = new System.Drawing.Size(73, 18);
            this.lblNombrePerro.TabIndex = 0;
            this.lblNombrePerro.Text = "Nombre:";
            // 
            // txtNombrePerro
            // 
            this.txtNombrePerro.Location = new System.Drawing.Point(90, 10);
            this.txtNombrePerro.Name = "txtNombrePerro";
            this.txtNombrePerro.Size = new System.Drawing.Size(127, 20);
            this.txtNombrePerro.TabIndex = 1;
            // 
            // lblRazaPerro
            // 
            this.lblRazaPerro.AutoSize = true;
            this.lblRazaPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblRazaPerro.Location = new System.Drawing.Point(10, 40);
            this.lblRazaPerro.Name = "lblRazaPerro";
            this.lblRazaPerro.Size = new System.Drawing.Size(52, 18);
            this.lblRazaPerro.TabIndex = 2;
            this.lblRazaPerro.Text = "Raza:";
            // 
            // lblPesoPerro
            // 
            this.lblPesoPerro.AutoSize = true;
            this.lblPesoPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPesoPerro.Location = new System.Drawing.Point(10, 140);
            this.lblPesoPerro.Name = "lblPesoPerro";
            this.lblPesoPerro.Size = new System.Drawing.Size(84, 18);
            this.lblPesoPerro.TabIndex = 4;
            this.lblPesoPerro.Text = "Peso(Kg):";
            // 
            // cmbRaza
            // 
            this.cmbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(90, 36);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(127, 21);
            this.cmbRaza.TabIndex = 5;
            // 
            // cmbDueño
            // 
            this.cmbDueño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDueño.FormattingEnabled = true;
            this.cmbDueño.Location = new System.Drawing.Point(400, 70);
            this.cmbDueño.Name = "cmbDueño";
            this.cmbDueño.Size = new System.Drawing.Size(127, 21);
            this.cmbDueño.TabIndex = 9;
            // 
            // lblAlturaPerro
            // 
            this.lblAlturaPerro.AutoSize = true;
            this.lblAlturaPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAlturaPerro.Location = new System.Drawing.Point(10, 170);
            this.lblAlturaPerro.Name = "lblAlturaPerro";
            this.lblAlturaPerro.Size = new System.Drawing.Size(96, 18);
            this.lblAlturaPerro.TabIndex = 8;
            this.lblAlturaPerro.Text = "Altura (cm):";
            // 
            // lblSexoPerro
            // 
            this.lblSexoPerro.AutoSize = true;
            this.lblSexoPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSexoPerro.Location = new System.Drawing.Point(10, 70);
            this.lblSexoPerro.Name = "lblSexoPerro";
            this.lblSexoPerro.Size = new System.Drawing.Size(51, 18);
            this.lblSexoPerro.TabIndex = 6;
            this.lblSexoPerro.Text = "Sexo:";
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDueño.Location = new System.Drawing.Point(240, 70);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(62, 18);
            this.lblDueño.TabIndex = 10;
            this.lblDueño.Text = "Dueño:";
            // 
            // txtPesoPerro
            // 
            this.txtPesoPerro.Location = new System.Drawing.Point(110, 140);
            this.txtPesoPerro.Mask = "999";
            this.txtPesoPerro.Name = "txtPesoPerro";
            this.txtPesoPerro.Size = new System.Drawing.Size(39, 20);
            this.txtPesoPerro.TabIndex = 11;
            this.txtPesoPerro.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdHembra);
            this.panel1.Controls.Add(this.rdMacho);
            this.panel1.Location = new System.Drawing.Point(90, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 55);
            this.panel1.TabIndex = 12;
            // 
            // rdHembra
            // 
            this.rdHembra.AutoSize = true;
            this.rdHembra.Location = new System.Drawing.Point(15, 26);
            this.rdHembra.Name = "rdHembra";
            this.rdHembra.Size = new System.Drawing.Size(62, 17);
            this.rdHembra.TabIndex = 14;
            this.rdHembra.TabStop = true;
            this.rdHembra.Text = "Hembra";
            this.rdHembra.UseVisualStyleBackColor = true;
            // 
            // rdMacho
            // 
            this.rdMacho.AutoSize = true;
            this.rdMacho.Location = new System.Drawing.Point(15, 3);
            this.rdMacho.Name = "rdMacho";
            this.rdMacho.Size = new System.Drawing.Size(58, 17);
            this.rdMacho.TabIndex = 13;
            this.rdMacho.TabStop = true;
            this.rdMacho.Text = "Macho";
            this.rdMacho.UseVisualStyleBackColor = true;
            // 
            // txtAlturaPerro
            // 
            this.txtAlturaPerro.Location = new System.Drawing.Point(110, 170);
            this.txtAlturaPerro.Mask = "999";
            this.txtAlturaPerro.Name = "txtAlturaPerro";
            this.txtAlturaPerro.Size = new System.Drawing.Size(40, 20);
            this.txtAlturaPerro.TabIndex = 13;
            // 
            // btnGuardarPerro
            // 
            this.btnGuardarPerro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnGuardarPerro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPerro.Location = new System.Drawing.Point(10, 200);
            this.btnGuardarPerro.Name = "btnGuardarPerro";
            this.btnGuardarPerro.Size = new System.Drawing.Size(250, 30);
            this.btnGuardarPerro.TabIndex = 14;
            this.btnGuardarPerro.Text = "Guardar Datos";
            this.btnGuardarPerro.UseVisualStyleBackColor = false;
            this.btnGuardarPerro.Click += new System.EventHandler(this.btnGuardarPerro_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(280, 200);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(250, 30);
            this.btnLimpiarCampos.TabIndex = 15;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(400, 100);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(127, 21);
            this.cmbSucursal.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(240, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(240, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha Nacimiento:";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(400, 10);
            this.txtFechaNac.Mask = "00/00/0000";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(76, 20);
            this.txtFechaNac.TabIndex = 20;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // gdrPerros
            // 
            this.gdrPerros.AllowUserToAddRows = false;
            this.gdrPerros.AllowUserToDeleteRows = false;
            this.gdrPerros.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gdrPerros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPerros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Peso,
            this.Altura});
            this.gdrPerros.Location = new System.Drawing.Point(540, 0);
            this.gdrPerros.Name = "gdrPerros";
            this.gdrPerros.ReadOnly = true;
            this.gdrPerros.RowHeadersVisible = false;
            this.gdrPerros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gdrPerros.Size = new System.Drawing.Size(300, 230);
            this.gdrPerros.TabIndex = 21;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 50;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "Altura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(240, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nro. Historia clinica:";
            // 
            // txtNroHistoriaClinica
            // 
            this.txtNroHistoriaClinica.Location = new System.Drawing.Point(400, 40);
            this.txtNroHistoriaClinica.Name = "txtNroHistoriaClinica";
            this.txtNroHistoriaClinica.Size = new System.Drawing.Size(76, 20);
            this.txtNroHistoriaClinica.TabIndex = 23;
            // 
            // ABM_Perros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(850, 246);
            this.Controls.Add(this.txtNroHistoriaClinica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gdrPerros);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarPerro);
            this.Controls.Add(this.txtAlturaPerro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPesoPerro);
            this.Controls.Add(this.lblDueño);
            this.Controls.Add(this.cmbDueño);
            this.Controls.Add(this.lblAlturaPerro);
            this.Controls.Add(this.lblSexoPerro);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.lblPesoPerro);
            this.Controls.Add(this.lblRazaPerro);
            this.Controls.Add(this.txtNombrePerro);
            this.Controls.Add(this.lblNombrePerro);
            this.MaximizeBox = false;
            this.Name = "ABM_Perros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de perros";
            this.Load += new System.EventHandler(this.ABM_Perros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPerros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePerro;
        private System.Windows.Forms.TextBox txtNombrePerro;
        private System.Windows.Forms.Label lblRazaPerro;
        private System.Windows.Forms.Label lblPesoPerro;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.ComboBox cmbDueño;
        private System.Windows.Forms.Label lblAlturaPerro;
        private System.Windows.Forms.Label lblSexoPerro;
        private System.Windows.Forms.Label lblDueño;
        private System.Windows.Forms.MaskedTextBox txtPesoPerro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdHembra;
        private System.Windows.Forms.RadioButton rdMacho;
        private System.Windows.Forms.MaskedTextBox txtAlturaPerro;
        private System.Windows.Forms.Button btnGuardarPerro;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.DataGridView gdrPerros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
    }
}