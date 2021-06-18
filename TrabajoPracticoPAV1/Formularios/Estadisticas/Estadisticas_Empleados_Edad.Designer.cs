
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class Estadisticas_Empleados_Edad
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
            this.rpEmpleadoEdad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpEmpleadoEdad
            // 
            this.rpEmpleadoEdad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpEmpleadoEdad.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportEmpleadoEdad.rdlc";
            this.rpEmpleadoEdad.Location = new System.Drawing.Point(0, 0);
            this.rpEmpleadoEdad.Name = "rpEmpleadoEdad";
            this.rpEmpleadoEdad.ServerReport.BearerToken = null;
            this.rpEmpleadoEdad.Size = new System.Drawing.Size(800, 450);
            this.rpEmpleadoEdad.TabIndex = 0;
            this.rpEmpleadoEdad.Load += new System.EventHandler(this.rpEmpleadoEdad_Load);
            // 
            // Estadisticas_Empleados_Edad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpEmpleadoEdad);
            this.Name = "Estadisticas_Empleados_Edad";
            this.Text = "Estadisticas_Empleados_Matricula";
            this.Load += new System.EventHandler(this.Estadisticas_Empleados_Matricula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpEmpleadoEdad;
    }
}