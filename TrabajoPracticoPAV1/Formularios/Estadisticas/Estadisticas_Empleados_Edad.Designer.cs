
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
            this.gpReporteEmpleadoEdad = new System.Windows.Forms.GroupBox();
            this.cbPorRango = new System.Windows.Forms.CheckBox();
            this.txtCotaInferior = new System.Windows.Forms.MaskedTextBox();
            this.txtCotaSuperior = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lbCotaInferior = new System.Windows.Forms.Label();
            this.lbCotaSuperior = new System.Windows.Forms.Label();
            this.gpReporteEmpleadoEdad.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpEmpleadoEdad
            // 
            this.rpEmpleadoEdad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpEmpleadoEdad.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportEmpleadoEdad.rdlc";
            this.rpEmpleadoEdad.Location = new System.Drawing.Point(3, 16);
            this.rpEmpleadoEdad.Name = "rpEmpleadoEdad";
            this.rpEmpleadoEdad.ServerReport.BearerToken = null;
            this.rpEmpleadoEdad.Size = new System.Drawing.Size(794, 361);
            this.rpEmpleadoEdad.TabIndex = 0;
            this.rpEmpleadoEdad.Load += new System.EventHandler(this.rpEmpleadoEdad_Load);
            // 
            // gpReporteEmpleadoEdad
            // 
            this.gpReporteEmpleadoEdad.Controls.Add(this.rpEmpleadoEdad);
            this.gpReporteEmpleadoEdad.Location = new System.Drawing.Point(0, 70);
            this.gpReporteEmpleadoEdad.Name = "gpReporteEmpleadoEdad";
            this.gpReporteEmpleadoEdad.Size = new System.Drawing.Size(800, 380);
            this.gpReporteEmpleadoEdad.TabIndex = 1;
            this.gpReporteEmpleadoEdad.TabStop = false;
            this.gpReporteEmpleadoEdad.Text = "Reporte";
            // 
            // cbPorRango
            // 
            this.cbPorRango.AutoSize = true;
            this.cbPorRango.Location = new System.Drawing.Point(150, 30);
            this.cbPorRango.Name = "cbPorRango";
            this.cbPorRango.Size = new System.Drawing.Size(107, 30);
            this.cbPorRango.TabIndex = 2;
            this.cbPorRango.Text = "Buscar por rango\r\nde edad";
            this.cbPorRango.UseVisualStyleBackColor = true;
            this.cbPorRango.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtCotaInferior
            // 
            this.txtCotaInferior.Location = new System.Drawing.Point(290, 40);
            this.txtCotaInferior.Mask = "99";
            this.txtCotaInferior.Name = "txtCotaInferior";
            this.txtCotaInferior.Size = new System.Drawing.Size(40, 20);
            this.txtCotaInferior.TabIndex = 3;
            this.txtCotaInferior.ValidatingType = typeof(int);
            // 
            // txtCotaSuperior
            // 
            this.txtCotaSuperior.Location = new System.Drawing.Point(350, 40);
            this.txtCotaSuperior.Mask = "99";
            this.txtCotaSuperior.Name = "txtCotaSuperior";
            this.txtCotaSuperior.Size = new System.Drawing.Size(40, 20);
            this.txtCotaSuperior.TabIndex = 4;
            this.txtCotaSuperior.ValidatingType = typeof(int);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(420, 40);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Aplicar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lbCotaInferior
            // 
            this.lbCotaInferior.AutoSize = true;
            this.lbCotaInferior.Location = new System.Drawing.Point(290, 20);
            this.lbCotaInferior.Name = "lbCotaInferior";
            this.lbCotaInferior.Size = new System.Drawing.Size(37, 13);
            this.lbCotaInferior.TabIndex = 6;
            this.lbCotaInferior.Text = "Menor";
            // 
            // lbCotaSuperior
            // 
            this.lbCotaSuperior.AutoSize = true;
            this.lbCotaSuperior.Location = new System.Drawing.Point(350, 20);
            this.lbCotaSuperior.Name = "lbCotaSuperior";
            this.lbCotaSuperior.Size = new System.Drawing.Size(36, 13);
            this.lbCotaSuperior.TabIndex = 7;
            this.lbCotaSuperior.Text = "Mayor";
            // 
            // Estadisticas_Empleados_Edad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCotaSuperior);
            this.Controls.Add(this.lbCotaInferior);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtCotaSuperior);
            this.Controls.Add(this.txtCotaInferior);
            this.Controls.Add(this.cbPorRango);
            this.Controls.Add(this.gpReporteEmpleadoEdad);
            this.Name = "Estadisticas_Empleados_Edad";
            this.Text = "Estadisticas_Empleados_Matricula";
            this.Load += new System.EventHandler(this.Estadisticas_Empleados_Matricula_Load);
            this.gpReporteEmpleadoEdad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpEmpleadoEdad;
        private System.Windows.Forms.GroupBox gpReporteEmpleadoEdad;
        private System.Windows.Forms.CheckBox cbPorRango;
        private System.Windows.Forms.MaskedTextBox txtCotaInferior;
        private System.Windows.Forms.MaskedTextBox txtCotaSuperior;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lbCotaInferior;
        private System.Windows.Forms.Label lbCotaSuperior;
    }
}