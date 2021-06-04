
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Vacunas
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
            this.gridVacunas = new System.Windows.Forms.DataGridView();
            this.Id_Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbVacunas = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarVacuna = new System.Windows.Forms.Button();
            this.btnBorrarVacuna = new System.Windows.Forms.Button();
            this.btnAgregarVacuna = new System.Windows.Forms.Button();
            this.txtDescipcionVacuna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDosisVacuna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreVacuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumIdVacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVacunas)).BeginInit();
            this.gpbVacunas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridVacunas
            // 
            this.gridVacunas.AllowUserToAddRows = false;
            this.gridVacunas.AllowUserToDeleteRows = false;
            this.gridVacunas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Vacuna,
            this.Descripcion,
            this.Nombre_Vacuna,
            this.Dosis});
            this.gridVacunas.Location = new System.Drawing.Point(360, 30);
            this.gridVacunas.Name = "gridVacunas";
            this.gridVacunas.ReadOnly = true;
            this.gridVacunas.RowHeadersVisible = false;
            this.gridVacunas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridVacunas.Size = new System.Drawing.Size(440, 310);
            this.gridVacunas.TabIndex = 3;
            this.gridVacunas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVacunas_CellClick);
            // 
            // Id_Vacuna
            // 
            this.Id_Vacuna.DataPropertyName = "Id";
            this.Id_Vacuna.HeaderText = "ID";
            this.Id_Vacuna.Name = "Id_Vacuna";
            this.Id_Vacuna.ReadOnly = true;
            this.Id_Vacuna.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Nombre_Vacuna
            // 
            this.Nombre_Vacuna.DataPropertyName = "Nombre";
            this.Nombre_Vacuna.HeaderText = "Nombre";
            this.Nombre_Vacuna.Name = "Nombre_Vacuna";
            this.Nombre_Vacuna.ReadOnly = true;
            this.Nombre_Vacuna.Width = 130;
            // 
            // Dosis
            // 
            this.Dosis.DataPropertyName = "Dosis";
            this.Dosis.HeaderText = "Dosis (ml)";
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // gpbVacunas
            // 
            this.gpbVacunas.Controls.Add(this.btnLimpiarCampos);
            this.gpbVacunas.Controls.Add(this.btnActualizarVacuna);
            this.gpbVacunas.Controls.Add(this.btnBorrarVacuna);
            this.gpbVacunas.Controls.Add(this.btnAgregarVacuna);
            this.gpbVacunas.Controls.Add(this.txtDescipcionVacuna);
            this.gpbVacunas.Controls.Add(this.label4);
            this.gpbVacunas.Controls.Add(this.txtDosisVacuna);
            this.gpbVacunas.Controls.Add(this.label3);
            this.gpbVacunas.Controls.Add(this.txtNombreVacuna);
            this.gpbVacunas.Controls.Add(this.label2);
            this.gpbVacunas.Controls.Add(this.txtNumIdVacuna);
            this.gpbVacunas.Controls.Add(this.label1);
            this.gpbVacunas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gpbVacunas.Location = new System.Drawing.Point(10, 20);
            this.gpbVacunas.Name = "gpbVacunas";
            this.gpbVacunas.Size = new System.Drawing.Size(340, 320);
            this.gpbVacunas.TabIndex = 2;
            this.gpbVacunas.TabStop = false;
            this.gpbVacunas.Text = "Datos de la Vacuna";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(10, 270);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(310, 40);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarVacuna
            // 
            this.btnActualizarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnActualizarVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarVacuna.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarVacuna.Location = new System.Drawing.Point(170, 210);
            this.btnActualizarVacuna.Name = "btnActualizarVacuna";
            this.btnActualizarVacuna.Size = new System.Drawing.Size(150, 50);
            this.btnActualizarVacuna.TabIndex = 10;
            this.btnActualizarVacuna.Text = "Actualizar Datos Vacuna";
            this.btnActualizarVacuna.UseVisualStyleBackColor = false;
            this.btnActualizarVacuna.Click += new System.EventHandler(this.btnActualizarVacuna_Click);
            // 
            // btnBorrarVacuna
            // 
            this.btnBorrarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnBorrarVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarVacuna.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrarVacuna.Location = new System.Drawing.Point(10, 210);
            this.btnBorrarVacuna.Name = "btnBorrarVacuna";
            this.btnBorrarVacuna.Size = new System.Drawing.Size(150, 50);
            this.btnBorrarVacuna.TabIndex = 9;
            this.btnBorrarVacuna.Text = "Dar de Baja Vacuna";
            this.btnBorrarVacuna.UseVisualStyleBackColor = false;
            this.btnBorrarVacuna.Click += new System.EventHandler(this.btnBorrarVacuna_Click);
            // 
            // btnAgregarVacuna
            // 
            this.btnAgregarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnAgregarVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVacuna.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarVacuna.Location = new System.Drawing.Point(10, 160);
            this.btnAgregarVacuna.Name = "btnAgregarVacuna";
            this.btnAgregarVacuna.Size = new System.Drawing.Size(310, 40);
            this.btnAgregarVacuna.TabIndex = 8;
            this.btnAgregarVacuna.Text = "Agregar Vacuna";
            this.btnAgregarVacuna.UseVisualStyleBackColor = false;
            this.btnAgregarVacuna.Click += new System.EventHandler(this.btnAgregarVacuna_Click);
            // 
            // txtDescipcionVacuna
            // 
            this.txtDescipcionVacuna.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtDescipcionVacuna.Location = new System.Drawing.Point(130, 130);
            this.txtDescipcionVacuna.Name = "txtDescipcionVacuna";
            this.txtDescipcionVacuna.Size = new System.Drawing.Size(186, 26);
            this.txtDescipcionVacuna.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion:";
            // 
            // txtDosisVacuna
            // 
            this.txtDosisVacuna.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtDosisVacuna.Location = new System.Drawing.Point(130, 100);
            this.txtDosisVacuna.Name = "txtDosisVacuna";
            this.txtDosisVacuna.Size = new System.Drawing.Size(186, 26);
            this.txtDosisVacuna.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dosis (en ml):";
            // 
            // txtNombreVacuna
            // 
            this.txtNombreVacuna.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNombreVacuna.Location = new System.Drawing.Point(130, 70);
            this.txtNombreVacuna.Name = "txtNombreVacuna";
            this.txtNombreVacuna.Size = new System.Drawing.Size(186, 26);
            this.txtNombreVacuna.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNumIdVacuna
            // 
            this.txtNumIdVacuna.Enabled = false;
            this.txtNumIdVacuna.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNumIdVacuna.Location = new System.Drawing.Point(130, 30);
            this.txtNumIdVacuna.Name = "txtNumIdVacuna";
            this.txtNumIdVacuna.Size = new System.Drawing.Size(45, 26);
            this.txtNumIdVacuna.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de ID:";
            // 
            // ABM_Vacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(814, 345);
            this.Controls.Add(this.gridVacunas);
            this.Controls.Add(this.gpbVacunas);
            this.Name = "ABM_Vacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Vacunas";
            this.Load += new System.EventHandler(this.ABM_Vacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVacunas)).EndInit();
            this.gpbVacunas.ResumeLayout(false);
            this.gpbVacunas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVacunas;
        private System.Windows.Forms.GroupBox gpbVacunas;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarVacuna;
        private System.Windows.Forms.Button btnBorrarVacuna;
        private System.Windows.Forms.Button btnAgregarVacuna;
        private System.Windows.Forms.TextBox txtDescipcionVacuna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDosisVacuna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreVacuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumIdVacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
    }
}