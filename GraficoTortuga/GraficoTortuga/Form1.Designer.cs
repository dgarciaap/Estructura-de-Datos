namespace GraficoTortuga
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
            this.txtAvanzar = new System.Windows.Forms.TextBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnLevantar = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAvanzar
            // 
            this.txtAvanzar.Location = new System.Drawing.Point(12, 12);
            this.txtAvanzar.Name = "txtAvanzar";
            this.txtAvanzar.Size = new System.Drawing.Size(57, 20);
            this.txtAvanzar.TabIndex = 0;
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(12, 100);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(448, 269);
            this.txtDatos.TabIndex = 1;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(75, 12);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnLevantar
            // 
            this.btnLevantar.Location = new System.Drawing.Point(12, 41);
            this.btnLevantar.Name = "btnLevantar";
            this.btnLevantar.Size = new System.Drawing.Size(75, 23);
            this.btnLevantar.TabIndex = 3;
            this.btnLevantar.Text = "Levantar";
            this.btnLevantar.UseVisualStyleBackColor = true;
            this.btnLevantar.Click += new System.EventHandler(this.btnLevantar_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(93, 41);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(75, 23);
            this.btnBajar.TabIndex = 4;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(174, 41);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 5;
            this.btnDerecha.Text = "Girar D";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.Location = new System.Drawing.Point(255, 41);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(75, 23);
            this.btnIzq.TabIndex = 6;
            this.btnIzq.Text = "Girar Izq";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(156, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 381);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnLevantar);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.txtAvanzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAvanzar;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnLevantar;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button btnMostrar;
    }
}

