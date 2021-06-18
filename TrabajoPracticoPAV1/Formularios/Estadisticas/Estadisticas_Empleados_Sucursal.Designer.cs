
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class Estadisticas_Empleados_Sucursal
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
            this.rpEmpleadoSucursal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpEmpleadoSucursal
            // 
            this.rpEmpleadoSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpEmpleadoSucursal.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportEmpleadoSucursal.rdlc";
            this.rpEmpleadoSucursal.Location = new System.Drawing.Point(0, 0);
            this.rpEmpleadoSucursal.Name = "rpEmpleadoSucursal";
            this.rpEmpleadoSucursal.ServerReport.BearerToken = null;
            this.rpEmpleadoSucursal.Size = new System.Drawing.Size(800, 450);
            this.rpEmpleadoSucursal.TabIndex = 0;
            this.rpEmpleadoSucursal.Load += new System.EventHandler(this.rpEmpleadoSucursal_Load);
            // 
            // Estadisticas_Empleados_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpEmpleadoSucursal);
            this.Name = "Estadisticas_Empleados_Sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados por Sucursal";
            this.Load += new System.EventHandler(this.Estadisticas_Empleados_Sucursal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpEmpleadoSucursal;
    }
}