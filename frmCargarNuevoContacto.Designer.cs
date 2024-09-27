namespace pry_Agenda_Contactos
{
    partial class frmCargarNuevoContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarNuevoContacto));
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.gbInfoContacto = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInfoContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(6, 112);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(6, 61);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 161);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre*:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(6, 80);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(266, 20);
            this.txtGrupo.TabIndex = 2;
            // 
            // gbInfoContacto
            // 
            this.gbInfoContacto.Controls.Add(this.txtGrupo);
            this.gbInfoContacto.Controls.Add(this.txtNombre);
            this.gbInfoContacto.Controls.Add(this.lblNombre);
            this.gbInfoContacto.Controls.Add(this.lblNumero);
            this.gbInfoContacto.Controls.Add(this.lblGrupo);
            this.gbInfoContacto.Controls.Add(this.txtNumero);
            this.gbInfoContacto.Controls.Add(this.txtCorreo);
            this.gbInfoContacto.Controls.Add(this.lblCorreo);
            this.gbInfoContacto.Location = new System.Drawing.Point(2, 3);
            this.gbInfoContacto.Name = "gbInfoContacto";
            this.gbInfoContacto.Size = new System.Drawing.Size(278, 210);
            this.gbInfoContacto.TabIndex = 11;
            this.gbInfoContacto.TabStop = false;
            this.gbInfoContacto.Text = "Informacíon del Contacto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(216, 220);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(64, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(6, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(6, 131);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(266, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 180);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(266, 20);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Debe rellenar los campos\r\nmarcados con \"*\".";
            // 
            // frmCargarNuevoContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbInfoContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargarNuevoContacto";
            this.Text = "Cargar nuevo Contacto";
            this.gbInfoContacto.ResumeLayout(false);
            this.gbInfoContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.GroupBox gbInfoContacto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
    }
}