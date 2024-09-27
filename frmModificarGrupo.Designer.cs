namespace pry_Agenda_Contactos
{
    partial class frmModificarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarGrupo));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.gbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(209, 229);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(64, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(136, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbGrupos
            // 
            this.gbGrupos.Controls.Add(this.btnReiniciar);
            this.gbGrupos.Controls.Add(this.cmbGrupos);
            this.gbGrupos.Controls.Add(this.lblSeleccion);
            this.gbGrupos.Controls.Add(this.txtGrupo);
            this.gbGrupos.Controls.Add(this.lblGrupo);
            this.gbGrupos.Location = new System.Drawing.Point(2, 3);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(278, 157);
            this.gbGrupos.TabIndex = 15;
            this.gbGrupos.TabStop = false;
            this.gbGrupos.Text = "Grupos";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(209, 59);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(64, 23);
            this.btnReiniciar.TabIndex = 17;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(7, 32);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(266, 21);
            this.cmbGrupos.TabIndex = 7;
            this.cmbGrupos.DropDown += new System.EventHandler(this.cmbGrupos_DropDown);
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(7, 16);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(158, 13);
            this.lblSeleccion.TabIndex = 6;
            this.lblSeleccion.Text = "Seleccione el grupo a modificar:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(7, 123);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(266, 20);
            this.txtGrupo.TabIndex = 2;
            this.txtGrupo.TextChanged += new System.EventHandler(this.txtGrupo_TextChanged);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(7, 95);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo:";
            // 
            // frmModificarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbGrupos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarGrupo";
            this.Text = "Modificar Grupo";
            this.gbGrupos.ResumeLayout(false);
            this.gbGrupos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnReiniciar;
    }
}