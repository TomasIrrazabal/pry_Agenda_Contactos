namespace pry_Agenda_Contactos
{
    partial class frmEliminarContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarContacto));
            this.gbEliminarContacto = new System.Windows.Forms.GroupBox();
            this.cmbContactos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbEliminarContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEliminarContacto
            // 
            this.gbEliminarContacto.Controls.Add(this.btnAceptar);
            this.gbEliminarContacto.Controls.Add(this.cmbContactos);
            this.gbEliminarContacto.Location = new System.Drawing.Point(2, 3);
            this.gbEliminarContacto.Name = "gbEliminarContacto";
            this.gbEliminarContacto.Size = new System.Drawing.Size(278, 246);
            this.gbEliminarContacto.TabIndex = 12;
            this.gbEliminarContacto.TabStop = false;
            this.gbEliminarContacto.Text = "Selección de Contacto";
            // 
            // cmbContactos
            // 
            this.cmbContactos.FormattingEnabled = true;
            this.cmbContactos.Location = new System.Drawing.Point(7, 44);
            this.cmbContactos.Name = "cmbContactos";
            this.cmbContactos.Size = new System.Drawing.Size(263, 21);
            this.cmbContactos.TabIndex = 0;
            this.cmbContactos.SelectedIndexChanged += new System.EventHandler(this.cmbContactos_SelectedIndexChanged);
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
            // frmEliminarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbEliminarContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarContacto";
            this.Text = "Eliminar un Contacto";
            this.gbEliminarContacto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminarContacto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbContactos;
    }
}