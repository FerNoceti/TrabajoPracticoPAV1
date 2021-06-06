
namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    partial class Reporte_Empleados
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
            this.rvEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.gbEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // rvEmpleados
            // 
            this.rvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvEmpleados.Location = new System.Drawing.Point(3, 16);
            this.rvEmpleados.Name = "rvEmpleados";
            this.rvEmpleados.ServerReport.BearerToken = null;
            this.rvEmpleados.Size = new System.Drawing.Size(774, 351);
            this.rvEmpleados.TabIndex = 0;
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.rvEmpleados);
            this.gbEmpleados.Location = new System.Drawing.Point(10, 70);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(780, 370);
            this.gbEmpleados.TabIndex = 1;
            this.gbEmpleados.TabStop = false;
            this.gbEmpleados.Text = "groupBox1";
            // 
            // Reporte_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEmpleados);
            this.Name = "Reporte_Empleados";
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.Reporte_Empleados_Load);
            this.gbEmpleados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEmpleados;
        private System.Windows.Forms.GroupBox gbEmpleados;
    }
}