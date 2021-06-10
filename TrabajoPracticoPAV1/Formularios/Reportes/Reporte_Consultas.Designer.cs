
namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    partial class Reporte_Consultas
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
            this.reportViewerConsultas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerConsultas
            // 
            this.reportViewerConsultas.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.Consultas.ReportConsultas.rdlc";
            this.reportViewerConsultas.Location = new System.Drawing.Point(12, 108);
            this.reportViewerConsultas.Name = "reportViewerConsultas";
            this.reportViewerConsultas.ServerReport.BearerToken = null;
            this.reportViewerConsultas.Size = new System.Drawing.Size(991, 498);
            this.reportViewerConsultas.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(873, 32);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(130, 30);
            this.btnGenerarReporte.TabIndex = 8;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(873, 68);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(130, 30);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Combo";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(15, 42);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(150, 21);
            this.cmbSucursal.TabIndex = 3;
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(64, 22);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(48, 13);
            this.lbSucursal.TabIndex = 4;
            this.lbSucursal.Text = "Sucursal";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lbSucursal);
            this.gbFiltros.Controls.Add(this.cmbSucursal);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(846, 90);
            this.gbFiltros.TabIndex = 10;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // Reporte_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 618);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.reportViewerConsultas);
            this.MinimizeBox = false;
            this.Name = "Reporte_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteConsultas";
            this.Load += new System.EventHandler(this.Reporte_Consultas_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerConsultas;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.GroupBox gbFiltros;
    }
}