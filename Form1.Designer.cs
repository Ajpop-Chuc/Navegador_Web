namespace NavegadorWeb
{
    partial class Form1
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
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrocederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxBuscador = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másVisitadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDeHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.retrocederToolStripMenuItem,
            this.avanzarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.navegarToolStripMenuItem.Text = "Navegar";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // retrocederToolStripMenuItem
            // 
            this.retrocederToolStripMenuItem.Name = "retrocederToolStripMenuItem";
            this.retrocederToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.retrocederToolStripMenuItem.Text = "Retroceder";
            this.retrocederToolStripMenuItem.Click += new System.EventHandler(this.retrocederToolStripMenuItem_Click);
            // 
            // avanzarToolStripMenuItem
            // 
            this.avanzarToolStripMenuItem.Name = "avanzarToolStripMenuItem";
            this.avanzarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.avanzarToolStripMenuItem.Text = "Avanzar";
            this.avanzarToolStripMenuItem.Click += new System.EventHandler(this.avanzarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(989, 0);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(87, 28);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxBuscador
            // 
            this.comboBoxBuscador.FormattingEnabled = true;
            this.comboBoxBuscador.Location = new System.Drawing.Point(168, 2);
            this.comboBoxBuscador.Name = "comboBoxBuscador";
            this.comboBoxBuscador.Size = new System.Drawing.Size(815, 24);
            this.comboBoxBuscador.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1085, 555);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.másVisitadasToolStripMenuItem,
            this.ordenarPorFechaToolStripMenuItem,
            this.eliminarDeHistorialToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // másVisitadasToolStripMenuItem
            // 
            this.másVisitadasToolStripMenuItem.Name = "másVisitadasToolStripMenuItem";
            this.másVisitadasToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.másVisitadasToolStripMenuItem.Text = "Ordenar Por más visitadas";
            this.másVisitadasToolStripMenuItem.Click += new System.EventHandler(this.másVisitadasToolStripMenuItem_Click);
            // 
            // ordenarPorFechaToolStripMenuItem
            // 
            this.ordenarPorFechaToolStripMenuItem.Name = "ordenarPorFechaToolStripMenuItem";
            this.ordenarPorFechaToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.ordenarPorFechaToolStripMenuItem.Text = "Ordenar Por Fecha";
            this.ordenarPorFechaToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorFechaToolStripMenuItem_Click);
            // 
            // eliminarDeHistorialToolStripMenuItem
            // 
            this.eliminarDeHistorialToolStripMenuItem.Name = "eliminarDeHistorialToolStripMenuItem";
            this.eliminarDeHistorialToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.eliminarDeHistorialToolStripMenuItem.Text = "Eliminar de Historial";
            this.eliminarDeHistorialToolStripMenuItem.Click += new System.EventHandler(this.eliminarDeHistorialToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 583);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBoxBuscador);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrocederToolStripMenuItem;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscador;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem avanzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másVisitadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDeHistorialToolStripMenuItem;
    }
}

