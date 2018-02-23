using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitsYBytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
           int numero = Convert.ToInt32(txtNumero.Text);
            direccionMov(numero);
            nivelTanque(numero);
            sensor1(numero);
            sensor2(numero);
            fecha(numero);
        }

        public int direccionMov(int n)
        {
            int numero = (n >> 1) & 7;
            pBoxDireccion.Image = iListDireccion.Images[numero];
            return numero;
        }

        public int nivelTanque(int n)
        {
            int numero = (n >> 4) & 3;
            pBoxNivel.Image = iListNivel.Images[numero];
            return numero;
        }

        public int sensor2(int n)
        {
            int numero = (n >> 6) & 1;
            pBoxSensores2.Image = iListSensores.Images[numero];
            return numero;
        }

        public int sensor1(int n)
        {
            int numero = (n >> 7) & 1;
            pBoxSensores.Image = iListSensores.Images[numero];
            return numero;
        }

        public void fecha(int n)
        {
            int dia = (n >> 8) & 31;
            int mes = (n >> 13) & 15;
            int year = ((n >> 17) & 127)+1900;
            lblFecha.Text = year.ToString() + "/" + mes.ToString() + "/" + dia.ToString();
        }

        public int regresarFecha(string fecha)
        {
            int numero = Convert.ToInt32(txtFecha.Text);
            return numero;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmdAjustarFecha_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            txtNuevaFecha.Text = obtenerFecha(fecha).ToString();
        }

        public int obtenerFecha(string fecha)
        {
            String[] partes = fecha.Split('/');

            int dia = Convert.ToInt32(partes[0]);
            int mes = (Convert.ToInt32(partes[1])) << 5;
            int year = (Convert.ToInt32(partes[2]) - 1900) << 9;

            return dia + mes + year;
        }
    }
}
