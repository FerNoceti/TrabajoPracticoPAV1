
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
            this.lbMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.cbMayorA = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpIngresosSucursal
            // 
            this.rpIngresosSucursal.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Estadisticas.RDLCs.ReportIngresosSucursal.rdlc";
            this.rpIngresosSucursal.Location = new System.Drawing.Point(0, 110);
            this.rpIngresosSucursal.Name = "rpIngresosSucursal";
            this.rpIngresosSucursal.ServerReport.BearerToken = null;
            this.rpIngresosSucursal.Size = new System.Drawing.Size(800, 340);
            this.rpIngresosSucursal.TabIndex = 0;
            this.rpIngresosSucursal.Load += new System.EventHandler(this.rpingresosSucursal_Load);
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Location = new System.Drawing.Point(330, 60);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(49, 13);
            this.lbMonto.TabIndex = 1;
            this.lbMonto.Text = "Monto  $";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(380, 60);
            this.txtMonto.Mask = "99999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(60, 20);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // cbMayorA
            // 
            this.cbMayorA.AutoSize = true;
            this.cbMayorA.Location = new System.Drawing.Point(320, 30);
            this.cbMayorA.Name = "cbMayorA";
            this.cbMayorA.Size = new System.Drawing.Size(123, 17);
            this.cbMayorA.TabIndex = 3;
            this.cbMayorA.Text = "Mayores a un Monto";
            this.cbMayorA.UseVisualStyleBackColor = true;
            this.cbMayorA.CheckedChanged += new System.EventHandler(this.cbMayorA_CheckedChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(460, 60);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Aplicar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Estadisticas_Ingresos_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cbMayorA);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.rpIngresosSucursal);
            this.Name = "Estadisticas_Ingresos_Sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas_Ingresos_Sucursal";
            this.Load += new System.EventHandler(this.Estadisticas_Ingresos_Sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpIngresosSucursal;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.CheckBox cbMayorA;
        private System.Windows.Forms.Button btnGenerar;
    }
}