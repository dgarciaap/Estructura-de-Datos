namespace Series3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.cmdSen = new System.Windows.Forms.Button();
            this.cmdCos = new System.Windows.Forms.Button();
            this.cmdLn = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComprobar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "n:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(53, 9);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(51, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(53, 38);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(51, 20);
            this.txtN.TabIndex = 3;
            // 
            // cmdSen
            // 
            this.cmdSen.Location = new System.Drawing.Point(125, 28);
            this.cmdSen.Name = "cmdSen";
            this.cmdSen.Size = new System.Drawing.Size(58, 23);
            this.cmdSen.TabIndex = 4;
            this.cmdSen.Text = "sen";
            this.cmdSen.UseVisualStyleBackColor = true;
            this.cmdSen.Click += new System.EventHandler(this.cmdSen_Click);
            // 
            // cmdCos
            // 
            this.cmdCos.Location = new System.Drawing.Point(203, 28);
            this.cmdCos.Name = "cmdCos";
            this.cmdCos.Size = new System.Drawing.Size(58, 23);
            this.cmdCos.TabIndex = 5;
            this.cmdCos.Text = "cos";
            this.cmdCos.UseVisualStyleBackColor = true;
            this.cmdCos.Click += new System.EventHandler(this.cmdCos_Click);
            // 
            // cmdLn
            // 
            this.cmdLn.Location = new System.Drawing.Point(165, 63);
            this.cmdLn.Name = "cmdLn";
            this.cmdLn.Size = new System.Drawing.Size(58, 23);
            this.cmdLn.TabIndex = 6;
            this.cmdLn.Text = "ln";
            this.cmdLn.UseVisualStyleBackColor = true;
            this.cmdLn.Click += new System.EventHandler(this.cmdLn_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(53, 70);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(51, 20);
            this.txtR.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "R=";
            // 
            // txtComprobar
            // 
            this.txtComprobar.Location = new System.Drawing.Point(24, 109);
            this.txtComprobar.Multiline = true;
            this.txtComprobar.Name = "txtComprobar";
            this.txtComprobar.Size = new System.Drawing.Size(237, 99);
            this.txtComprobar.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.txtComprobar);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdLn);
            this.Controls.Add(this.cmdCos);
            this.Controls.Add(this.cmdSen);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button cmdSen;
        private System.Windows.Forms.Button cmdCos;
        private System.Windows.Forms.Button cmdLn;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComprobar;
    }
}

