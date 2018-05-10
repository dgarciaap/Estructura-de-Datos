using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDobles
{
    public partial class Form1 : Form
    {
        Inventario inv = new Inventario();
        Producto prod;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCod.Text);
            int cantidad = Convert.ToInt32(txtCant.Text);
            string nombre = txtNombre.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            prod = new Producto(codigo, nombre, cantidad, costo);
            inv.agregar(prod);
            txtCod.Text = "";
            txtCant.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            txtCod.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = "";
            int cod = Convert.ToInt32(txtCod.Text);
            txtDatos.Text += inv.buscar(cod).ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCod.Text);
            inv.eliminar(cod);
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            inv.eliminarInicio();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            inv.eliminarUltimo();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           txtDatos.Text = inv.listar();
        }

        private void btnInvertido_Click(object sender, EventArgs e)
        {
           txtDatos.Text = inv.invertir();
        }
    }
}
