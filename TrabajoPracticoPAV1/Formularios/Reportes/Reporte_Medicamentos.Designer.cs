
namespace TrabajoPracticoPAV1.Formularios.Reportes
{
    partial class ReporteMedicamentos
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
            this.reportViewerMedicamentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTermine = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbComienze = new System.Windows.Forms.RadioButton();
            this.btnFiltrosMedicamentos = new System.Windows.Forms.Button();
            this.txtFiltroMedicamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerMedicamentos
            // 
            this.reportViewerMedicamentos.LocalReport.ReportEmbeddedResource = "TrabajoPracticoPAV1.Formularios.Reportes.RDLCs.ListadoDeMedicamentos.rdlc";
            this.reportViewerMedicamentos.Location = new System.Drawing.Point(-1, 89);
            this.reportViewerMedicamentos.Name = "reportViewerMedicamentos";
            this.reportViewerMedicamentos.ServerReport.BearerToken = null;
            this.reportViewerMedicamentos.Size = new System.Drawing.Size(756, 387);
            this.reportViewerMedicamentos.TabIndex = 0;
            this.reportViewerMedicamentos.Load += new System.EventHandler(this.reportViewerMedicamentos_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTermine);
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Controls.Add(this.rdbComienze);
            this.groupBox1.Location = new System.Drawing.Point(265, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros ";
            // 
            // rdbTermine
            // 
            this.rdbTermine.AutoSize = true;
            this.rdbTermine.Location = new System.Drawing.Point(144, 30);
            this.rdbTermine.Name = "rdbTermine";
            this.rdbTermine.Size = new System.Drawing.Size(84, 17);
            this.rdbTermine.TabIndex = 2;
            this.rdbTermine.TabStop = true;
            this.rdbTermine.Text = "Termine con";
            this.rdbTermine.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(251, 30);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 1;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbComienze
            // 
            this.rdbComienze.AutoSize = true;
            this.rdbComienze.Location = new System.Drawing.Point(37, 30);
            this.rdbComienze.Name = "rdbComienze";
            this.rdbComienze.Size = new System.Drawing.Size(86, 17);
            this.rdbComienze.TabIndex = 0;
            this.rdbComienze.TabStop = true;
            this.rdbComienze.Text = "Empieze con";
            this.rdbComienze.UseVisualStyleBackColor = true;
            // 
            // btnFiltrosMedicamentos
            // 
            this.btnFiltrosMedicamentos.Location = new System.Drawing.Point(629, 55);
            this.btnFiltrosMedicamentos.Name = "btnFiltrosMedicamentos";
            this.btnFiltrosMedicamentos.Size = new System.Drawing.Size(90, 23);
            this.btnFiltrosMedicamentos.TabIndex = 2;
            this.btnFiltrosMedicamentos.Text = "Cargar";
            this.btnFiltrosMedicamentos.UseVisualStyleBackColor = true;
            this.btnFiltrosMedicamentos.Click += new System.EventHandler(this.btnFiltrosMedicamentos_Click);
            // 
            // txtFiltroMedicamento
            // 
            this.txtFiltroMedicamento.Location = new System.Drawing.Point(83, 39);
            this.txtFiltroMedicamento.Name = "txtFiltroMedicamento";
            this.txtFiltroMedicamento.Size = new System.Drawing.Size(151, 20);
            this.txtFiltroMedicamento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Letra/s";
            // 
            // ReporteMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltroMedicamento);
            this.Controls.Add(this.btnFiltrosMedicamentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewerMedicamentos);
            this.Name = "ReporteMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Medicamentos";
            this.Load += new System.EventHandler(this.ReporteMedicamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMedicamentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbComienze;
        private System.Windows.Forms.Button btnFiltrosMedicamentos;
        private System.Windows.Forms.RadioButton rdbTermine;
        private System.Windows.Forms.TextBox txtFiltroMedicamento;
        private System.Windows.Forms.Label label1;
    }
}