
namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    partial class Reporte_Perros
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
            this.rvPerros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbRazas = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDueño = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rvPerros
            // 
            this.rvPerros.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.ListadoPerros.rdlc";
            this.rvPerros.Location = new System.Drawing.Point(153, 12);
            this.rvPerros.Name = "rvPerros";
            this.rvPerros.ServerReport.BearerToken = null;
            this.rvPerros.Size = new System.Drawing.Size(740, 317);
            this.rvPerros.TabIndex = 0;
            this.rvPerros.Load += new System.EventHandler(this.rvPerros_Load);
            // 
            // cmbRazas
            // 
            this.cmbRazas.FormattingEnabled = true;
            this.cmbRazas.Location = new System.Drawing.Point(12, 58);
            this.cmbRazas.Name = "cmbRazas";
            this.cmbRazas.Size = new System.Drawing.Size(110, 21);
            this.cmbRazas.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(21, 245);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(85, 44);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dueño";
            // 
            // cmbDueño
            // 
            this.cmbDueño.FormattingEnabled = true;
            this.cmbDueño.Location = new System.Drawing.Point(12, 134);
            this.cmbDueño.Name = "cmbDueño";
            this.cmbDueño.Size = new System.Drawing.Size(110, 21);
            this.cmbDueño.TabIndex = 5;
            // 
            // Reporte_Perros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 341);
            this.Controls.Add(this.cmbDueño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbRazas);
            this.Controls.Add(this.rvPerros);
            this.Name = "Reporte_Perros";
            this.Text = "ReportePerros";
            this.Load += new System.EventHandler(this.Reporte_Perros_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPerros;
        private System.Windows.Forms.ComboBox cmbRazas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDueño;
    }
}