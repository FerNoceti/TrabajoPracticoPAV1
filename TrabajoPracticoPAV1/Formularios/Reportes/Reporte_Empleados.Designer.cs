
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
            this.gbTipoEmpleado = new System.Windows.Forms.GroupBox();
            this.rbMatriculado = new System.Windows.Forms.RadioButton();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.gbEmpleados.SuspendLayout();
            this.gbTipoEmpleado.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // rvEmpleados
            // 
            this.rvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvEmpleados.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.Empleados.reportEmpleados.rdlc";
            this.rvEmpleados.Location = new System.Drawing.Point(3, 16);
            this.rvEmpleados.Name = "rvEmpleados";
            this.rvEmpleados.ServerReport.BearerToken = null;
            this.rvEmpleados.Size = new System.Drawing.Size(774, 411);
            this.rvEmpleados.TabIndex = 0;
            this.rvEmpleados.Load += new System.EventHandler(this.rvEmpleados_Load);
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.rvEmpleados);
            this.gbEmpleados.Location = new System.Drawing.Point(10, 120);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(780, 430);
            this.gbEmpleados.TabIndex = 1;
            this.gbEmpleados.TabStop = false;
            this.gbEmpleados.Text = "Reporte";
            // 
            // gbTipoEmpleado
            // 
            this.gbTipoEmpleado.Controls.Add(this.rbMatriculado);
            this.gbTipoEmpleado.Location = new System.Drawing.Point(20, 20);
            this.gbTipoEmpleado.Name = "gbTipoEmpleado";
            this.gbTipoEmpleado.Size = new System.Drawing.Size(120, 50);
            this.gbTipoEmpleado.TabIndex = 2;
            this.gbTipoEmpleado.TabStop = false;
            this.gbTipoEmpleado.Text = "TipoEmpleado";
            // 
            // rbMatriculado
            // 
            this.rbMatriculado.AutoSize = true;
            this.rbMatriculado.Location = new System.Drawing.Point(20, 20);
            this.rbMatriculado.Name = "rbMatriculado";
            this.rbMatriculado.Size = new System.Drawing.Size(80, 17);
            this.rbMatriculado.TabIndex = 1;
            this.rbMatriculado.TabStop = true;
            this.rbMatriculado.Text = "Matriculado";
            this.rbMatriculado.UseVisualStyleBackColor = true;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(180, 50);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(150, 21);
            this.cmbSucursal.TabIndex = 3;
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(230, 20);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(48, 13);
            this.lbSucursal.TabIndex = 4;
            this.lbSucursal.Text = "Sucursal";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(640, 30);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(130, 30);
            this.btnGenerarReporte.TabIndex = 5;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(640, 70);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(130, 30);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.gbTipoEmpleado);
            this.gbFiltros.Controls.Add(this.lbSucursal);
            this.gbFiltros.Controls.Add(this.cmbSucursal);
            this.gbFiltros.Location = new System.Drawing.Point(10, 20);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(620, 90);
            this.gbFiltros.TabIndex = 7;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // Reporte_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.gbEmpleados);
            this.Name = "Reporte_Empleados";
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.Reporte_Empleados_Load);
            this.gbEmpleados.ResumeLayout(false);
            this.gbTipoEmpleado.ResumeLayout(false);
            this.gbTipoEmpleado.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEmpleados;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.GroupBox gbTipoEmpleado;
        private System.Windows.Forms.RadioButton rbMatriculado;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.GroupBox gbFiltros;
    }
}