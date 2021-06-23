
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class Estadisticas_Ingresos_Sucursal
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
            this.rpIngresosSucursal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpIngresosSucursal
            // 
            this.rpIngresosSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpIngresosSucursal.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportIngresosSucursal.rdlc";
            this.rpIngresosSucursal.Location = new System.Drawing.Point(0, 0);
            this.rpIngresosSucursal.Name = "rpIngresosSucursal";
            this.rpIngresosSucursal.ServerReport.BearerToken = null;
            this.rpIngresosSucursal.Size = new System.Drawing.Size(800, 450);
            this.rpIngresosSucursal.TabIndex = 0;
            this.rpIngresosSucursal.Load += new System.EventHandler(this.rpingresosSucursal_Load);
            // 
            // Estadisticas_Ingresos_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpIngresosSucursal);
            this.Name = "Estadisticas_Ingresos_Sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas_Ingresos_Sucursal";
            this.Load += new System.EventHandler(this.Estadisticas_Ingresos_Sucursal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpIngresosSucursal;
    }
}