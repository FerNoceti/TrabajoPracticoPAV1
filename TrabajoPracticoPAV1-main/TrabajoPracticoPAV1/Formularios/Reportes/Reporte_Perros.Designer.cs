
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
            this.SuspendLayout();
            // 
            // rvPerros
            // 
            this.rvPerros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvPerros.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.ListadoPerros.rdlc";
            this.rvPerros.Location = new System.Drawing.Point(0, 0);
            this.rvPerros.Name = "rvPerros";
            this.rvPerros.ServerReport.BearerToken = null;
            this.rvPerros.Size = new System.Drawing.Size(905, 341);
            this.rvPerros.TabIndex = 0;
            this.rvPerros.Load += new System.EventHandler(this.rvPerros_Load);
            // 
            // Reporte_Perros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 341);
            this.Controls.Add(this.rvPerros);
            this.Name = "Reporte_Perros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePerros";
            this.Load += new System.EventHandler(this.Reporte_Perros_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPerros;
    }
}