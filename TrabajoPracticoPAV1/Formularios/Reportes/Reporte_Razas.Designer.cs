
namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    partial class Reporte_Razas
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
            this.reportViewerRazasHembras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerRazasMachos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerRazas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBoxReportesRazas = new System.Windows.Forms.GroupBox();
            this.rdbRazasCompleto = new System.Windows.Forms.RadioButton();
            this.rdbRazasMachos = new System.Windows.Forms.RadioButton();
            this.rdbRazasHembras = new System.Windows.Forms.RadioButton();
            this.btnFiltroReporte = new System.Windows.Forms.Button();
            this.groupBoxReportesRazas.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerRazasHembras
            // 
            this.reportViewerRazasHembras.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.ListadoDeRazasHembras.rdlc";
            this.reportViewerRazasHembras.Location = new System.Drawing.Point(-1, 58);
            this.reportViewerRazasHembras.Name = "reportViewerRazasHembras";
            this.reportViewerRazasHembras.ServerReport.BearerToken = null;
            this.reportViewerRazasHembras.Size = new System.Drawing.Size(942, 473);
            this.reportViewerRazasHembras.TabIndex = 0;
            this.reportViewerRazasHembras.Load += new System.EventHandler(this.reportViewerRazasHembras_Load);
            // 
            // reportViewerRazasMachos
            // 
            this.reportViewerRazasMachos.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.ListadoDeRazasMachos.rdlc";
            this.reportViewerRazasMachos.Location = new System.Drawing.Point(-1, 58);
            this.reportViewerRazasMachos.Name = "reportViewerRazasMachos";
            this.reportViewerRazasMachos.ServerReport.BearerToken = null;
            this.reportViewerRazasMachos.Size = new System.Drawing.Size(942, 473);
            this.reportViewerRazasMachos.TabIndex = 1;
            this.reportViewerRazasMachos.Load += new System.EventHandler(this.reportViewerRazasMachos_Load);
            // 
            // reportViewerRazas
            // 
            this.reportViewerRazas.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.ListadoDeRazasCompleto.rdlc";
            this.reportViewerRazas.Location = new System.Drawing.Point(-1, 58);
            this.reportViewerRazas.Name = "reportViewerRazas";
            this.reportViewerRazas.ServerReport.BearerToken = null;
            this.reportViewerRazas.Size = new System.Drawing.Size(942, 473);
            this.reportViewerRazas.TabIndex = 2;
            this.reportViewerRazas.Load += new System.EventHandler(this.reportViewerRazas_Load);
            // 
            // groupBoxReportesRazas
            // 
            this.groupBoxReportesRazas.Controls.Add(this.rdbRazasCompleto);
            this.groupBoxReportesRazas.Controls.Add(this.rdbRazasMachos);
            this.groupBoxReportesRazas.Controls.Add(this.rdbRazasHembras);
            this.groupBoxReportesRazas.Location = new System.Drawing.Point(39, 5);
            this.groupBoxReportesRazas.Name = "groupBoxReportesRazas";
            this.groupBoxReportesRazas.Size = new System.Drawing.Size(378, 47);
            this.groupBoxReportesRazas.TabIndex = 3;
            this.groupBoxReportesRazas.TabStop = false;
            this.groupBoxReportesRazas.Text = "Filtrar por sexos";
            // 
            // rdbRazasCompleto
            // 
            this.rdbRazasCompleto.AutoSize = true;
            this.rdbRazasCompleto.Location = new System.Drawing.Point(286, 20);
            this.rdbRazasCompleto.Name = "rdbRazasCompleto";
            this.rdbRazasCompleto.Size = new System.Drawing.Size(57, 17);
            this.rdbRazasCompleto.TabIndex = 2;
            this.rdbRazasCompleto.TabStop = true;
            this.rdbRazasCompleto.Text = "Ambos";
            this.rdbRazasCompleto.UseVisualStyleBackColor = true;
            // 
            // rdbRazasMachos
            // 
            this.rdbRazasMachos.AutoSize = true;
            this.rdbRazasMachos.Location = new System.Drawing.Point(175, 20);
            this.rdbRazasMachos.Name = "rdbRazasMachos";
            this.rdbRazasMachos.Size = new System.Drawing.Size(93, 17);
            this.rdbRazasMachos.TabIndex = 1;
            this.rdbRazasMachos.TabStop = true;
            this.rdbRazasMachos.Text = "Datos machos";
            this.rdbRazasMachos.UseVisualStyleBackColor = true;
            // 
            // rdbRazasHembras
            // 
            this.rdbRazasHembras.AutoSize = true;
            this.rdbRazasHembras.Location = new System.Drawing.Point(47, 19);
            this.rdbRazasHembras.Name = "rdbRazasHembras";
            this.rdbRazasHembras.Size = new System.Drawing.Size(96, 17);
            this.rdbRazasHembras.TabIndex = 0;
            this.rdbRazasHembras.TabStop = true;
            this.rdbRazasHembras.Text = "Datos hembras";
            this.rdbRazasHembras.UseVisualStyleBackColor = true;
            // 
            // btnFiltroReporte
            // 
            this.btnFiltroReporte.Location = new System.Drawing.Point(439, 21);
            this.btnFiltroReporte.Name = "btnFiltroReporte";
            this.btnFiltroReporte.Size = new System.Drawing.Size(70, 23);
            this.btnFiltroReporte.TabIndex = 4;
            this.btnFiltroReporte.Text = "Cargar";
            this.btnFiltroReporte.UseVisualStyleBackColor = true;
            this.btnFiltroReporte.Click += new System.EventHandler(this.btnFiltroReporte_Click);
            // 
            // Reporte_Razas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 531);
            this.Controls.Add(this.btnFiltroReporte);
            this.Controls.Add(this.groupBoxReportesRazas);
            this.Controls.Add(this.reportViewerRazas);
            this.Controls.Add(this.reportViewerRazasMachos);
            this.Controls.Add(this.reportViewerRazasHembras);
            this.Name = "Reporte_Razas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Razas";
            this.Load += new System.EventHandler(this.Reporte_Razas_Load);
            this.groupBoxReportesRazas.ResumeLayout(false);
            this.groupBoxReportesRazas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRazasHembras;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRazasMachos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRazas;
        private System.Windows.Forms.GroupBox groupBoxReportesRazas;
        private System.Windows.Forms.RadioButton rdbRazasCompleto;
        private System.Windows.Forms.RadioButton rdbRazasMachos;
        private System.Windows.Forms.RadioButton rdbRazasHembras;
        private System.Windows.Forms.Button btnFiltroReporte;
    }
}