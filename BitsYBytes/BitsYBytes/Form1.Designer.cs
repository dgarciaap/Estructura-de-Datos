namespace BitsYBytes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdProcesar = new System.Windows.Forms.Button();
            this.iListSensores = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cmdAjustarFecha = new System.Windows.Forms.Button();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.pBoxSensores = new System.Windows.Forms.PictureBox();
            this.pBoxNivel = new System.Windows.Forms.PictureBox();
            this.pBoxDireccion = new System.Windows.Forms.PictureBox();
            this.iListNivel = new System.Windows.Forms.ImageList(this.components);
            this.iListDireccion = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pBoxSensores2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(82, 22);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada:";
            // 
            // cmdProcesar
            // 
            this.cmdProcesar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProcesar.Location = new System.Drawing.Point(203, 19);
            this.cmdProcesar.Name = "cmdProcesar";
            this.cmdProcesar.Size = new System.Drawing.Size(75, 23);
            this.cmdProcesar.TabIndex = 2;
            this.cmdProcesar.Text = "Procesar";
            this.cmdProcesar.UseVisualStyleBackColor = true;
            this.cmdProcesar.Click += new System.EventHandler(this.cmdProcesar_Click);
            // 
            // iListSensores
            // 
            this.iListSensores.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListSensores.ImageStream")));
            this.iListSensores.TransparentColor = System.Drawing.Color.Transparent;
            this.iListSensores.Images.SetKeyName(0, "Apagado (2).png");
            this.iListSensores.Images.SetKeyName(1, "encendido.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(120, 191);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 16);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "fecha";
            this.lblFecha.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(67, 235);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 9;
            // 
            // cmdAjustarFecha
            // 
            this.cmdAjustarFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjustarFecha.Location = new System.Drawing.Point(74, 261);
            this.cmdAjustarFecha.Name = "cmdAjustarFecha";
            this.cmdAjustarFecha.Size = new System.Drawing.Size(87, 23);
            this.cmdAjustarFecha.TabIndex = 10;
            this.cmdAjustarFecha.Text = "Ajustar Fecha";
            this.cmdAjustarFecha.UseVisualStyleBackColor = true;
            this.cmdAjustarFecha.Click += new System.EventHandler(this.cmdAjustarFecha_Click);
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(67, 290);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaFecha.TabIndex = 11;
            // 
            // pBoxSensores
            // 
            this.pBoxSensores.Location = new System.Drawing.Point(15, 77);
            this.pBoxSensores.Name = "pBoxSensores";
            this.pBoxSensores.Size = new System.Drawing.Size(146, 103);
            this.pBoxSensores.TabIndex = 12;
            this.pBoxSensores.TabStop = false;
            // 
            // pBoxNivel
            // 
            this.pBoxNivel.Location = new System.Drawing.Point(345, 77);
            this.pBoxNivel.Name = "pBoxNivel";
            this.pBoxNivel.Size = new System.Drawing.Size(146, 103);
            this.pBoxNivel.TabIndex = 13;
            this.pBoxNivel.TabStop = false;
            this.pBoxNivel.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pBoxDireccion
            // 
            this.pBoxDireccion.Location = new System.Drawing.Point(518, 77);
            this.pBoxDireccion.Name = "pBoxDireccion";
            this.pBoxDireccion.Size = new System.Drawing.Size(146, 103);
            this.pBoxDireccion.TabIndex = 14;
            this.pBoxDireccion.TabStop = false;
            // 
            // iListNivel
            // 
            this.iListNivel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListNivel.ImageStream")));
            this.iListNivel.TransparentColor = System.Drawing.Color.Transparent;
            this.iListNivel.Images.SetKeyName(0, "vacio.png");
            this.iListNivel.Images.SetKeyName(1, "Medio.png");
            this.iListNivel.Images.SetKeyName(2, "lleno (2).png");
            this.iListNivel.Images.SetKeyName(3, "proceso.png");
            // 
            // iListDireccion
            // 
            this.iListDireccion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListDireccion.ImageStream")));
            this.iListDireccion.TransparentColor = System.Drawing.Color.Transparent;
            this.iListDireccion.Images.SetKeyName(0, "N (2).png");
            this.iListDireccion.Images.SetKeyName(1, "NE.png");
            this.iListDireccion.Images.SetKeyName(2, "E.png");
            this.iListDireccion.Images.SetKeyName(3, "SE.png");
            this.iListDireccion.Images.SetKeyName(4, "S.png");
            this.iListDireccion.Images.SetKeyName(5, "SO.png");
            this.iListDireccion.Images.SetKeyName(6, "O.png");
            this.iListDireccion.Images.SetKeyName(7, "NO.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sensores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nivel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Direccion";
            // 
            // pBoxSensores2
            // 
            this.pBoxSensores2.Location = new System.Drawing.Point(176, 77);
            this.pBoxSensores2.Name = "pBoxSensores2";
            this.pBoxSensores2.Size = new System.Drawing.Size(146, 103);
            this.pBoxSensores2.TabIndex = 18;
            this.pBoxSensores2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 337);
            this.Controls.Add(this.pBoxSensores2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pBoxDireccion);
            this.Controls.Add(this.pBoxNivel);
            this.Controls.Add(this.pBoxSensores);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.cmdAjustarFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdProcesar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdProcesar;
        private System.Windows.Forms.ImageList iListSensores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button cmdAjustarFecha;
        private System.Windows.Forms.TextBox txtNuevaFecha;
        private System.Windows.Forms.PictureBox pBoxSensores;
        private System.Windows.Forms.PictureBox pBoxNivel;
        private System.Windows.Forms.PictureBox pBoxDireccion;
        private System.Windows.Forms.ImageList iListNivel;
        private System.Windows.Forms.ImageList iListDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pBoxSensores2;
    }
}

