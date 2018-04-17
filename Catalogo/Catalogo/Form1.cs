using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        Admin catalogo = new Admin();
        Producto producto;
        public Form1()
        {
            InitializeComponent();
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
            if(txtNombre.Text == "" || txtCodigo.Text == "" || txtCant.Text == "" || txtCosto.Text == "" )
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
            else
            {
                if(catalogo._posActual < catalogo._vec.Length)
                {
                    string codigo = txtCodigo.Text;
                    string nombre = txtNombre.Text;
                    int cantidad = Convert.ToInt32(txtCant.Text);
                    double costo = Convert.ToDouble(txtCosto.Text);
                    producto = new Producto(codigo, nombre, cantidad, costo);
                    catalogo.agregar(producto);
                }
                else
                {
                    MessageBox.Show("Catálogo lleno");
                }
                limpiar();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtCant.Text == "" || txtCosto.Text == "")
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
            else
            {
                /*if (catalogo._posActual < catalogo._vec.Length)
                {*/
                    string codigo = txtCodigo.Text;
                    string nombre = txtNombre.Text;
                    int cantidad = Convert.ToInt32(txtCant.Text);
                    double costo = Convert.ToDouble(txtCosto.Text);
                    producto = new Producto(codigo, nombre, cantidad, costo);
                    int pos = Convert.ToInt32(txtPosicion.Text);
                    catalogo.insertar(producto, pos);
                /*}
                else
                {
                    MessageBox.Show("Catálogo lleno");*/
                }
                limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campo de código vacío");
            }
            else if (catalogo.buscar(Convert.ToString(txtCodigo.Text)) == null)
            {
                MessageBox.Show("Producto inexistente");
            }
            else
            {
                catalogo.eliminar(txtCodigo.Text);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campo de código vacío");
            }
            else if (catalogo.buscar(Convert.ToString(txtCodigo.Text)) == null)
            {
                MessageBox.Show("Producto inexistente");
            }
            else
            {
                txtDatos.Text = catalogo.buscar(txtCodigo.Text).ToString();
            }
        }
    }
    
}
