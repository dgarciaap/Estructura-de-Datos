using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresOrdenados
{
    public partial class Form1 : Form
    {
        Inventario catalogo = new Inventario();
        Producto producto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCant.Text = "";
            txtCosto.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtCant.Text == "" || txtCosto.Text == "")
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
            else
            {
               /* if (catalogo._posActual < catalogo._vec.Length)
                {*/
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    string nombre = txtNombre.Text;
                    int cantidad = Convert.ToInt32(txtCant.Text);
                    double costo = Convert.ToDouble(txtCosto.Text);
                    producto = new Producto(codigo, nombre, cantidad, costo);
                    catalogo.agregar(producto);
                /*}
                else
                {
                    MessageBox.Show("Catálogo lleno");
                }*/
                limpiar();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campo de código vacío");
            }
            else if (catalogo.buscar(Convert.ToInt32(txtCodigo.Text)) == null)
            {
                MessageBox.Show("Producto inexistente");
            }
            else
            {
                catalogo.eliminar(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show("Contacto eliminado");
                txtCodigo.Text = "";
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (catalogo.listar() == "")
            {
                MessageBox.Show("Catálogo vacío");
            }
            else
            {
                txtDatos.Text = catalogo.listar();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campo de código vacío");
            }
            else if (catalogo.buscar(Convert.ToInt32(txtCodigo.Text)) == null)
            {
                MessageBox.Show("Producto inexistente");
            }
            else
            {
                txtDatos.Text = catalogo.buscar(Convert.ToInt32(txtCodigo.Text)).ToString();
            }
        }
    }
}

