namespace pry_Agenda_Contactos
{
    partial class frmEliminarGrupo
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
            this.gbEliminarGrupo = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.gbEliminarGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEliminarGrupo
            // 
            this.gbEliminarGrupo.Controls.Add(this.btnAceptar);
            this.gbEliminarGrupo.Controls.Add(this.cmbGrupos);
            this.gbEliminarGrupo.Location = new System.Drawing.Point(2, 3);
            this.gbEliminarGrupo.Name = "gbEliminarGrupo";
            this.gbEliminarGrupo.Size = new System.Drawing.Size(278, 246);
            this.gbEliminarGrupo.TabIndex = 13;
            this.gbEliminarGrupo.TabStop = false;
            this.gbEliminarGrupo.Text = "Selección de Grupo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(195, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(7, 44);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(263, 21);
            this.cmbGrupos.TabIndex = 0;
            // 
            // frmEliminarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbEliminarGrupo);
            this.Name = "frmEliminarGrupo";
            this.Text = "Eliminar grupo";
            this.gbEliminarGrupo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminarGrupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbGrupos;
    }
}