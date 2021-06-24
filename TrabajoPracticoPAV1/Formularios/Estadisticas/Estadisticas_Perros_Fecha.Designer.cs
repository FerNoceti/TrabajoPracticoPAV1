
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class Estadisticas_Perros_Fecha
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
            this.rpPerrosXFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpPerrosXFecha
            // 
            this.rpPerrosXFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpPerrosXFecha.DocumentMapWidth = 78;
            this.rpPerrosXFecha.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportPerrosFecha.rdlc";
            this.rpPerrosXFecha.Location = new System.Drawing.Point(0, 0);
            this.rpPerrosXFecha.Name = "rpPerrosXFecha";
            this.rpPerrosXFecha.ServerReport.BearerToken = null;
            this.rpPerrosXFecha.Size = new System.Drawing.Size(800, 450);
            this.rpPerrosXFecha.TabIndex = 0;
            this.rpPerrosXFecha.Load += new System.EventHandler(this.rpPerrosXFecha_Load);
            // 
            // Estadisticas_Perros_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpPerrosXFecha);
            this.Name = "Estadisticas_Perros_Fecha";
            this.Text = "Estadisticas_Perros_Fecha";
            this.Load += new System.EventHandler(this.Estadisticas_Perros_Fecha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpPerrosXFecha;
    }
}