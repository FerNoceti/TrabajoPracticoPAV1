
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class Estadisticas_Perros_Razas
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
            this.reportViewer_Razas_Machos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFiltroEstadistica = new System.Windows.Forms.Button();
            this.groupBoxReportesRazas = new System.Windows.Forms.GroupBox();
            this.rdbCompleto = new System.Windows.Forms.RadioButton();
            this.rdbMachos = new System.Windows.Forms.RadioButton();
            this.rdbHembra = new System.Windows.Forms.RadioButton();
            this.reportViewerRazas_Hembras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerRazas_ambos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBoxReportesRazas.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer_Razas_Machos
            // 
            this.reportViewer_Razas_Machos.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.PerrosXRaza_M.rdlc";
            this.reportViewer_Razas_Machos.Location = new System.Drawing.Point(1, 80);
            this.reportViewer_Razas_Machos.Name = "reportViewer_Razas_Machos";
            this.reportViewer_Razas_Machos.ServerReport.BearerToken = null;
            this.reportViewer_Razas_Machos.Size = new System.Drawing.Size(802, 371);
            this.reportViewer_Razas_Machos.TabIndex = 0;
            this.reportViewer_Razas_Machos.Load += new System.EventHandler(this.reportViewer_Razas_Machos_Load_1);
            // 
            // btnFiltroEstadistica
            // 
            this.btnFiltroEstadistica.Location = new System.Drawing.Point(434, 43);
            this.btnFiltroEstadistica.Name = "btnFiltroEstadistica";
            this.btnFiltroEstadistica.Size = new System.Drawing.Size(70, 23);
            this.btnFiltroEstadistica.TabIndex = 6;
            this.btnFiltroEstadistica.Text = "Cargar";
            this.btnFiltroEstadistica.UseVisualStyleBackColor = true;
            this.btnFiltroEstadistica.Click += new System.EventHandler(this.btnFiltroEstadistica_Click);
            // 
            // groupBoxReportesRazas
            // 
            this.groupBoxReportesRazas.Controls.Add(this.rdbCompleto);
            this.groupBoxReportesRazas.Controls.Add(this.rdbMachos);
            this.groupBoxReportesRazas.Controls.Add(this.rdbHembra);
            this.groupBoxReportesRazas.Location = new System.Drawing.Point(34, 26);
            this.groupBoxReportesRazas.Name = "groupBoxReportesRazas";
            this.groupBoxReportesRazas.Size = new System.Drawing.Size(378, 48);
            this.groupBoxReportesRazas.TabIndex = 5;
            this.groupBoxReportesRazas.TabStop = false;
            this.groupBoxReportesRazas.Text = "Filtrar por sexos";
            // 
            // rdbCompleto
            // 
            this.rdbCompleto.AutoSize = true;
            this.rdbCompleto.Location = new System.Drawing.Point(286, 20);
            this.rdbCompleto.Name = "rdbCompleto";
            this.rdbCompleto.Size = new System.Drawing.Size(57, 17);
            this.rdbCompleto.TabIndex = 2;
            this.rdbCompleto.TabStop = true;
            this.rdbCompleto.Text = "Ambos";
            this.rdbCompleto.UseVisualStyleBackColor = true;
            // 
            // rdbMachos
            // 
            this.rdbMachos.AutoSize = true;
            this.rdbMachos.Location = new System.Drawing.Point(175, 20);
            this.rdbMachos.Name = "rdbMachos";
            this.rdbMachos.Size = new System.Drawing.Size(95, 17);
            this.rdbMachos.TabIndex = 1;
            this.rdbMachos.TabStop = true;
            this.rdbMachos.Text = "Perros machos";
            this.rdbMachos.UseVisualStyleBackColor = true;
            // 
            // rdbHembra
            // 
            this.rdbHembra.AutoSize = true;
            this.rdbHembra.Location = new System.Drawing.Point(47, 19);
            this.rdbHembra.Name = "rdbHembra";
            this.rdbHembra.Size = new System.Drawing.Size(98, 17);
            this.rdbHembra.TabIndex = 0;
            this.rdbHembra.TabStop = true;
            this.rdbHembra.Text = "Perros hembras";
            this.rdbHembra.UseVisualStyleBackColor = true;
            // 
            // reportViewerRazas_Hembras
            // 
            this.reportViewerRazas_Hembras.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.PerrosXRaza_H.rdlc";
            this.reportViewerRazas_Hembras.Location = new System.Drawing.Point(1, 80);
            this.reportViewerRazas_Hembras.Name = "reportViewerRazas_Hembras";
            this.reportViewerRazas_Hembras.ServerReport.BearerToken = null;
            this.reportViewerRazas_Hembras.Size = new System.Drawing.Size(806, 371);
            this.reportViewerRazas_Hembras.TabIndex = 7;
            this.reportViewerRazas_Hembras.Load += new System.EventHandler(this.reportViewerRazas_Hembras_Load_1);
            // 
            // reportViewerRazas_ambos
            // 
            this.reportViewerRazas_ambos.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.PerrosXRaza.rdlc";
            this.reportViewerRazas_ambos.Location = new System.Drawing.Point(1, 80);
            this.reportViewerRazas_ambos.Name = "reportViewerRazas_ambos";
            this.reportViewerRazas_ambos.ServerReport.BearerToken = null;
            this.reportViewerRazas_ambos.Size = new System.Drawing.Size(806, 371);
            this.reportViewerRazas_ambos.TabIndex = 8;
            this.reportViewerRazas_ambos.Load += new System.EventHandler(this.reportViewerRazas_ambos_Load);
            // 
            // Estadisticas_Perros_Razas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerRazas_ambos);
            this.Controls.Add(this.reportViewerRazas_Hembras);
            this.Controls.Add(this.btnFiltroEstadistica);
            this.Controls.Add(this.groupBoxReportesRazas);
            this.Controls.Add(this.reportViewer_Razas_Machos);
            this.Name = "Estadisticas_Perros_Razas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas perros por razas";
            this.Load += new System.EventHandler(this.Estadisticas_Perros_Razas_Load);
            this.groupBoxReportesRazas.ResumeLayout(false);
            this.groupBoxReportesRazas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Razas_Machos;
        private System.Windows.Forms.Button btnFiltroEstadistica;
        private System.Windows.Forms.GroupBox groupBoxReportesRazas;
        private System.Windows.Forms.RadioButton rdbCompleto;
        private System.Windows.Forms.RadioButton rdbMachos;
        private System.Windows.Forms.RadioButton rdbHembra;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRazas_Hembras;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRazas_ambos;
    }
}