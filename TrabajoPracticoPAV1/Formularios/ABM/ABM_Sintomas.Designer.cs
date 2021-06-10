
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Sintomas
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvSintomas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSintoma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarSint = new System.Windows.Forms.Button();
            this.btnActualizarSint = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreSintoma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintomas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtId.Location = new System.Drawing.Point(90, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 26);
            this.txtId.TabIndex = 34;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(10, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 18);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "Id:";
            // 
            // dgvSintomas
            // 
            this.dgvSintomas.AllowUserToAddRows = false;
            this.dgvSintomas.AllowUserToDeleteRows = false;
            this.dgvSintomas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSintomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreSintoma});
            this.dgvSintomas.Location = new System.Drawing.Point(260, 10);
            this.dgvSintomas.Name = "dgvSintomas";
            this.dgvSintomas.ReadOnly = true;
            this.dgvSintomas.RowHeadersVisible = false;
            this.dgvSintomas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSintomas.Size = new System.Drawing.Size(200, 260);
            this.dgvSintomas.TabIndex = 32;
            this.dgvSintomas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSintomas_CellClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NombreSintoma
            // 
            this.NombreSintoma.DataPropertyName = "NombreSintoma";
            this.NombreSintoma.HeaderText = "Nombre sintoma";
            this.NombreSintoma.Name = "NombreSintoma";
            this.NombreSintoma.ReadOnly = true;
            // 
            // btnGuardarSint
            // 
            this.btnGuardarSint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnGuardarSint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardarSint.Location = new System.Drawing.Point(10, 150);
            this.btnGuardarSint.Name = "btnGuardarSint";
            this.btnGuardarSint.Size = new System.Drawing.Size(230, 35);
            this.btnGuardarSint.TabIndex = 30;
            this.btnGuardarSint.Text = "Guardar sintoma";
            this.btnGuardarSint.UseVisualStyleBackColor = false;
            this.btnGuardarSint.Click += new System.EventHandler(this.btnGuardarSint_Click);
            // 
            // btnActualizarSint
            // 
            this.btnActualizarSint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnActualizarSint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarSint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarSint.Location = new System.Drawing.Point(10, 190);
            this.btnActualizarSint.Name = "btnActualizarSint";
            this.btnActualizarSint.Size = new System.Drawing.Size(230, 35);
            this.btnActualizarSint.TabIndex = 29;
            this.btnActualizarSint.Text = "Actualizar sintoma";
            this.btnActualizarSint.UseVisualStyleBackColor = false;
            this.btnActualizarSint.Click += new System.EventHandler(this.btnActualizarSint_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarDatos.Location = new System.Drawing.Point(10, 230);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(230, 35);
            this.btnLimpiarDatos.TabIndex = 28;
            this.btnLimpiarDatos.Text = "Limpiar datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(80, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "ABM Sintomas";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNombre.Location = new System.Drawing.Point(90, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 26);
            this.txtNombre.TabIndex = 38;
            // 
            // lblNombreSintoma
            // 
            this.lblNombreSintoma.AutoSize = true;
            this.lblNombreSintoma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNombreSintoma.Location = new System.Drawing.Point(10, 80);
            this.lblNombreSintoma.Name = "lblNombreSintoma";
            this.lblNombreSintoma.Size = new System.Drawing.Size(68, 18);
            this.lblNombreSintoma.TabIndex = 37;
            this.lblNombreSintoma.Text = "Nombre";
            // 
            // ABM_Sintomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(471, 286);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreSintoma);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvSintomas);
            this.Controls.Add(this.btnGuardarSint);
            this.Controls.Add(this.btnActualizarSint);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.label5);
            this.Name = "ABM_Sintomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Sintomas";
            this.Load += new System.EventHandler(this.ABM_Sintomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvSintomas;
        private System.Windows.Forms.Button btnGuardarSint;
        private System.Windows.Forms.Button btnActualizarSint;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreSintoma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSintoma;
    }
}