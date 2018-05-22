using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LsitasCirculares
{
    public partial class Form1 : Form
    {
        Ruta ruta = new Ruta();
        Bus bus;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtRuta.Text;
            double tiempo = Convert.ToDouble(txtTiempo.Text);
            bus = new Bus(nombre, tiempo);
            ruta.agregarUltimo(bus);
            clean();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtRuta.Text;
            txtDatos.Text = ruta.buscar(nombre).ToString();
            clean();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            ruta.eliminarUltimo();
            //txtDatos.Text = ruta.listar();
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            ruta.eliminarInicio();
            //txtDatos.Text = ruta.listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtRuta.Text;
            ruta.eliminar(nombre);
            txtDatos.Text = ruta.listar();
            clean();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = ruta.listar();
        }

        private void clean()
        {
            txtRuta.Text = "";
            txtTiempo.Text = "";
            txtRuta.Focus();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(txtPos.Text);
            string nombre = txtRuta.Text;
            double tiempo = Convert.ToDouble(txtTiempo.Text);
            bus = new Bus(nombre, tiempo);
            ruta.insertar(bus, pos);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string nombre = txtRuta.Text;
            double hrInicio = Convert.ToDouble(txtHrInicio.Text);
            double hrFinal = Convert.ToDouble(txtHrFinal.Text);
            txtDatos.Text = ruta.ruta(nombre, hrInicio, hrFinal);
        }
    }
}
