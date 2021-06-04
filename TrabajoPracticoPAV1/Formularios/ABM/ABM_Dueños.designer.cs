
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Dueños
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbDueños = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarDueño = new System.Windows.Forms.Button();
            this.btnBorrarDueño = new System.Windows.Forms.Button();
            this.btnAgregarDueño = new System.Windows.Forms.Button();
            this.txtTelefonoDueño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoDueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumIdDueño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDueños = new System.Windows.Forms.DataGridView();
            this.Id_Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDueños.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDueños)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDueños
            // 
            this.gpbDueños.Controls.Add(this.btnLimpiarCampos);
            this.gpbDueños.Controls.Add(this.btnActualizarDueño);
            this.gpbDueños.Controls.Add(this.btnBorrarDueño);
            this.gpbDueños.Controls.Add(this.btnAgregarDueño);
            this.gpbDueños.Controls.Add(this.txtTelefonoDueño);
            this.gpbDueños.Controls.Add(this.label4);
            this.gpbDueños.Controls.Add(this.txtApellidoDueño);
            this.gpbDueños.Controls.Add(this.label3);
            this.gpbDueños.Controls.Add(this.txtNombreDueño);
            this.gpbDueños.Controls.Add(this.label2);
            this.gpbDueños.Controls.Add(this.txtNumIdDueño);
            this.gpbDueños.Controls.Add(this.label1);
            this.gpbDueños.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gpbDueños.Location = new System.Drawing.Point(10, 10);
            this.gpbDueños.Name = "gpbDueños";
            this.gpbDueños.Size = new System.Drawing.Size(370, 270);
            this.gpbDueños.TabIndex = 0;
            this.gpbDueños.TabStop = false;
            this.gpbDueños.Text = "Datos del Dueño";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.Location = new System.Drawing.Point(10, 230);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(350, 30);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarDueño
            // 
            this.btnActualizarDueño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnActualizarDueño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDueño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarDueño.Location = new System.Drawing.Point(190, 190);
            this.btnActualizarDueño.Name = "btnActualizarDueño";
            this.btnActualizarDueño.Size = new System.Drawing.Size(170, 30);
            this.btnActualizarDueño.TabIndex = 10;
            this.btnActualizarDueño.Text = "Actualizar Datos Dueño";
            this.btnActualizarDueño.UseVisualStyleBackColor = false;
            this.btnActualizarDueño.Click += new System.EventHandler(this.btnActualizarDueño_Click);
            // 
            // btnBorrarDueño
            // 
            this.btnBorrarDueño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnBorrarDueño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarDueño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrarDueño.Location = new System.Drawing.Point(10, 190);
            this.btnBorrarDueño.Name = "btnBorrarDueño";
            this.btnBorrarDueño.Size = new System.Drawing.Size(170, 30);
            this.btnBorrarDueño.TabIndex = 9;
            this.btnBorrarDueño.Text = "Dar de Baja Dueño";
            this.btnBorrarDueño.UseVisualStyleBackColor = false;
            this.btnBorrarDueño.Click += new System.EventHandler(this.btnBorrarDueño_Click);
            // 
            // btnAgregarDueño
            // 
            this.btnAgregarDueño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnAgregarDueño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDueño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDueño.Location = new System.Drawing.Point(10, 150);
            this.btnAgregarDueño.Name = "btnAgregarDueño";
            this.btnAgregarDueño.Size = new System.Drawing.Size(350, 30);
            this.btnAgregarDueño.TabIndex = 8;
            this.btnAgregarDueño.Text = "Agregar Dueño";
            this.btnAgregarDueño.UseVisualStyleBackColor = false;
            this.btnAgregarDueño.Click += new System.EventHandler(this.btnAgregarDueño_Click);
            // 
            // txtTelefonoDueño
            // 
            this.txtTelefonoDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoDueño.Location = new System.Drawing.Point(170, 110);
            this.txtTelefonoDueño.Name = "txtTelefonoDueño";
            this.txtTelefonoDueño.Size = new System.Drawing.Size(190, 26);
            this.txtTelefonoDueño.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número de Telefono:";
            // 
            // txtApellidoDueño
            // 
            this.txtApellidoDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoDueño.Location = new System.Drawing.Point(170, 80);
            this.txtApellidoDueño.Name = "txtApellidoDueño";
            this.txtApellidoDueño.Size = new System.Drawing.Size(190, 26);
            this.txtApellidoDueño.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDueño.Location = new System.Drawing.Point(170, 50);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(190, 26);
            this.txtNombreDueño.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNumIdDueño
            // 
            this.txtNumIdDueño.Enabled = false;
            this.txtNumIdDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumIdDueño.Location = new System.Drawing.Point(170, 20);
            this.txtNumIdDueño.Name = "txtNumIdDueño";
            this.txtNumIdDueño.Size = new System.Drawing.Size(190, 26);
            this.txtNumIdDueño.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de ID:";
            // 
            // gridDueños
            // 
            this.gridDueños.AllowUserToAddRows = false;
            this.gridDueños.AllowUserToDeleteRows = false;
            this.gridDueños.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDueños.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDueños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Dueño,
            this.Nombre_Dueño,
            this.Apellido_Dueño,
            this.Telefono_Dueño});
            this.gridDueños.Location = new System.Drawing.Point(390, 10);
            this.gridDueños.Name = "gridDueños";
            this.gridDueños.ReadOnly = true;
            this.gridDueños.RowHeadersVisible = false;
            this.gridDueños.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridDueños.Size = new System.Drawing.Size(570, 270);
            this.gridDueños.TabIndex = 1;
            this.gridDueños.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDueños_CellClick);
            this.gridDueños.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDueños_CellContentClick);
            // 
            // Id_Dueño
            // 
            this.Id_Dueño.DataPropertyName = "Id";
            this.Id_Dueño.HeaderText = "ID";
            this.Id_Dueño.Name = "Id_Dueño";
            this.Id_Dueño.ReadOnly = true;
            this.Id_Dueño.Width = 75;
            // 
            // Nombre_Dueño
            // 
            this.Nombre_Dueño.DataPropertyName = "Nombre";
            this.Nombre_Dueño.HeaderText = "Nombre";
            this.Nombre_Dueño.Name = "Nombre_Dueño";
            this.Nombre_Dueño.ReadOnly = true;
            this.Nombre_Dueño.Width = 175;
            // 
            // Apellido_Dueño
            // 
            this.Apellido_Dueño.DataPropertyName = "Apellido";
            this.Apellido_Dueño.HeaderText = "Apellido";
            this.Apellido_Dueño.Name = "Apellido_Dueño";
            this.Apellido_Dueño.ReadOnly = true;
            this.Apellido_Dueño.Width = 175;
            // 
            // Telefono_Dueño
            // 
            this.Telefono_Dueño.DataPropertyName = "Telefono";
            this.Telefono_Dueño.HeaderText = "Telefono";
            this.Telefono_Dueño.Name = "Telefono_Dueño";
            this.Telefono_Dueño.ReadOnly = true;
            this.Telefono_Dueño.Width = 149;
            // 
            // ABM_Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(975, 291);
            this.Controls.Add(this.gridDueños);
            this.Controls.Add(this.gpbDueños);
            this.Name = "ABM_Dueños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dueños";
            this.Load += new System.EventHandler(this.ABM_Dueños_Load);
            this.gpbDueños.ResumeLayout(false);
            this.gpbDueños.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDueños)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDueños;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarDueño;
        private System.Windows.Forms.Button btnBorrarDueño;
        private System.Windows.Forms.Button btnAgregarDueño;
        private System.Windows.Forms.TextBox txtTelefonoDueño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoDueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumIdDueño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDueños;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Dueño;
    }
}