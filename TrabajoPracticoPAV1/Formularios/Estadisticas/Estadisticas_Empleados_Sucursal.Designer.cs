
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class btnGenerar
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
            this.gbReportesEmpleadosSucursal = new System.Windows.Forms.GroupBox();
            this.cbSucursalEspecifica = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdSucursalEsp = new System.Windows.Forms.MaskedTextBox();
            this.lbIdSucursal = new System.Windows.Forms.Label();
            this.gbReportesEmpleadosSucursal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpEmpleadoSucursal
            // 
            this.rpEmpleadoSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpEmpleadoSucursal.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportEmpleadoSucursal.rdlc";
            this.rpEmpleadoSucursal.Location = new System.Drawing.Point(3, 16);
            this.rpEmpleadoSucursal.Name = "rpEmpleadoSucursal";
            this.rpEmpleadoSucursal.ServerReport.BearerToken = null;
            this.rpEmpleadoSucursal.Size = new System.Drawing.Size(794, 331);
            this.rpEmpleadoSucursal.TabIndex = 0;
            this.rpEmpleadoSucursal.Load += new System.EventHandler(this.rpEmpleadoSucursal_Load);
            // 
            // gbReportesEmpleadosSucursal
            // 
            this.gbReportesEmpleadosSucursal.Controls.Add(this.rpEmpleadoSucursal);
            this.gbReportesEmpleadosSucursal.Location = new System.Drawing.Point(0, 100);
            this.gbReportesEmpleadosSucursal.Name = "gbReportesEmpleadosSucursal";
            this.gbReportesEmpleadosSucursal.Size = new System.Drawing.Size(800, 350);
            this.gbReportesEmpleadosSucursal.TabIndex = 1;
            this.gbReportesEmpleadosSucursal.TabStop = false;
            this.gbReportesEmpleadosSucursal.Text = "Reporte";
            // 
            // cbSucursalEspecifica
            // 
            this.cbSucursalEspecifica.AutoSize = true;
            this.cbSucursalEspecifica.Location = new System.Drawing.Point(280, 40);
            this.cbSucursalEspecifica.Name = "cbSucursalEspecifica";
            this.cbSucursalEspecifica.Size = new System.Drawing.Size(116, 17);
            this.cbSucursalEspecifica.TabIndex = 2;
            this.cbSucursalEspecifica.Text = "SucursalEspecifica";
            this.cbSucursalEspecifica.UseVisualStyleBackColor = true;
            this.cbSucursalEspecifica.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdSucursalEsp
            // 
            this.txtIdSucursalEsp.Location = new System.Drawing.Point(310, 70);
            this.txtIdSucursalEsp.Name = "txtIdSucursalEsp";
            this.txtIdSucursalEsp.Size = new System.Drawing.Size(80, 20);
            this.txtIdSucursalEsp.TabIndex = 5;
            // 
            // lbIdSucursal
            // 
            this.lbIdSucursal.AutoSize = true;
            this.lbIdSucursal.Location = new System.Drawing.Point(280, 70);
            this.lbIdSucursal.Name = "lbIdSucursal";
            this.lbIdSucursal.Size = new System.Drawing.Size(16, 13);
            this.lbIdSucursal.TabIndex = 6;
            this.lbIdSucursal.Text = "Id";
            // 
            // btnGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIdSucursal);
            this.Controls.Add(this.txtIdSucursalEsp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSucursalEspecifica);
            this.Controls.Add(this.gbReportesEmpleadosSucursal);
            this.Name = "btnGenerar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados por Sucursal";
            this.Load += new System.EventHandler(this.Estadisticas_Empleados_Sucursal_Load);
            this.gbReportesEmpleadosSucursal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpEmpleadoSucursal;
        private System.Windows.Forms.GroupBox gbReportesEmpleadosSucursal;
        private System.Windows.Forms.CheckBox cbSucursalEspecifica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtIdSucursalEsp;
        private System.Windows.Forms.Label lbIdSucursal;
    }
}