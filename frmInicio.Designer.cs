namespace pry_Agenda_Contactos
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.msNavegacion = new System.Windows.Forms.MenuStrip();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvContactos = new System.Windows.Forms.TreeView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbInfoContacto = new System.Windows.Forms.GroupBox();
            this.msNavegacion.SuspendLayout();
            this.gbInfoContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavegacion
            // 
            this.msNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactosToolStripMenuItem,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.msNavegacion.Location = new System.Drawing.Point(0, 0);
            this.msNavegacion.Name = "msNavegacion";
            this.msNavegacion.Size = new System.Drawing.Size(367, 24);
            this.msNavegacion.TabIndex = 0;
            this.msNavegacion.Text = "menuStrip1";
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactosToolStripMenuItem.Text = "Agregar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Contacto";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarContactoToolStripMenuItem,
            this.modificarGrupoToolStripMenuItem});
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // modificarContactoToolStripMenuItem
            // 
            this.modificarContactoToolStripMenuItem.Name = "modificarContactoToolStripMenuItem";
            this.modificarContactoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.modificarContactoToolStripMenuItem.Text = "Modificar Contacto";
            this.modificarContactoToolStripMenuItem.Click += new System.EventHandler(this.modificarContactoToolStripMenuItem_Click);
            // 
            // modificarGrupoToolStripMenuItem
            // 
            this.modificarGrupoToolStripMenuItem.Name = "modificarGrupoToolStripMenuItem";
            this.modificarGrupoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.modificarGrupoToolStripMenuItem.Text = "Modificar Grupo";
            this.modificarGrupoToolStripMenuItem.Click += new System.EventHandler(this.modificarGrupoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarContactoToolStripMenuItem,
            this.eliminarGrupoToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarContactoToolStripMenuItem
            // 
            this.eliminarContactoToolStripMenuItem.Name = "eliminarContactoToolStripMenuItem";
            this.eliminarContactoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarContactoToolStripMenuItem.Text = "Eliminar Contacto";
            this.eliminarContactoToolStripMenuItem.Click += new System.EventHandler(this.eliminarContactoToolStripMenuItem_Click);
            // 
            // eliminarGrupoToolStripMenuItem
            // 
            this.eliminarGrupoToolStripMenuItem.Name = "eliminarGrupoToolStripMenuItem";
            this.eliminarGrupoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarGrupoToolStripMenuItem.Text = "Eliminar Grupo";
            this.eliminarGrupoToolStripMenuItem.Click += new System.EventHandler(this.eliminarGrupoToolStripMenuItem_Click);
            // 
            // tvContactos
            // 
            this.tvContactos.Location = new System.Drawing.Point(12, 27);
            this.tvContactos.Name = "tvContactos";
            this.tvContactos.Size = new System.Drawing.Size(157, 411);
            this.tvContactos.TabIndex = 1;
            this.tvContactos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvContactos_AfterSelect);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.Location = new System.Drawing.Point(6, 61);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(6, 80);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(176, 20);
            this.txtGrupo.TabIndex = 2;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(6, 112);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(6, 131);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(176, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(6, 161);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 180);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(176, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // gbInfoContacto
            // 
            this.gbInfoContacto.BackColor = System.Drawing.Color.White;
            this.gbInfoContacto.Controls.Add(this.txtGrupo);
            this.gbInfoContacto.Controls.Add(this.txtNombre);
            this.gbInfoContacto.Controls.Add(this.lblNombre);
            this.gbInfoContacto.Controls.Add(this.lblNumero);
            this.gbInfoContacto.Controls.Add(this.lblGrupo);
            this.gbInfoContacto.Controls.Add(this.txtNumero);
            this.gbInfoContacto.Controls.Add(this.txtCorreo);
            this.gbInfoContacto.Controls.Add(this.lblCorreo);
            this.gbInfoContacto.ForeColor = System.Drawing.Color.White;
            this.gbInfoContacto.Location = new System.Drawing.Point(175, 27);
            this.gbInfoContacto.Name = "gbInfoContacto";
            this.gbInfoContacto.Size = new System.Drawing.Size(186, 210);
            this.gbInfoContacto.TabIndex = 10;
            this.gbInfoContacto.TabStop = false;
            this.gbInfoContacto.Text = "Informacíon del Contacto";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.gbInfoContacto);
            this.Controls.Add(this.tvContactos);
            this.Controls.Add(this.msNavegacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msNavegacion;
            this.Name = "frmInicio";
            this.Text = "Agenda de Contactos";
            this.msNavegacion.ResumeLayout(false);
            this.msNavegacion.PerformLayout();
            this.gbInfoContacto.ResumeLayout(false);
            this.gbInfoContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavegacion;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.TreeView tvContactos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarGrupoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbInfoContacto;
    }
}

