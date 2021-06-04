
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Razas
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
            this.btnGuardarRaza = new System.Windows.Forms.Button();
            this.gdrRazas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_minimo_hembra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_maximo_hembra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_minimo_macho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_maximo_macho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlturaHembra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlturaMacho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantmin = new System.Windows.Forms.Label();
            this.lbl_lab = new System.Windows.Forms.Label();
            this.txtNombreRaza = new System.Windows.Forms.TextBox();
            this.lbl_nom_medicamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlturaHembra = new System.Windows.Forms.MaskedTextBox();
            this.txtAlturaMacho = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotaCuidados = new System.Windows.Forms.TextBox();
            this.btnLimpiarDatosRaz = new System.Windows.Forms.Button();
            this.btnBorrarRaz = new System.Windows.Forms.Button();
            this.btnActualizarRaz = new System.Windows.Forms.Button();
            this.txtPesoMinHembra = new System.Windows.Forms.TextBox();
            this.txtPesoMaxHembra = new System.Windows.Forms.TextBox();
            this.txtPesoMaxMacho = new System.Windows.Forms.TextBox();
            this.txtPesoMinMacho = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdRaz = new System.Windows.Forms.TextBox();
            this.gpbSexoHembra = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gpbSexoMacho = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_agregarMedic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrRazas)).BeginInit();
            this.gpbSexoHembra.SuspendLayout();
            this.gpbSexoMacho.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarRaza
            // 
            this.btnGuardarRaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnGuardarRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardarRaza.Location = new System.Drawing.Point(20, 460);
            this.btnGuardarRaza.Name = "btnGuardarRaza";
            this.btnGuardarRaza.Size = new System.Drawing.Size(290, 30);
            this.btnGuardarRaza.TabIndex = 33;
            this.btnGuardarRaza.Text = "Guardar";
            this.btnGuardarRaza.UseVisualStyleBackColor = false;
            this.btnGuardarRaza.Click += new System.EventHandler(this.btnGuardarRaza_Click);
            // 
            // gdrRazas
            // 
            this.gdrRazas.AllowUserToAddRows = false;
            this.gdrRazas.AllowUserToDeleteRows = false;
            this.gdrRazas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gdrRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrRazas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Peso_minimo_hembra,
            this.Peso_maximo_hembra,
            this.Peso_minimo_macho,
            this.Peso_maximo_macho,
            this.AlturaHembra,
            this.AlturaMacho,
            this.Nota});
            this.gdrRazas.Location = new System.Drawing.Point(320, 10);
            this.gdrRazas.Name = "gdrRazas";
            this.gdrRazas.ReadOnly = true;
            this.gdrRazas.RowHeadersVisible = false;
            this.gdrRazas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gdrRazas.Size = new System.Drawing.Size(770, 560);
            this.gdrRazas.TabIndex = 32;
            this.gdrRazas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrRazas_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 90;
            // 
            // Peso_minimo_hembra
            // 
            this.Peso_minimo_hembra.DataPropertyName = "PesoMinimoHembra";
            this.Peso_minimo_hembra.HeaderText = "Peso min hembra";
            this.Peso_minimo_hembra.Name = "Peso_minimo_hembra";
            this.Peso_minimo_hembra.ReadOnly = true;
            this.Peso_minimo_hembra.Width = 90;
            // 
            // Peso_maximo_hembra
            // 
            this.Peso_maximo_hembra.DataPropertyName = "PesoMaximoHembra";
            this.Peso_maximo_hembra.HeaderText = "Peso máx hembra";
            this.Peso_maximo_hembra.Name = "Peso_maximo_hembra";
            this.Peso_maximo_hembra.ReadOnly = true;
            this.Peso_maximo_hembra.Width = 90;
            // 
            // Peso_minimo_macho
            // 
            this.Peso_minimo_macho.DataPropertyName = "PesoMinimoMacho";
            this.Peso_minimo_macho.HeaderText = "Peso min macho";
            this.Peso_minimo_macho.Name = "Peso_minimo_macho";
            this.Peso_minimo_macho.ReadOnly = true;
            this.Peso_minimo_macho.Width = 90;
            // 
            // Peso_maximo_macho
            // 
            this.Peso_maximo_macho.DataPropertyName = "PesoMaximoMacho";
            this.Peso_maximo_macho.HeaderText = "Peso máx macho";
            this.Peso_maximo_macho.Name = "Peso_maximo_macho";
            this.Peso_maximo_macho.ReadOnly = true;
            this.Peso_maximo_macho.Width = 90;
            // 
            // AlturaHembra
            // 
            this.AlturaHembra.DataPropertyName = "AlturaMediaHembra";
            this.AlturaHembra.HeaderText = "Altura media hembra";
            this.AlturaHembra.Name = "AlturaHembra";
            this.AlturaHembra.ReadOnly = true;
            this.AlturaHembra.Width = 90;
            // 
            // AlturaMacho
            // 
            this.AlturaMacho.DataPropertyName = "AlturaMediaMacho";
            this.AlturaMacho.HeaderText = "Altura media macho";
            this.AlturaMacho.Name = "AlturaMacho";
            this.AlturaMacho.ReadOnly = true;
            this.AlturaMacho.Width = 90;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "NotaCuidados";
            this.Nota.HeaderText = "Nota Cuidados";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // lbl_cantmin
            // 
            this.lbl_cantmin.AutoSize = true;
            this.lbl_cantmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_cantmin.Location = new System.Drawing.Point(20, 110);
            this.lbl_cantmin.Name = "lbl_cantmin";
            this.lbl_cantmin.Size = new System.Drawing.Size(238, 18);
            this.lbl_cantmin.TabIndex = 27;
            this.lbl_cantmin.Text = "Notas de cuidados (Opcional):";
            // 
            // lbl_lab
            // 
            this.lbl_lab.AutoSize = true;
            this.lbl_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_lab.Location = new System.Drawing.Point(17, 26);
            this.lbl_lab.Name = "lbl_lab";
            this.lbl_lab.Size = new System.Drawing.Size(112, 18);
            this.lbl_lab.TabIndex = 22;
            this.lbl_lab.Text = "Peso mínimo:";
            // 
            // txtNombreRaza
            // 
            this.txtNombreRaza.Location = new System.Drawing.Point(20, 70);
            this.txtNombreRaza.Name = "txtNombreRaza";
            this.txtNombreRaza.Size = new System.Drawing.Size(280, 20);
            this.txtNombreRaza.TabIndex = 21;
            // 
            // lbl_nom_medicamento
            // 
            this.lbl_nom_medicamento.AutoSize = true;
            this.lbl_nom_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_nom_medicamento.Location = new System.Drawing.Point(20, 40);
            this.lbl_nom_medicamento.Name = "lbl_nom_medicamento";
            this.lbl_nom_medicamento.Size = new System.Drawing.Size(73, 18);
            this.lbl_nom_medicamento.TabIndex = 20;
            this.lbl_nom_medicamento.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Kilogramos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Kilogramos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Kilogramos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Kilogramos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Altura media:";
            // 
            // txtAlturaHembra
            // 
            this.txtAlturaHembra.Location = new System.Drawing.Point(136, 83);
            this.txtAlturaHembra.Mask = "99";
            this.txtAlturaHembra.Name = "txtAlturaHembra";
            this.txtAlturaHembra.Size = new System.Drawing.Size(42, 20);
            this.txtAlturaHembra.TabIndex = 51;
            this.txtAlturaHembra.ValidatingType = typeof(int);
            // 
            // txtAlturaMacho
            // 
            this.txtAlturaMacho.Location = new System.Drawing.Point(139, 83);
            this.txtAlturaMacho.Mask = "99";
            this.txtAlturaMacho.Name = "txtAlturaMacho";
            this.txtAlturaMacho.Size = new System.Drawing.Size(42, 20);
            this.txtAlturaMacho.TabIndex = 52;
            this.txtAlturaMacho.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Centímetros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "Centímetros";
            // 
            // txtNotaCuidados
            // 
            this.txtNotaCuidados.Location = new System.Drawing.Point(20, 130);
            this.txtNotaCuidados.Multiline = true;
            this.txtNotaCuidados.Name = "txtNotaCuidados";
            this.txtNotaCuidados.Size = new System.Drawing.Size(204, 50);
            this.txtNotaCuidados.TabIndex = 55;
            // 
            // btnLimpiarDatosRaz
            // 
            this.btnLimpiarDatosRaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnLimpiarDatosRaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatosRaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDatosRaz.Location = new System.Drawing.Point(20, 540);
            this.btnLimpiarDatosRaz.Name = "btnLimpiarDatosRaz";
            this.btnLimpiarDatosRaz.Size = new System.Drawing.Size(290, 30);
            this.btnLimpiarDatosRaz.TabIndex = 58;
            this.btnLimpiarDatosRaz.Text = "Limpiar Datos";
            this.btnLimpiarDatosRaz.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosRaz.Click += new System.EventHandler(this.btnLimpiarDatosRaz_Click);
            // 
            // btnBorrarRaz
            // 
            this.btnBorrarRaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnBorrarRaz.Enabled = false;
            this.btnBorrarRaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarRaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrarRaz.Location = new System.Drawing.Point(180, 500);
            this.btnBorrarRaz.Name = "btnBorrarRaz";
            this.btnBorrarRaz.Size = new System.Drawing.Size(130, 30);
            this.btnBorrarRaz.TabIndex = 57;
            this.btnBorrarRaz.Text = "Borrar";
            this.btnBorrarRaz.UseVisualStyleBackColor = false;
            this.btnBorrarRaz.Click += new System.EventHandler(this.btnBorrarRaz_Click);
            // 
            // btnActualizarRaz
            // 
            this.btnActualizarRaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnActualizarRaz.Enabled = false;
            this.btnActualizarRaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarRaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarRaz.Location = new System.Drawing.Point(20, 500);
            this.btnActualizarRaz.Name = "btnActualizarRaz";
            this.btnActualizarRaz.Size = new System.Drawing.Size(140, 30);
            this.btnActualizarRaz.TabIndex = 56;
            this.btnActualizarRaz.Text = "Actualizar";
            this.btnActualizarRaz.UseVisualStyleBackColor = false;
            this.btnActualizarRaz.Click += new System.EventHandler(this.btnActualizarRaz_Click);
            // 
            // txtPesoMinHembra
            // 
            this.txtPesoMinHembra.Location = new System.Drawing.Point(136, 26);
            this.txtPesoMinHembra.Name = "txtPesoMinHembra";
            this.txtPesoMinHembra.Size = new System.Drawing.Size(42, 20);
            this.txtPesoMinHembra.TabIndex = 59;
            this.txtPesoMinHembra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoMinHembra_KeyPress_1);
            // 
            // txtPesoMaxHembra
            // 
            this.txtPesoMaxHembra.Location = new System.Drawing.Point(136, 55);
            this.txtPesoMaxHembra.Name = "txtPesoMaxHembra";
            this.txtPesoMaxHembra.Size = new System.Drawing.Size(42, 20);
            this.txtPesoMaxHembra.TabIndex = 60;
            this.txtPesoMaxHembra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoMaxHembra_KeyPress);
            // 
            // txtPesoMaxMacho
            // 
            this.txtPesoMaxMacho.Location = new System.Drawing.Point(139, 54);
            this.txtPesoMaxMacho.Name = "txtPesoMaxMacho";
            this.txtPesoMaxMacho.Size = new System.Drawing.Size(42, 20);
            this.txtPesoMaxMacho.TabIndex = 61;
            this.txtPesoMaxMacho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoMaxMacho_KeyPress);
            // 
            // txtPesoMinMacho
            // 
            this.txtPesoMinMacho.Location = new System.Drawing.Point(139, 27);
            this.txtPesoMinMacho.Name = "txtPesoMinMacho";
            this.txtPesoMinMacho.Size = new System.Drawing.Size(42, 20);
            this.txtPesoMinMacho.TabIndex = 62;
            this.txtPesoMinMacho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoMinMacho_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Id:";
            // 
            // txtIdRaz
            // 
            this.txtIdRaz.Enabled = false;
            this.txtIdRaz.Location = new System.Drawing.Point(280, 40);
            this.txtIdRaz.Name = "txtIdRaz";
            this.txtIdRaz.Size = new System.Drawing.Size(25, 20);
            this.txtIdRaz.TabIndex = 63;
            // 
            // gpbSexoHembra
            // 
            this.gpbSexoHembra.Controls.Add(this.label12);
            this.gpbSexoHembra.Controls.Add(this.txtPesoMinHembra);
            this.gpbSexoHembra.Controls.Add(this.label1);
            this.gpbSexoHembra.Controls.Add(this.label2);
            this.gpbSexoHembra.Controls.Add(this.txtPesoMaxHembra);
            this.gpbSexoHembra.Controls.Add(this.lbl_lab);
            this.gpbSexoHembra.Controls.Add(this.label7);
            this.gpbSexoHembra.Controls.Add(this.txtAlturaHembra);
            this.gpbSexoHembra.Controls.Add(this.label9);
            this.gpbSexoHembra.Location = new System.Drawing.Point(20, 200);
            this.gpbSexoHembra.Name = "gpbSexoHembra";
            this.gpbSexoHembra.Size = new System.Drawing.Size(284, 121);
            this.gpbSexoHembra.TabIndex = 65;
            this.gpbSexoHembra.TabStop = false;
            this.gpbSexoHembra.Text = "Sexo: Hembra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(17, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 61;
            this.label12.Text = "Peso máximo:";
            // 
            // gpbSexoMacho
            // 
            this.gpbSexoMacho.Controls.Add(this.label16);
            this.gpbSexoMacho.Controls.Add(this.label14);
            this.gpbSexoMacho.Controls.Add(this.label15);
            this.gpbSexoMacho.Controls.Add(this.txtPesoMinMacho);
            this.gpbSexoMacho.Controls.Add(this.txtPesoMaxMacho);
            this.gpbSexoMacho.Controls.Add(this.txtAlturaMacho);
            this.gpbSexoMacho.Controls.Add(this.label10);
            this.gpbSexoMacho.Controls.Add(this.label4);
            this.gpbSexoMacho.Controls.Add(this.label3);
            this.gpbSexoMacho.Location = new System.Drawing.Point(20, 330);
            this.gpbSexoMacho.Name = "gpbSexoMacho";
            this.gpbSexoMacho.Size = new System.Drawing.Size(284, 121);
            this.gpbSexoMacho.TabIndex = 66;
            this.gpbSexoMacho.TabStop = false;
            this.gpbSexoMacho.Text = "Sexo: Macho";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(23, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 18);
            this.label16.TabIndex = 62;
            this.label16.Text = "Peso máximo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(22, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 18);
            this.label14.TabIndex = 62;
            this.label14.Text = "Peso mínimo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(22, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 63;
            this.label15.Text = "Altura media:";
            // 
            // lbl_agregarMedic
            // 
            this.lbl_agregarMedic.AutoSize = true;
            this.lbl_agregarMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agregarMedic.Location = new System.Drawing.Point(150, 0);
            this.lbl_agregarMedic.Name = "lbl_agregarMedic";
            this.lbl_agregarMedic.Size = new System.Drawing.Size(60, 20);
            this.lbl_agregarMedic.TabIndex = 25;
            this.lbl_agregarMedic.Text = "Razas";
            // 
            // ABM_Razas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1104, 588);
            this.Controls.Add(this.gpbSexoMacho);
            this.Controls.Add(this.gpbSexoHembra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIdRaz);
            this.Controls.Add(this.btnLimpiarDatosRaz);
            this.Controls.Add(this.btnBorrarRaz);
            this.Controls.Add(this.btnActualizarRaz);
            this.Controls.Add(this.txtNotaCuidados);
            this.Controls.Add(this.btnGuardarRaza);
            this.Controls.Add(this.gdrRazas);
            this.Controls.Add(this.lbl_cantmin);
            this.Controls.Add(this.lbl_agregarMedic);
            this.Controls.Add(this.txtNombreRaza);
            this.Controls.Add(this.lbl_nom_medicamento);
            this.Name = "ABM_Razas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar razas";
            this.Load += new System.EventHandler(this.ABM_Razas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrRazas)).EndInit();
            this.gpbSexoHembra.ResumeLayout(false);
            this.gpbSexoHembra.PerformLayout();
            this.gpbSexoMacho.ResumeLayout(false);
            this.gpbSexoMacho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarRaza;
        private System.Windows.Forms.DataGridView gdrRazas;
        private System.Windows.Forms.Label lbl_cantmin;
        private System.Windows.Forms.Label lbl_lab;
        private System.Windows.Forms.TextBox txtNombreRaza;
        private System.Windows.Forms.Label lbl_nom_medicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtAlturaHembra;
        private System.Windows.Forms.MaskedTextBox txtAlturaMacho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNotaCuidados;
        private System.Windows.Forms.Button btnLimpiarDatosRaz;
        private System.Windows.Forms.Button btnBorrarRaz;
        private System.Windows.Forms.Button btnActualizarRaz;
        private System.Windows.Forms.TextBox txtPesoMinHembra;
        private System.Windows.Forms.TextBox txtPesoMaxHembra;
        private System.Windows.Forms.TextBox txtPesoMaxMacho;
        private System.Windows.Forms.TextBox txtPesoMinMacho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdRaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_minimo_hembra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_maximo_hembra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_minimo_macho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_maximo_macho;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlturaHembra;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlturaMacho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.GroupBox gpbSexoHembra;
        private System.Windows.Forms.GroupBox gpbSexoMacho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_agregarMedic;
    }
}