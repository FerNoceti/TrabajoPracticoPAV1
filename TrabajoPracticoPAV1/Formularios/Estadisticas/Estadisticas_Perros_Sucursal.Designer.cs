
namespace TrabajoPracticoPAV1.Formularios.Estadisticas
{
    partial class Estadisticas_Perros_Sucursal
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroSucursal = new System.Windows.Forms.TextBox();
            this.btnFiltrosSucursal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTerminee = new System.Windows.Forms.RadioButton();
            this.rdbTodoo = new System.Windows.Forms.RadioButton();
            this.rdbComienzee = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.PerroXSucursal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(773, 393);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Letra/s";
            // 
            // txtFiltroSucursal
            // 
            this.txtFiltroSucursal.Location = new System.Drawing.Point(89, 48);
            this.txtFiltroSucursal.Name = "txtFiltroSucursal";
            this.txtFiltroSucursal.Size = new System.Drawing.Size(151, 20);
            this.txtFiltroSucursal.TabIndex = 7;
            // 
            // btnFiltrosSucursal
            // 
            this.btnFiltrosSucursal.Location = new System.Drawing.Point(638, 64);
            this.btnFiltrosSucursal.Name = "btnFiltrosSucursal";
            this.btnFiltrosSucursal.Size = new System.Drawing.Size(90, 23);
            this.btnFiltrosSucursal.TabIndex = 6;
            this.btnFiltrosSucursal.Text = "Cargar";
            this.btnFiltrosSucursal.UseVisualStyleBackColor = true;
            this.btnFiltrosSucursal.Click += new System.EventHandler(this.btnFiltrosSucursal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTerminee);
            this.groupBox1.Controls.Add(this.rdbTodoo);
            this.groupBox1.Controls.Add(this.rdbComienzee);
            this.groupBox1.Location = new System.Drawing.Point(271, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro sucursal";
            // 
            // rdbTerminee
            // 
            this.rdbTerminee.AutoSize = true;
            this.rdbTerminee.Location = new System.Drawing.Point(144, 30);
            this.rdbTerminee.Name = "rdbTerminee";
            this.rdbTerminee.Size = new System.Drawing.Size(84, 17);
            this.rdbTerminee.TabIndex = 2;
            this.rdbTerminee.TabStop = true;
            this.rdbTerminee.Text = "Termine con";
            this.rdbTerminee.UseVisualStyleBackColor = true;
            // 
            // rdbTodoo
            // 
            this.rdbTodoo.AutoSize = true;
            this.rdbTodoo.Location = new System.Drawing.Point(251, 30);
            this.rdbTodoo.Name = "rdbTodoo";
            this.rdbTodoo.Size = new System.Drawing.Size(55, 17);
            this.rdbTodoo.TabIndex = 1;
            this.rdbTodoo.TabStop = true;
            this.rdbTodoo.Text = "Todos";
            this.rdbTodoo.UseVisualStyleBackColor = true;
            // 
            // rdbComienzee
            // 
            this.rdbComienzee.AutoSize = true;
            this.rdbComienzee.Location = new System.Drawing.Point(37, 30);
            this.rdbComienzee.Name = "rdbComienzee";
            this.rdbComienzee.Size = new System.Drawing.Size(86, 17);
            this.rdbComienzee.TabIndex = 0;
            this.rdbComienzee.TabStop = true;
            this.rdbComienzee.Text = "Empieze con";
            this.rdbComienzee.UseVisualStyleBackColor = true;
            // 
            // Estadisticas_Perros_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltroSucursal);
            this.Controls.Add(this.btnFiltrosSucursal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Estadisticas_Perros_Sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas Perros x Sucursal";
            this.Load += new System.EventHandler(this.Estadisticas_Perros_Sucursal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroSucursal;
        private System.Windows.Forms.Button btnFiltrosSucursal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTerminee;
        private System.Windows.Forms.RadioButton rdbTodoo;
        private System.Windows.Forms.RadioButton rdbComienzee;
    }
}