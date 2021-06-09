
namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    partial class Reporte_Laboratorios
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
            this.reportViewerLabs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerLabs
            // 
            this.reportViewerLabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerLabs.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.reporteLaboratorios.rdlc";
            this.reportViewerLabs.Location = new System.Drawing.Point(0, 0);
            this.reportViewerLabs.Name = "reportViewerLabs";
            this.reportViewerLabs.ServerReport.BearerToken = null;
            this.reportViewerLabs.Size = new System.Drawing.Size(800, 450);
            this.reportViewerLabs.TabIndex = 0;
            this.reportViewerLabs.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Reporte_Laboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerLabs);
            this.Name = "Reporte_Laboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Laboratorios";
            this.Load += new System.EventHandler(this.Reporte_Laboratorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLabs;
    }
}