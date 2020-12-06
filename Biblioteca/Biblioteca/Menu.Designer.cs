namespace Biblioteca
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentarExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.librosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasDeUsuariosToolStripMenuItem,
            this.altasDeLibrosToolStripMenuItem,
            this.aumentarExistenciaToolStripMenuItem,
            this.morososToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // altasDeUsuariosToolStripMenuItem
            // 
            this.altasDeUsuariosToolStripMenuItem.Name = "altasDeUsuariosToolStripMenuItem";
            this.altasDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.altasDeUsuariosToolStripMenuItem.Text = "Alta de Usuarios";
            this.altasDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.altasDeUsuariosToolStripMenuItem_Click);
            // 
            // altasDeLibrosToolStripMenuItem
            // 
            this.altasDeLibrosToolStripMenuItem.Name = "altasDeLibrosToolStripMenuItem";
            this.altasDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.altasDeLibrosToolStripMenuItem.Text = "Alta de Libros";
            this.altasDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.altasDeLibrosToolStripMenuItem_Click);
            // 
            // aumentarExistenciaToolStripMenuItem
            // 
            this.aumentarExistenciaToolStripMenuItem.Name = "aumentarExistenciaToolStripMenuItem";
            this.aumentarExistenciaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.aumentarExistenciaToolStripMenuItem.Text = "Aumentar Existencia";
            this.aumentarExistenciaToolStripMenuItem.Click += new System.EventHandler(this.aumentarExistenciaToolStripMenuItem_Click);
            // 
            // morososToolStripMenuItem
            // 
            this.morososToolStripMenuItem.Name = "morososToolStripMenuItem";
            this.morososToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.morososToolStripMenuItem.Text = "Morosos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaToolStripMenuItem,
            this.reporteDeUsuariosToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            this.busquedaToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            this.reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            this.reporteDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.reporteDeUsuariosToolStripMenuItem.Text = "Reporte de Usuarios";
            this.reporteDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeUsuariosToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoDeLibrosToolStripMenuItem,
            this.devolucionDeLibrosToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // prestamoDeLibrosToolStripMenuItem
            // 
            this.prestamoDeLibrosToolStripMenuItem.Name = "prestamoDeLibrosToolStripMenuItem";
            this.prestamoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.prestamoDeLibrosToolStripMenuItem.Text = "Prestamo de Libros";
            // 
            // devolucionDeLibrosToolStripMenuItem
            // 
            this.devolucionDeLibrosToolStripMenuItem.Name = "devolucionDeLibrosToolStripMenuItem";
            this.devolucionDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.devolucionDeLibrosToolStripMenuItem.Text = "Devolucion de Libros";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aumentarExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morososToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionDeLibrosToolStripMenuItem;
    }
}

