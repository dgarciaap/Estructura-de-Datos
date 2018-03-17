namespace WindowsFormsApp1
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
            this.cmd1Dado = new System.Windows.Forms.Button();
            this.cmd2Dado = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd1Dado
            // 
            this.cmd1Dado.Location = new System.Drawing.Point(12, 73);
            this.cmd1Dado.Name = "cmd1Dado";
            this.cmd1Dado.Size = new System.Drawing.Size(75, 23);
            this.cmd1Dado.TabIndex = 0;
            this.cmd1Dado.Text = "1 dado";
            this.cmd1Dado.UseVisualStyleBackColor = true;
            this.cmd1Dado.Click += new System.EventHandler(this.cmd1Dado_Click);
            // 
            // cmd2Dado
            // 
            this.cmd2Dado.Location = new System.Drawing.Point(12, 102);
            this.cmd2Dado.Name = "cmd2Dado";
            this.cmd2Dado.Size = new System.Drawing.Size(75, 23);
            this.cmd2Dado.TabIndex = 1;
            this.cmd2Dado.Text = "2 dados";
            this.cmd2Dado.UseVisualStyleBackColor = true;
            this.cmd2Dado.Click += new System.EventHandler(this.cmd2Dado_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(103, 12);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDatos.Size = new System.Drawing.Size(246, 236);
            this.txtDatos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "2 dados pero inicializas un dado ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.cmd2Dado);
            this.Controls.Add(this.cmd1Dado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd1Dado;
        private System.Windows.Forms.Button cmd2Dado;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button button1;
    }
}

