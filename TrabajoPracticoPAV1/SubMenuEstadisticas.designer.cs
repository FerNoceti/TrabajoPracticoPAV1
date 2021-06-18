
namespace TrabajoPracticoPAV1
{
    partial class SubMenuEstadisticas
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perrosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosObtenidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosPorSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(27)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.perrosRegistradosToolStripMenuItem,
            this.ingresosObtenidosToolStripMenuItem,
            this.empleadosPorSucursalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.consultasToolStripMenuItem.Text = "Consultas Realizadas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // perrosRegistradosToolStripMenuItem
            // 
            this.perrosRegistradosToolStripMenuItem.Name = "perrosRegistradosToolStripMenuItem";
            this.perrosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perrosRegistradosToolStripMenuItem.Text = "Perros Registrados";
            this.perrosRegistradosToolStripMenuItem.Click += new System.EventHandler(this.perrosRegistradosToolStripMenuItem_Click);
            // 
            // ingresosObtenidosToolStripMenuItem
            // 
            this.ingresosObtenidosToolStripMenuItem.Name = "ingresosObtenidosToolStripMenuItem";
            this.ingresosObtenidosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ingresosObtenidosToolStripMenuItem.Text = "Ingresos Obtenidos";
            this.ingresosObtenidosToolStripMenuItem.Click += new System.EventHandler(this.ingresosObtenidosToolStripMenuItem_Click);
            // 
            // empleadosPorSucursalToolStripMenuItem
            // 
            this.empleadosPorSucursalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porSucursalToolStripMenuItem,
            this.porEdadToolStripMenuItem});
            this.empleadosPorSucursalToolStripMenuItem.Name = "empleadosPorSucursalToolStripMenuItem";
            this.empleadosPorSucursalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.empleadosPorSucursalToolStripMenuItem.Text = "Empleados Por Sucursal";
            this.empleadosPorSucursalToolStripMenuItem.Click += new System.EventHandler(this.empleadosPorSucursalToolStripMenuItem_Click);
            // 
            // porSucursalToolStripMenuItem
            // 
            this.porSucursalToolStripMenuItem.Name = "porSucursalToolStripMenuItem";
            this.porSucursalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porSucursalToolStripMenuItem.Text = "Por Sucursal";
            this.porSucursalToolStripMenuItem.Click += new System.EventHandler(this.porSucursalToolStripMenuItem_Click);
            // 
            // porEdadToolStripMenuItem
            // 
            this.porEdadToolStripMenuItem.Name = "porEdadToolStripMenuItem";
            this.porEdadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porEdadToolStripMenuItem.Text = "Por Edad";
            this.porEdadToolStripMenuItem.Click += new System.EventHandler(this.porEdadToolStripMenuItem_Click);
            // 
            // SubMenuEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SubMenuEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMenuEstadisticas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perrosRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosObtenidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosPorSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEdadToolStripMenuItem;
    }
}