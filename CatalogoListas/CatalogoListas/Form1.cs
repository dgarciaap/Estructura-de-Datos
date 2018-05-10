using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoListas
{
    public partial class Form1 : Form
    {
        Inventario inventario = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (vacio())
                MessageBox.Show("Campos incompletos");
            else
            {
                int cod = Convert.ToInt32(txtCod.Text);
                string nombre = txtNombre.Text;
                int costo = Convert.ToInt32(txtCosto.Text);
                int cant = Convert.ToInt16(txtCant.Text);

                inventario.agregar(new Producto(cod, nombre, costo, cant));
                limpiar();
            }
        }

        public bool vacio()
        {
            if (txtCod.Text == "" || txtNombre.Text == "" || txtCosto.Text == "" || txtCant.Text == "")
                return true;
            else
                return false;
        }

        public void limpiar()
        {
            txtCod.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            txtCant.Text = "";
            txtPos.Text = "";
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            if (vacio())
                MessageBox.Show("Campos incompletos");
            else
            {
                int cod = Convert.ToInt32(txtCod.Text);
                string nombre = txtNombre.Text;
                int costo = Convert.ToInt32(txtCosto.Text);
                int cant = Convert.ToInt16(txtCant.Text);

                inventario.agregarEnInicio(new Producto(cod, nombre, costo, cant));
                limpiar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
                MessageBox.Show("Llene el campo de Código");
            else
                if (inventario.buscar(Convert.ToInt32(txtCod.Text)) == null)
                MessageBox.Show("producto inexistente");
            else
                txtDatos.Text = inventario.buscar(Convert.ToInt32(txtCod.Text)).ToString();

            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
                MessageBox.Show("Llene el campo de Código");
            else
            {
                if (inventario.eliminar(Convert.ToInt32(txtCod.Text)))
                {
                    MessageBox.Show("Producto eliminado");
                    txtDatos.Text = inventario.mostrar();
                }
                else
                    MessageBox.Show("Producto inexistente");
            }

            limpiar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (vacio())
                MessageBox.Show("Campos incompletos");
            else
            {
                int cod = Convert.ToInt32(txtCod.Text);
                string nombre = txtNombre.Text;
                int costo = Convert.ToInt32(txtCosto.Text);
                int cant = Convert.ToInt16(txtCant.Text);
                int pos = Convert.ToInt32(txtPos.Text);

                inventario.insertar(new Producto(cod, nombre, costo, cant), pos);
                limpiar();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = inventario.mostrar();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            
                if (inventario.eliminarPrimero())
                {
                    MessageBox.Show("Producto eliminado");
                    txtDatos.Text = inventario.mostrar();
                }
                else
                    MessageBox.Show("Producto inexistente");
            

            limpiar();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
           inventario.eliminarUltimo();
           txtDatos.Text = inventario.mostrar();
        }

        private void btnListarInverso_Click(object sender, EventArgs e)
        {
            txtDatos.Text = inventario.mostrarInverso();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            inventario.invertir();
            txtDatos.Text = inventario.mostrar();
        }
    }
}
