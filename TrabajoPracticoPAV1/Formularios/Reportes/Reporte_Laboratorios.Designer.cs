
namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    partial class Reporte_Laboratorios
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
            this.reportViewerLabs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rdbNumId = new System.Windows.Forms.RadioButton();
            this.rdbRazonSocial = new System.Windows.Forms.RadioButton();
            this.rdbIdBarrio = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerLabs
            // 
            this.reportViewerLabs.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.reporteLaboratorios.rdlc";
            this.reportViewerLabs.Location = new System.Drawing.Point(0, 131);
            this.reportViewerLabs.Name = "reportViewerLabs";
            this.reportViewerLabs.ServerReport.BearerToken = null;
            this.reportViewerLabs.Size = new System.Drawing.Size(993, 513);
            this.reportViewerLabs.TabIndex = 0;
            this.reportViewerLabs.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdbIdBarrio);
            this.groupBox1.Controls.Add(this.rdbRazonSocial);
            this.groupBox1.Controls.Add(this.rdbNumId);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(18)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(345, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su consulta:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(513, 58);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(185, 23);
            this.txtBusqueda.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(17)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(705, 53);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 32);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rdbNumId
            // 
            this.rdbNumId.AutoSize = true;
            this.rdbNumId.Location = new System.Drawing.Point(16, 23);
            this.rdbNumId.Name = "rdbNumId";
            this.rdbNumId.Size = new System.Drawing.Size(191, 21);
            this.rdbNumId.TabIndex = 0;
            this.rdbNumId.TabStop = true;
            this.rdbNumId.Text = "Numero de Identificacion";
            this.rdbNumId.UseVisualStyleBackColor = true;
            this.rdbNumId.CheckedChanged += new System.EventHandler(this.rdbNumId_CheckedChanged);
            // 
            // rdbRazonSocial
            // 
            this.rdbRazonSocial.AutoSize = true;
            this.rdbRazonSocial.Location = new System.Drawing.Point(16, 50);
            this.rdbRazonSocial.Name = "rdbRazonSocial";
            this.rdbRazonSocial.Size = new System.Drawing.Size(108, 21);
            this.rdbRazonSocial.TabIndex = 1;
            this.rdbRazonSocial.TabStop = true;
            this.rdbRazonSocial.Text = "Razon Social";
            this.rdbRazonSocial.UseVisualStyleBackColor = true;
            this.rdbRazonSocial.CheckedChanged += new System.EventHandler(this.rdbRazonSocial_CheckedChanged);
            // 
            // rdbIdBarrio
            // 
            this.rdbIdBarrio.AutoSize = true;
            this.rdbIdBarrio.Location = new System.Drawing.Point(16, 77);
            this.rdbIdBarrio.Name = "rdbIdBarrio";
            this.rdbIdBarrio.Size = new System.Drawing.Size(99, 21);
            this.rdbIdBarrio.TabIndex = 2;
            this.rdbIdBarrio.TabStop = true;
            this.rdbIdBarrio.Text = "Id de Barrio";
            this.rdbIdBarrio.UseVisualStyleBackColor = true;
            this.rdbIdBarrio.CheckedChanged += new System.EventHandler(this.rdbIdBarrio_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(193, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sin Filtros";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Reporte_Laboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(991, 644);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewerLabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reporte_Laboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Laboratorios";
            this.Load += new System.EventHandler(this.Reporte_Laboratorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLabs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rdbIdBarrio;
        private System.Windows.Forms.RadioButton rdbRazonSocial;
        private System.Windows.Forms.RadioButton rdbNumId;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}