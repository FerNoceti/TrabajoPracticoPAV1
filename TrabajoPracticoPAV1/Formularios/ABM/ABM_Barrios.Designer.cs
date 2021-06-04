
namespace TrabajoPracticoPAV1.Formularios.ABM
{
    partial class ABM_Barrios
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
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbBarrios = new System.Windows.Forms.Label();
            this.gdrBarrios = new System.Windows.Forms.DataGridView();
            this.btnActualizarBarrio = new System.Windows.Forms.Button();
            this.btnAgregarBarrio = new System.Windows.Forms.Button();
            this.btnEliminarBarrio = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(120, 90);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(280, 29);
            this.cmbCiudad.TabIndex = 36;
            // 
            // txtDescripción
            // 
            this.txtDescripción.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescripción.Location = new System.Drawing.Point(120, 130);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(280, 100);
            this.txtDescripción.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNombre.Location = new System.Drawing.Point(120, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 27);
            this.txtNombre.TabIndex = 34;
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbCiudad.Location = new System.Drawing.Point(10, 90);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(63, 18);
            this.lbCiudad.TabIndex = 33;
            this.lbCiudad.Text = "Ciudad";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbDescripcion.Location = new System.Drawing.Point(10, 130);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(97, 18);
            this.lbDescripcion.TabIndex = 32;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbNombre.Location = new System.Drawing.Point(10, 50);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(68, 18);
            this.lbNombre.TabIndex = 31;
            this.lbNombre.Text = "Nombre";
            // 
            // lbBarrios
            // 
            this.lbBarrios.AutoSize = true;
            this.lbBarrios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbBarrios.Location = new System.Drawing.Point(10, 10);
            this.lbBarrios.Name = "lbBarrios";
            this.lbBarrios.Size = new System.Drawing.Size(57, 18);
            this.lbBarrios.TabIndex = 30;
            this.lbBarrios.Text = "Barrios";
            // 
            // gdrBarrios
            // 
            this.gdrBarrios.AllowUserToAddRows = false;
            this.gdrBarrios.AllowUserToDeleteRows = false;
            this.gdrBarrios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gdrBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrBarrios.Location = new System.Drawing.Point(410, 10);
            this.gdrBarrios.Name = "gdrBarrios";
            this.gdrBarrios.ReadOnly = true;
            this.gdrBarrios.RowHeadersWidth = 51;
            this.gdrBarrios.Size = new System.Drawing.Size(442, 300);
            this.gdrBarrios.TabIndex = 29;
            this.gdrBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrBarrios_CellClick);
            // 
            // btnActualizarBarrio
            // 
            this.btnActualizarBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnActualizarBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarBarrio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnActualizarBarrio.Location = new System.Drawing.Point(10, 280);
            this.btnActualizarBarrio.Name = "btnActualizarBarrio";
            this.btnActualizarBarrio.Size = new System.Drawing.Size(200, 30);
            this.btnActualizarBarrio.TabIndex = 28;
            this.btnActualizarBarrio.Text = "Actualizar";
            this.btnActualizarBarrio.UseVisualStyleBackColor = false;
            this.btnActualizarBarrio.Click += new System.EventHandler(this.btnActualizarBarrio_Click);
            // 
            // btnAgregarBarrio
            // 
            this.btnAgregarBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnAgregarBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBarrio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAgregarBarrio.Location = new System.Drawing.Point(10, 240);
            this.btnAgregarBarrio.Name = "btnAgregarBarrio";
            this.btnAgregarBarrio.Size = new System.Drawing.Size(390, 30);
            this.btnAgregarBarrio.TabIndex = 27;
            this.btnAgregarBarrio.Text = "Agregar";
            this.btnAgregarBarrio.UseVisualStyleBackColor = false;
            this.btnAgregarBarrio.Click += new System.EventHandler(this.btnAgregarBarrio_Click);
            // 
            // btnEliminarBarrio
            // 
            this.btnEliminarBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.btnEliminarBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBarrio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEliminarBarrio.Location = new System.Drawing.Point(220, 280);
            this.btnEliminarBarrio.Name = "btnEliminarBarrio";
            this.btnEliminarBarrio.Size = new System.Drawing.Size(177, 30);
            this.btnEliminarBarrio.TabIndex = 26;
            this.btnEliminarBarrio.Text = "Borrar";
            this.btnEliminarBarrio.UseVisualStyleBackColor = false;
            this.btnEliminarBarrio.Click += new System.EventHandler(this.btnEliminarBarrio_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtId.Location = new System.Drawing.Point(120, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(280, 30);
            this.txtId.TabIndex = 38;
            this.txtId.Text = "";
            this.txtId.Visible = false;
            // 
            // ABM_Barrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(856, 326);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbBarrios);
            this.Controls.Add(this.gdrBarrios);
            this.Controls.Add(this.btnActualizarBarrio);
            this.Controls.Add(this.btnAgregarBarrio);
            this.Controls.Add(this.btnEliminarBarrio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ABM_Barrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Barrios";
            this.Load += new System.EventHandler(this.ABM_Barrios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbBarrios;
        private System.Windows.Forms.DataGridView gdrBarrios;
        private System.Windows.Forms.Button btnActualizarBarrio;
        private System.Windows.Forms.Button btnAgregarBarrio;
        private System.Windows.Forms.Button btnEliminarBarrio;
        private System.Windows.Forms.RichTextBox txtId;
    }
}