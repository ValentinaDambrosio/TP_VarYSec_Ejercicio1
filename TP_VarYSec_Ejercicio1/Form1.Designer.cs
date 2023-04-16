namespace TP_VarYSec_Ejercicio1
{
    partial class fCirculo
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
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bArea = new System.Windows.Forms.Button();
            this.lRadio = new System.Windows.Forms.Label();
            this.lUnidades = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(157, 185);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(75, 23);
            this.bPerimetro.TabIndex = 0;
            this.bPerimetro.Text = "Perímetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(248, 185);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(75, 23);
            this.bArea.TabIndex = 1;
            this.bArea.Text = "Área";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // lRadio
            // 
            this.lRadio.AutoSize = true;
            this.lRadio.Location = new System.Drawing.Point(46, 43);
            this.lRadio.Name = "lRadio";
            this.lRadio.Size = new System.Drawing.Size(38, 13);
            this.lRadio.TabIndex = 2;
            this.lRadio.Text = "Radio:";
            // 
            // lUnidades
            // 
            this.lUnidades.AutoSize = true;
            this.lUnidades.Location = new System.Drawing.Point(218, 46);
            this.lUnidades.Name = "lUnidades";
            this.lUnidades.Size = new System.Drawing.Size(85, 13);
            this.lUnidades.TabIndex = 3;
            this.lUnidades.Text = "cm/s, m/s, km/s";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(342, 185);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 4;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // tRadio
            // 
            this.tRadio.Location = new System.Drawing.Point(90, 43);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(111, 20);
            this.tRadio.TabIndex = 5;
            // 
            // fCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(457, 239);
            this.Controls.Add(this.tRadio);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.lUnidades);
            this.Controls.Add(this.lRadio);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.bPerimetro);
            this.Name = "fCirculo";
            this.Text = "Círculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Label lRadio;
        private System.Windows.Forms.Label lUnidades;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.TextBox tRadio;
    }
}

