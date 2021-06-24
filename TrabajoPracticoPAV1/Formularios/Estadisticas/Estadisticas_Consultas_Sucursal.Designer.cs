
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class Estadisticas_Consultas_Sucursal
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
            this.reportConsultasPorSucursal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportConsultasPorSucursal
            // 
            this.reportConsultasPorSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportConsultasPorSucursal.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportConsultasSucursal.rdlc";
            this.reportConsultasPorSucursal.Location = new System.Drawing.Point(0, 0);
            this.reportConsultasPorSucursal.Name = "reportConsultasPorSucursal";
            this.reportConsultasPorSucursal.ServerReport.BearerToken = null;
            this.reportConsultasPorSucursal.Size = new System.Drawing.Size(800, 450);
            this.reportConsultasPorSucursal.TabIndex = 0;
            this.reportConsultasPorSucursal.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Estadisticas_Consultas_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportConsultasPorSucursal);
            this.Name = "Estadisticas_Consultas_Sucursal";
            this.Text = "Estadisticas Consultas por sucursal";
            this.Load += new System.EventHandler(this.Estadisticas_Consultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportConsultasPorSucursal;
    }
}